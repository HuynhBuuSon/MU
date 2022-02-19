﻿// <copyright file="ExitGatePicker.razor.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.AdminPanel.Components;

using System.Globalization;
using Microsoft.AspNetCore.Components;
using MUnique.OpenMU.AdminPanel.Map;
using MUnique.OpenMU.AdminPanel.Services;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.GameLogic;
using MUnique.OpenMU.Persistence;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Formats.Png;

/// <summary>
/// Blazor component which allows to select an exit gate.
/// </summary>
public partial class ExitGatePicker
{
    private const int SideLength = 256;

    private float _scale = 3;

    private Image<Rgba32> _terrainImage = null!;
    private GameMapDefinition? _map;

    /// <summary>
    /// Gets or sets the persistence context.
    /// </summary>
    [CascadingParameter]
    public IContext PersistenceContext { get; set; } = null!;

    /// <summary>
    /// Gets or sets the selected <see cref="ExitGate"/>.
    /// </summary>
    [Parameter]
    public ExitGate? SelectedGate { get; set; }

    /// <summary>
    /// Gets or sets the event callback for changes of <see cref="SelectedGate"/>.
    /// </summary>
    [Parameter]
    public EventCallback<ExitGate>? SelectedGateChanged { get; set; }

    [Inject]
    private ILookupController LookupController { get; set; } = null!;

    private GameMapDefinition? Map
    {
        get => this._map;
        set
        {
            if (this._map != value)
            {
                this._map = value;
                if (this._map is { })
                {
                    this._terrainImage = new GameMapTerrain(this._map).ToImage();
                }
            }
        }
    }

    private string ImageData => this._terrainImage.ToBase64String(PngFormat.Instance);

    /// <inheritdoc />
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        this.Map = this.SelectedGate?.Map;
    }

    private string GetCssClass(Gate gate)
    {
        if (this.SelectedGate == gate)
        {
            return "gate-exit focused-object";
        }

        return "gate-exit";
    }

    private string GetSizeAndPositionStyle(Gate gate)
    {
        return string.Format("width: {0}px; height: {1}px; top: {2}px; left:{3}px;",
            (this._scale * (1 + gate.Y2 - gate.Y1)).ToString(CultureInfo.InvariantCulture),
            (this._scale * (1 + gate.X2 - gate.X1)).ToString(CultureInfo.InvariantCulture),
            (this._scale * gate.X1).ToString(CultureInfo.InvariantCulture),
            (this._scale * gate.Y1).ToString(CultureInfo.InvariantCulture));
    }

    private async void OnSelected(ExitGate exitGate)
    {
        this.SelectedGate = exitGate;
        if (this.SelectedGateChanged is { } eventCallback)
        {
            await eventCallback.InvokeAsync(exitGate);
        }
    }

    private void OnMapSelected(ChangeEventArgs args)
    {
        if (Guid.TryParse(args.Value as string, out var mapId))
        {
            this.Map = this.PersistenceContext.GetById<GameMapDefinition>(mapId);
        }
    }
}