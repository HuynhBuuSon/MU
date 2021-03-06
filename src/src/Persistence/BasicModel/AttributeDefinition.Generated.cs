// <copyright file="AttributeDefinition.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel;

using MUnique.OpenMU.Persistence.Json;

/// <summary>
/// A plain implementation of <see cref="AttributeDefinition"/>.
/// </summary>
public partial class AttributeDefinition : MUnique.OpenMU.AttributeSystem.AttributeDefinition, IIdentifiable, IConvertibleTo<AttributeDefinition>
{
    /// <inheritdoc />
    public AttributeDefinition()
    {
    }

    /// <inheritdoc />
    public AttributeDefinition(System.Guid id, System.String designation, System.String description)
        : base(id, designation, description)
    {
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

    /// <inheritdoc/>
    public AttributeDefinition Convert() => this;
}
