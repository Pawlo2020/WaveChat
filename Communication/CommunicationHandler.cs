using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Net.WebSockets;
using System.Text;

namespace WaveChat.Communication
{

    public abstract class CommunicationHandler
    {
        //CommunicationManager handler
        public CommunicationManager _communicationManager { get; set; }

        /// <summary>
        /// Create CommunicationHandler object that correspond to CommunicationManager
        /// </summary>
        /// <param name="webSocketConnectionManager"></param>
        public CommunicationHandler(CommunicationManager webSocketConnectionManager)
        { 
            _communicationManager = webSocketConnectionManager;
        }


        /// <summary>
        /// Add the connected socket to the socket list in the communication manager in case of established connection
        /// </summary>
        /// <param name="socket"></param>
        /// <returns></returns>
        //public virtual async Task OnConnected(WebSocket socket)
        //{
        //    _communicationManager.AddSocket(socket);
        //}

        /// <summary>
        /// Remove the connected socket from the socket list in the communication manager in case of disconnected connection
        /// </summary>
        /// <param name="socket"></param>
        /// <returns></returns>
        public virtual async Task OnDisconnected(ConnectedSocket socket)
        {
            await _communicationManager.RemoveSocket(_communicationManager.GetId(socket));
        }

        /// <summary>
        /// Send a message to the specified WebSocket using the WebSocket variable
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessageAsync(ConnectedSocket socket, string message)
        {
            if (socket.Socket.State != WebSocketState.Open)
                return;

            await socket.Socket.SendAsync(buffer: new ArraySegment<byte>(array: Encoding.UTF8.GetBytes(message),
                                                                  offset: 0,
                                                                  count: Encoding.UTF8.GetBytes(message).Length),
                                   messageType: WebSocketMessageType.Text,
                                   endOfMessage: true,
                                   cancellationToken: CancellationToken.None);
        }

        /// <summary>
        /// Send a message to the specified WebSocket using the WebSocket ID
        /// </summary>-
        public async Task SendMessageAsync(string socketId, string message)
        {
            await SendMessageAsync(_communicationManager.GetSocketById(socketId), message);
        }


        /// <summary>
        /// Send a message to all the connected WebSockets
        /// </summary>
        public async Task SendMessageToAllAsync(string message)
        {
            foreach (var pair in _communicationManager.GetAll())
            {
                if (pair.Value.Socket.State == WebSocketState.Open)
                    await SendMessageAsync(pair.Value, message);
            }
        }

        public async Task SendMessageToFirst(string message)
        {
            await SendMessageAsync(_communicationManager.GetAll().FirstOrDefault().Value,message);

        }

        /// <summary>
        /// Receive a message from the specified WebSocket
        /// </summary>
        public abstract Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer);













    }
}
