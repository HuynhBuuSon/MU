// <copyright file="ItemDropItemGroupItemDefinition.Generated.cs" company="MUnique">
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
using MUnique.OpenMU.Persistence.EntityFramework;

[Table(nameof(ItemDropItemGroupItemDefinition), Schema = SchemaNames.Configuration)]
internal partial class ItemDropItemGroupItemDefinition
{
    public Guid ItemDropItemGroupId { get; set; }
    public ItemDropItemGroup ItemDropItemGroup { get; set; }

    public Guid ItemDefinitionId { get; set; }
    public ItemDefinition ItemDefinition { get; set; }
}

internal partial class ItemDropItemGroup
{
    public ICollection<ItemDropItemGroupItemDefinition> JoinedPossibleItems { get; } = new EntityFramework.List<ItemDropItemGroupItemDefinition>();
}
