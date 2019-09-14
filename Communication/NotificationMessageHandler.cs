using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WaveChat.Communication
{
    public class NotificationMessageHandler : CommunicationHandler
    {


        public NotificationMessageHandler(CommunicationManager webSocketConnectionManager) : base(webSocketConnectionManager)
        {




        }

        public override Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            string Id = Encoding.ASCII.GetString(buffer);
            Id = Id.Substring(0, 36);

            _communicationManager.AddSocket(socket,Id);

            return Task.CompletedTask;
        }



    }
}
