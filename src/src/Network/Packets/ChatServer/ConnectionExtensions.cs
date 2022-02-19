﻿// <copyright file="ConnectionExtensions.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by an XSL transformation.
//     Do not change this file. Instead, change the XML data which contains
//     the packet definitions and re-run the transformation (rebuild this project).
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable RedundantVerbatimPrefix
// ReSharper disable AssignmentIsFullyDiscarded
// ReSharper disable UnusedMember.Global
// ReSharper disable UseObjectOrCollectionInitializer
namespace MUnique.OpenMU.Network.Packets.ChatServer;

using System;
using System.Threading;
using MUnique.OpenMU.Network;

/// <summary>
/// Extension methods to start writing messages of this namespace on a <see cref="IConnection"/>.
/// </summary>
public static class ConnectionExtensions
{

    /// <summary>
    /// Starts a safe write of a <see cref="Authenticate" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <remarks>
    /// Is sent by the client when: This packet is sent by the client after it connected to the server, to authenticate itself.
    /// Causes reaction on server side: The server will check the token. If it's correct, the client gets added to the requested chat room.
    /// </remarks>
    public static AuthenticateThreadSafeWriter StartWriteAuthenticate(this IConnection connection)
    {
        return new (connection);
    }

    /// <summary>
    /// Starts a safe write of a <see cref="ChatRoomClientJoined" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <remarks>
    /// Is sent by the server when: This packet is sent by the server after another chat client joined the chat room.
    /// Causes reaction on client side: The client will add the client in its list (if over 2 clients are connected to the same room), or show its name in the title bar.
    /// </remarks>
    public static ChatRoomClientJoinedThreadSafeWriter StartWriteChatRoomClientJoined(this IConnection connection)
    {
        return new (connection);
    }

    /// <summary>
    /// Starts a safe write of a <see cref="ChatRoomClientLeft" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <remarks>
    /// Is sent by the server when: This packet is sent by the server after a chat client left the chat room.
    /// Causes reaction on client side: The client will remove the client from its list, or mark its name in the title bar as offline.
    /// </remarks>
    public static ChatRoomClientLeftThreadSafeWriter StartWriteChatRoomClientLeft(this IConnection connection)
    {
        return new (connection);
    }

    /// <summary>
    /// Starts a safe write of a <see cref="KeepAlive" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <remarks>
    /// Is sent by the client when: This packet is sent by the client in a fixed interval.
    /// Causes reaction on server side: The server will keep the connection and chat room intact as long as the clients sends a message in a certain period of time.
    /// </remarks>
    public static KeepAliveThreadSafeWriter StartWriteKeepAlive(this IConnection connection)
    {
        return new (connection);
    }

    /// <summary>
    /// Sends a <see cref="Authenticate" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="roomId">The room id.</param>
    /// <param name="token">A token (integer number), formatted as string. This value is also "encrypted" with the 3-byte XOR key (FC CF AB).</param>
    /// <remarks>
    /// Is sent by the client when: This packet is sent by the client after it connected to the server, to authenticate itself.
    /// Causes reaction on server side: The server will check the token. If it's correct, the client gets added to the requested chat room.
    /// </remarks>
    public static void SendAuthenticate(this IConnection connection, ushort @roomId, string @token)
    {
        using var writer = connection.StartWriteAuthenticate();
        var packet = writer.Packet;
        packet.RoomId = @roomId;
        packet.Token = @token;
        writer.Commit();
    }

    /// <summary>
    /// Sends a <see cref="ChatRoomClientJoined" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="clientIndex">The client index.</param>
    /// <param name="name">The name.</param>
    /// <remarks>
    /// Is sent by the server when: This packet is sent by the server after another chat client joined the chat room.
    /// Causes reaction on client side: The client will add the client in its list (if over 2 clients are connected to the same room), or show its name in the title bar.
    /// </remarks>
    public static void SendChatRoomClientJoined(this IConnection connection, byte @clientIndex, string @name)
    {
        using var writer = connection.StartWriteChatRoomClientJoined();
        var packet = writer.Packet;
        packet.ClientIndex = @clientIndex;
        packet.Name = @name;
        writer.Commit();
    }

