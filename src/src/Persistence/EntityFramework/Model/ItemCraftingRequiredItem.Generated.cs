// <copyright file="ItemCraftingRequiredItem.Generated.cs" company="MUnique">
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
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingRequiredItem"/>.
/// </summary>
[Table(nameof(ItemCraftingRequiredItem), Schema = SchemaNames.Configuration)]
internal partial class ItemCraftingRequiredItem : MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingRequiredItem, IIdentifiable
{
    /// <inheritdoc />
    public ItemCraftingRequiredItem()
    {
        this.InitJoinCollections();
    }

    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    

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
        this.PossibleItems = new ManyToManyCollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition, ItemCraftingRequiredItemItemDefinition>(this.JoinedPossibleItems, joinEntity => joinEntity.ItemDefinition, entity => new ItemCraftingRequiredItemItemDefinition { ItemCraftingRequiredItem = this, ItemCraftingRequiredItemId = this.Id, ItemDefinition = (ItemDefinition)entity, ItemDefinitionId = ((ItemDefinition)entity).Id});
        this.RequiredItemOptions = new ManyToManyCollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionType, ItemCraftingRequiredItemItemOptionType>(this.JoinedRequiredItemOptions, joinEntity => joinEntity.ItemOptionType, entity => new ItemCraftingRequiredItemItemOptionType { ItemCraftingRequiredItem = this, ItemCraftingRequiredItemId = this.Id, ItemOptionType = (ItemOptionType)entity, ItemOptionTypeId = ((ItemOptionType)entity).Id});
    }
}
