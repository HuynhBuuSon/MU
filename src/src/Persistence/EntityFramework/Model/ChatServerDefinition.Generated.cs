// <copyright file="ChatServerDefinition.Generated.cs" company="MUnique">
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
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.ChatServerDefinition"/>.
/// </summary>
[Table(nameof(ChatServerDefinition), Schema = SchemaNames.Configuration)]
internal partial class ChatServerDefinition : MUnique.OpenMU.DataModel.Configuration.ChatServerDefinition, IIdentifiable
{
    
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets the raw collection of <see cref="Endpoints" />.
    /// </summary>
    public ICollection<ChatServerEndpoint> RawEndpoints { get; } = new EntityFramework.List<ChatServerEndpoint>();
    
    /// <inheritdoc/>
    [NotMapped]
    public override ICollection<MUnique.OpenMU.DataModel.Configuration.ChatServerEndpoint> Endpoints => base.Endpoints ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.ChatServerEndpoint, ChatServerEndpoint>(this.RawEndpoints);


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

    
}