    /// <summary>
    /// Sends a <see cref="ChatRoomClientLeft" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="clientIndex">The client index.</param>
    /// <param name="name">The name.</param>
    /// <remarks>
    /// Is sent by the server when: This packet is sent by the server after a chat client left the chat room.
    /// Causes reaction on client side: The client will remove the client from its list, or mark its name in the title bar as offline.
    /// </remarks>
    public static void SendChatRoomClientLeft(this IConnection connection, byte @clientIndex, string @name)
    {
        using var writer = connection.StartWriteChatRoomClientLeft();
        var packet = writer.Packet;
        packet.ClientIndex = @clientIndex;
        packet.Name = @name;
        writer.Commit();
    }

    /// <summary>
    /// Sends a <see cref="ChatMessage" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="senderIndex">The sender index.</param>
    /// <param name="messageLength">The message length.</param>
    /// <param name="message">The message. It's "encrypted" with the 3-byte XOR key (FC CF AB).</param>
    /// <remarks>
    /// Is sent by the server when: This packet is sent by the server after another chat client sent a message to the current chat room.
    /// Causes reaction on client side: The client will show the message.
    /// </remarks>
    public static void SendChatMessage(this IConnection connection, byte @senderIndex, byte @messageLength, string @message)
    {
        using var writer = connection.StartSafeWrite(ChatMessage.HeaderType, ChatMessage.GetRequiredSize(message));
        var packet = new ChatMessage(writer.Span);
        packet.SenderIndex = @senderIndex;
        packet.MessageLength = @messageLength;
        packet.Message = @message;
        writer.Commit();
    }

    /// <summary>
    /// Sends a <see cref="KeepAlive" /> to this connection.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <remarks>
    /// Is sent by the client when: This packet is sent by the client in a fixed interval.
    /// Causes reaction on server side: The server will keep the connection and chat room intact as long as the clients sends a message in a certain period of time.
    /// </remarks>
    public static void SendKeepAlive(this IConnection connection)
    {
        using var writer = connection.StartWriteKeepAlive();
        writer.Commit();
    }}
/// <summary>
/// A helper struct to write a <see cref="Authenticate"/> safely to a <see cref="IConnection.Output" />.
/// </summary>
public readonly ref struct AuthenticateThreadSafeWriter
{
    private readonly IConnection connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticateThreadSafeWriter" /> struct.
    /// </summary>
    /// <param name="connection">The connection.</param>
    public AuthenticateThreadSafeWriter(IConnection connection)
    {
        this.connection = connection;
        this.connection.OutputLock.Wait();
        try
        {
            // Initialize header and default values
            var span = this.Span;
            span.Clear();
            _ = new Authenticate(span);
        }
        catch (InvalidOperationException)
        {
            this.connection.OutputLock.Release();
            throw;
        }
    }

    /// <summary>Gets the span to write at.</summary>
    private Span<byte> Span => this.connection.Output.GetSpan(Authenticate.Length)[..Authenticate.Length];

    /// <summary>Gets the packet to write at.</summary>
    public Authenticate Packet => this.Span;

    /// <summary>
    /// Commits the data of the <see cref="Authenticate" />.
    /// </summary>
    public void Commit()
    {
        this.connection.Output.AdvanceSafely(Authenticate.Length);
    }

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    public void Dispose()
    {
        this.connection.OutputLock.Release();
    }
}
      
