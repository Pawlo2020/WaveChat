﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace WaveChat.Communication
{
    public class CommunicationManager
    {
        private ConcurrentDictionary<string, ConnectedSocket> _sockets = new ConcurrentDictionary<string, ConnectedSocket>();

        public ConnectedSocket GetSocketById(string id)
        {
            return _sockets.FirstOrDefault(p => p.Key == id).Value;
        }

        public ConcurrentDictionary<string, ConnectedSocket> GetAll()
        {
            return _sockets;
        }

        public string GetId(ConnectedSocket socket)
        {
            return _sockets.FirstOrDefault(p => p.Value == socket).Key;
        }
        public void AddSocket(WebSocket socket, string Id)
        {
            ConnectedSocket connSocket = new ConnectedSocket();
            connSocket.Socket = socket;
            _sockets.TryAdd(Id, connSocket);
        }

        public void ChangeID(WebSocket socket, string Id)
        {
            

        }


        public async Task RemoveSocket(string id)
        {
            ConnectedSocket socket;
            _sockets.TryRemove(id, out socket);

            await socket.Socket.CloseAsync(closeStatus: WebSocketCloseStatus.NormalClosure,
                                    statusDescription: "Closed by the WebSocketManager",
                                    cancellationToken: CancellationToken.None);
        }

        private string CreateConnectionId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
