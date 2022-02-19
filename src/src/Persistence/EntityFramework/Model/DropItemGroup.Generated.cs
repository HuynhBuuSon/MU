// <copyright file="DropItemGroup.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.EntityFramework.Model;

using System.ComponentModel.DataAnnotations.Schema;
using MUnique.OpenMU.Persistence;

/// <summary>
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.DropItemGroup"/>.
/// </summary>
[Table(nameof(DropItemGroup), Schema = SchemaNames.Configuration)]
internal partial class DropItemGroup : MUnique.OpenMU.DataModel.Configuration.DropItemGroup, IIdentifiable
{
    /// <inheritdoc />
    public DropItemGroup()
    {
        this.InitJoinCollections();
    }

    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the identifier of <see cref="Monster"/>.
    /// </summary>
    public Guid? MonsterId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="Monster" />.
    /// </summary>
    [ForeignKey(nameof(MonsterId))]
    public MonsterDefinition RawMonster
    {
        get => base.Monster as MonsterDefinition;
        set => base.Monster = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.MonsterDefinition Monster
    {
        get => base.Monster;set
        {
            base.Monster = value;
            this.MonsterId = this.RawMonster?.Id;
        }
    }


    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        var baseObject = obj as IIdentifiable;
        if (baseObject != null)
        {
            return baseObject.Id == this.Id;
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

    protected void InitJoinCollections()
    {
        this.PossibleItems = new ManyToManyCollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition, DropItemGroupItemDefinition>(this.JoinedPossibleItems, joinEntity => joinEntity.ItemDefinition, entity => new DropItemGroupItemDefinition { DropItemGroup = this, DropItemGroupId = this.Id, ItemDefinition = (ItemDefinition)entity, ItemDefinitionId = ((ItemDefinition)entity).Id});
    }
}
