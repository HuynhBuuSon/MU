// <copyright file="ItemDefinitionItemSetGroup.Generated.cs" company="MUnique">
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

[Table(nameof(ItemDefinitionItemSetGroup), Schema = SchemaNames.Configuration)]
internal partial class ItemDefinitionItemSetGroup
{
    public Guid ItemDefinitionId { get; set; }
    public ItemDefinition ItemDefinition { get; set; }

    public Guid ItemSetGroupId { get; set; }
    public ItemSetGroup ItemSetGroup { get; set; }
}

internal partial class ItemDefinition
{
    public ICollection<ItemDefinitionItemSetGroup> JoinedPossibleItemSetGroups { get; } = new EntityFramework.List<ItemDefinitionItemSetGroup>();
}
