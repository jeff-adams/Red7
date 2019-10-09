using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace NetCode
{
    public class NetServer
    {
        private ILogger logger;
        private const int port = 1015;
        
        public NetServer(ILogger logger)
        {
            this.logger = logger;
        }

        public Task<TcpClient> HostConnectionAsync()
        {
            var server = new TcpListener(IPAddress.Any, port);
            server.Start();
            logger.LogInformation($"Server started on port {port}");
            return server.AcceptTcpClientAsync();    
        }
    }
}