﻿// <copyright file="MapEditor.razor.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.AdminPanel.Components;

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using MUnique.OpenMU.AdminPanel.Interop;
using MUnique.OpenMU.AdminPanel.Map;
using MUnique.OpenMU.AdminPanel.Services;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.GameLogic;
using MUnique.OpenMU.Persistence;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

public partial class MapEditor : IDisposable
{

    private Image<Rgba32> _terrainImage = null!;

    private float _scale = 3;

    private object? _focusedObject;
    private Resizers.ResizerPosition? _resizerPosition;
    private bool _createMode;

    /// <summary>
    /// Gets or sets the map which is edited in this component.
    /// </summary>
    [Parameter]
    public GameMapDefinition Map { get; set; } = null!;

    /// <summary>
    /// Gets or sets the <see cref="EditForm.OnValidSubmit"/> event callback.
    /// </summary>
    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    /// <summary>
    /// Gets or sets the persistence context.
    /// </summary>
    [CascadingParameter]
    public IContext PersistenceContext { get; set; } = null!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = null!;

    [Inject]
    private GameConfiguration GameConfiguration { get; set; } = null!;

    /// <summary>
    /// Gets or sets the javascript runtime.
    /// </summary>
    /// <remarks>
    /// It's used for the resizing stuff. There is room for improvement, though.
    /// Currently, every mouse move in the resize process causes additional network roundtrips.
    /// This means, the resizing might be laggy and a bit buggy. It may make sense to do more stuff in javascript instead.
    /// </remarks>
    [Inject]
    private IJSRuntime JsRuntime { get; set; } = null!;

    /// <summary>
    /// Gets or sets the change notification service.
    /// </summary>
    [Inject]
    private IChangeNotificationService NotificationService { get; set; } = null!;

    /// <inheritdoc />
    public void Dispose()
    {
        this.NotificationService.PropertyChanged -= this.OnPropertyChanged;
    }

    /// <inheritdoc />
    protected override void OnInitialized()
    {
        base.OnInitialized();
        this.NotificationService.PropertyChanged += this.OnPropertyChanged;
    }