/// <summary>
/// A helper struct to write a <see cref="ChatRoomClientJoined"/> safely to a <see cref="IConnection.Output" />.
/// </summary>
public readonly ref struct ChatRoomClientJoinedThreadSafeWriter
{
    private readonly IConnection connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatRoomClientJoinedThreadSafeWriter" /> struct.
    /// </summary>
    /// <param name="connection">The connection.</param>
    public ChatRoomClientJoinedThreadSafeWriter(IConnection connection)
    {
        this.connection = connection;
        this.connection.OutputLock.Wait();
        try
        {
            // Initialize header and default values
            var span = this.Span;
            span.Clear();
            _ = new ChatRoomClientJoined(span);
        }
        catch (InvalidOperationException)
        {
            this.connection.OutputLock.Release();
            throw;
        }
    }

    /// <summary>Gets the span to write at.</summary>
    private Span<byte> Span => this.connection.Output.GetSpan(ChatRoomClientJoined.Length)[..ChatRoomClientJoined.Length];

    /// <summary>Gets the packet to write at.</summary>
    public ChatRoomClientJoined Packet => this.Span;

    /// <summary>
    /// Commits the data of the <see cref="ChatRoomClientJoined" />.
    /// </summary>
    public void Commit()
    {
        this.connection.Output.AdvanceSafely(ChatRoomClientJoined.Length);
    }

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    public void Dispose()
    {
        this.connection.OutputLock.Release();
    }
}
      
/// <summary>
/// A helper struct to write a <see cref="ChatRoomClientLeft"/> safely to a <see cref="IConnection.Output" />.
/// </summary>
public readonly ref struct ChatRoomClientLeftThreadSafeWriter
{
    private readonly IConnection connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatRoomClientLeftThreadSafeWriter" /> struct.
    /// </summary>
    /// <param name="connection">The connection.</param>
    public ChatRoomClientLeftThreadSafeWriter(IConnection connection)
    {
        this.connection = connection;
        this.connection.OutputLock.Wait();
        try
        {
            // Initialize header and default values
            var span = this.Span;
            span.Clear();
            _ = new ChatRoomClientLeft(span);
        }
        catch (InvalidOperationException)
        {
            this.connection.OutputLock.Release();
            throw;
        }
    }

    /// <summary>Gets the span to write at.</summary>
    private Span<byte> Span => this.connection.Output.GetSpan(ChatRoomClientLeft.Length)[..ChatRoomClientLeft.Length];

    /// <summary>Gets the packet to write at.</summary>
    public ChatRoomClientLeft Packet => this.Span;

    /// <summary>
    /// Commits the data of the <see cref="ChatRoomClientLeft" />.
    /// </summary>
    public void Commit()
    {
        this.connection.Output.AdvanceSafely(ChatRoomClientLeft.Length);
    }

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    public void Dispose()
    {
        this.connection.OutputLock.Release();
    }
}
      
/// <summary>
/// A helper struct to write a <see cref="KeepAlive"/> safely to a <see cref="IConnection.Output" />.
/// </summary>
public readonly ref struct KeepAliveThreadSafeWriter
{
    private readonly IConnection connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="KeepAliveThreadSafeWriter" /> struct.
    /// </summary>
    /// <param name="connection">The connection.</param>
    public KeepAliveThreadSafeWriter(IConnection connection)
    {
        this.connection = connection;
        this.connection.OutputLock.Wait();
        try
        {
            // Initialize header and default values
            var span = this.Span;
            span.Clear();
            _ = new KeepAlive(span);
        }
        catch (InvalidOperationException)
        {
            this.connection.OutputLock.Release();
            throw;
        }
    }

    /// <summary>Gets the span to write at.</summary>
    private Span<byte> Span => this.connection.Output.GetSpan(KeepAlive.Length)[..KeepAlive.Length];

    /// <summary>Gets the packet to write at.</summary>
    public KeepAlive Packet => this.Span;

    /// <summary>
    /// Commits the data of the <see cref="KeepAlive" />.
    /// </summary>
    public void Commit()
    {
        this.connection.Output.AdvanceSafely(KeepAlive.Length);
    }

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    public void Dispose()
    {
        this.connection.OutputLock.Release();
    }
}
      