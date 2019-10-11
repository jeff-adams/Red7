using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Red7
{
    public class ConnectionManager
    {
        private const int port = 1015;

        public Task<TcpClient> HostConnectionAsync()
        {
            var server = new TcpListener(IPAddress.Any, port);
            server.Start();
            return server.AcceptTcpClientAsync();    
        }

        public Task JoinConnectionAsync(IPAddress ip)
        {
            using var client = new TcpClient();
            client.Connect(ip, port);
            return null;
        }
    }
}