    /// <inheritdoc />
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        this._terrainImage = new GameMapTerrain(this.Map).ToImage();
    }

    private void OnPropertyChanged(object? sender, PropertyChangedEventArgs args)
    {
        if (sender == this._focusedObject)
        {
            this.StateHasChanged();
        }
    }

    private Task? OnCancel()
    {
        this._focusedObject = null;
        return null;
    }

    private IEnumerable<object> GetMapObjects()
    {
        return this.Map.EnterGates.OfType<object>()
            .Concat(this.Map.ExitGates)
            .Concat(this.Map.MonsterSpawns);
    }

    private bool ShowResizers(object obj)
    {
        if (obj is MonsterSpawnArea spawn
            && spawn.X1 == spawn.X2 && spawn.Y1 == spawn.Y2)
        {
            return false;
        }

        return obj == this._focusedObject;
    }

    private bool ShowArrow(object obj, [MaybeNullWhen(false)] out MonsterSpawnArea spawn)
    {
        spawn = obj as MonsterSpawnArea;
        return spawn is not null
               && this._focusedObject == spawn
               && spawn.X1 == spawn.X2
               && spawn.Y1 == spawn.Y2;
    }

    private string GetCssClass(object obj)
    {
        var result = string.Empty;
        switch (obj)
        {
            case EnterGate:
                result = "gate-enter";
                break;
            case ExitGate:
                result = "gate-exit";
                break;
            case MonsterSpawnArea spawn:
                result = spawn.X1 != spawn.X2 || spawn.Y1 != spawn.Y2 ? "spawn-area" : "spawn-single";
                break;


        }
        if (this._focusedObject == obj)
        {
            result += " focused-object";
        }

        return result;
    }

    private string GetSizeAndPositionStyle(object obj)
    {
        if (obj is Gate gate)
        {
            return this.GetSizeAndPositionStyle(gate);
        }

        if (obj is MonsterSpawnArea spawn)
        {
            return this.GetSizeAndPositionStyle(spawn);
        }

        return string.Empty;
    }

    private string GetSizeAndPositionStyle(Gate gate)
    {
        return string.Format("width: {0}px; height: {1}px; top: {2}px; left:{3}px;",
            (_scale * (1 + gate.Y2 - gate.Y1)).ToString(CultureInfo.InvariantCulture),
            (_scale * (1 + gate.X2 - gate.X1)).ToString(CultureInfo.InvariantCulture),
            (_scale * gate.X1).ToString(CultureInfo.InvariantCulture),
            (_scale * gate.Y1).ToString(CultureInfo.InvariantCulture));
    }

    private string GetSizeAndPositionStyle(MonsterSpawnArea spawn)
    {
        var objScale = 1.0f;

        var result = new StringBuilder();

        if (spawn.X1 == spawn.X2 && spawn.Y1 == spawn.Y2)
        {
            // We want the small point to be more visible, so it's bigger and has a higher opacity.
            objScale = 1.75f;
        }

        // X and Y are twisted, it's not an error!
        var width = objScale * this._scale * (1 + spawn.Y2 - spawn.Y1);
        var height = objScale * this._scale * (1 + spawn.X2 - spawn.X1);
        var xyOffset = (objScale - 1.0f) * this._scale;
        var top = this._scale * spawn.X1 - xyOffset;
        var left = this._scale * spawn.Y1 - xyOffset;
        result.Append($"width: {width.ToString(CultureInfo.InvariantCulture)}px;")
            .Append($"height: {height.ToString(CultureInfo.InvariantCulture)}px;")
            .Append($"top: {top.ToString(CultureInfo.InvariantCulture)}px;")
            .Append($"left: {left.ToString(CultureInfo.InvariantCulture)}px;");

        return result.ToString();
    }

    private void OnObjectSelected(ChangeEventArgs args)
    {
        var obj = this.Map.EnterGates.FirstOrDefault<object>(g => g.GetId().ToString() == args.Value?.ToString())
                  ?? this.Map.ExitGates.FirstOrDefault<object>(g => g.GetId().ToString() == args.Value?.ToString())
                  ?? this.Map.MonsterSpawns.FirstOrDefault(g => g.GetId().ToString() == args.Value?.ToString());
        this._focusedObject = obj;
    }

    private async Task<(byte X, byte Y)?> OnGetObjectCoordinates(MouseEventArgs args)
    {
        if (args.Buttons == 1)
        {
            // For GetMapHostBoundingClientRect(), see map.js
            // Warning: it's NOT working with the Edge Browser! BoundingClientRect gets all values with 0.
            var mapClientRect = await this.JsRuntime.InvokeAsync<BoundingClientRect>("GetMapHostBoundingClientRect");
            var x = (args.ClientY - mapClientRect.Top) / _scale;
            var y = (args.ClientX - mapClientRect.Left) / _scale;
            return ((byte)x, (byte)y);
        }

        return null;
    }

    private void OnStartResizing(Resizers.ResizerPosition? position)
    {
        this._resizerPosition = position;
    }

    private async Task OnMouseMove(MouseEventArgs args)
    {
        if (this._resizerPosition is null)
        {
            return;
        }

        if (await this.OnGetObjectCoordinates(args) is { } coordinates)
        {
            var (x, y) = coordinates;

            switch (this._focusedObject)
            {
                case MonsterSpawnArea spawnArea:
                    this.OnSpawnAreaResizing(spawnArea, x, y);
                    break;
                case Gate gate:
                    this.OnGateResizing(gate, x, y);
                    break;
            }

            this.NotificationService.NotifyChange(this._focusedObject, null);
        }
    }

    private void OnSpawnAreaResizing(MonsterSpawnArea spawnArea, byte x, byte y)
    {
        switch (this._resizerPosition)
        {
            case Resizers.ResizerPosition.TopLeft:
                spawnArea.X1 = x;
                spawnArea.Y1 = y;
                break;
            case Resizers.ResizerPosition.TopRight:
                spawnArea.X1 = x;
                spawnArea.Y2 = y;
                break;
            case Resizers.ResizerPosition.BottomRight:
                spawnArea.X2 = x;
                spawnArea.Y2 = y;
                break;
            case Resizers.ResizerPosition.BottomLeft:
                spawnArea.X2 = x;
                spawnArea.Y1 = y;
                break;
        }
    }

    private void OnGateResizing(Gate gate, byte x, byte y)
    {
        switch (this._resizerPosition)
        {
            case Resizers.ResizerPosition.TopLeft:
                gate.X1 = x;
                gate.Y1 = y;
                break;
            case Resizers.ResizerPosition.TopRight:
                gate.X1 = x;
                gate.Y2 = y;
                break;
            case Resizers.ResizerPosition.BottomRight:
                gate.X2 = x;
                gate.Y2 = y;
                break;
            case Resizers.ResizerPosition.BottomLeft:
                gate.X2 = x;
                gate.Y1 = y;
                break;
        }
    }

    private string? GetFocusedRotation()
    {
        if (this._focusedObject is MonsterSpawnArea spawn)
        {
            return spawn.Direction.ToString().ToLowerInvariant();
        }

        return null;
    }

    private void CreateNewSpawnArea()
    {
        this._createMode = true;

        var area = this.PersistenceContext.CreateNew<MonsterSpawnArea>();
        area.GameMap = this.Map;
        this.Map.MonsterSpawns.Add(area);
        area.X1 = 100;
        area.Y1 = 100;
        area.X2 = 200;
        area.Y2 = 200;
        area.Quantity = 1;

        this._focusedObject = area;
    }

    private void CreateNewEnterGate()
    {
        this._createMode = true;

        var enterGate = this.PersistenceContext.CreateNew<EnterGate>();
        this.Map.EnterGates.Add(enterGate);
        enterGate.X1 = 120;
        enterGate.Y1 = 120;
        enterGate.X2 = 140;
        enterGate.Y2 = 140;

        this._focusedObject = enterGate;
    }

    private void CreateNewExitGate()
    {
        this._createMode = true;

        var exitGate = this.PersistenceContext.CreateNew<ExitGate>();
        this.Map.ExitGates.Add(exitGate);
        exitGate.X1 = 120;
        exitGate.Y1 = 120;
        exitGate.X2 = 140;
        exitGate.Y2 = 140;

        this._focusedObject = exitGate;
    }

    private void CancelCreation()
    {
        if (!this._createMode)
        {
            return;
        }

        this._createMode = false;
        this.RemoveFocusedObject();
    }

    private void RemoveFocusedObject()
    {
        switch (this._focusedObject)
        {
            case MonsterSpawnArea spawnArea:
                this.Map.MonsterSpawns.Remove(spawnArea);
                break;
            case EnterGate enterGate:
                this.Map.EnterGates.Remove(enterGate);
                break;
            case ExitGate exitGate:
                this.Map.ExitGates.Remove(exitGate);
                break;
            default:
                return;
        }

        this.PersistenceContext.Delete(this._focusedObject);
        this._focusedObject = null;
    }

    private void OnMapSelected(ChangeEventArgs args)
    {
        this.NavigationManager.NavigateTo($"/map-editor/{args.Value}");
    }
}