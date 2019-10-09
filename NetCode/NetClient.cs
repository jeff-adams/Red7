using System;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;

namespace NetCode
{
    public class NetClient
    {
        private ILogger logger;

        public NetClient(ILogger logger)
        {
            this.logger = logger;
        }

        public Task<TcpClient> ConnectAsync()
        {
            
        }
    }
}