using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace WaveChat.Communication
{
    public class ConnectedSocket
    {
        public WebSocket Socket;

        public CancellationTokenSource TokenSource;

        public string ConfGUID;

        public bool InstantiateToast;
    }
}
