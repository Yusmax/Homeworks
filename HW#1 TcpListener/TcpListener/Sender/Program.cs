using System.Net;
using System.Net.Sockets;
 
using TcpClient tcpClient = new TcpClient();
Console.WriteLine("Client started");
await tcpClient.ConnectAsync("127.0.0.1", 8080);
 
if (tcpClient.Connected)
    Console.WriteLine($"Connected with: {tcpClient.Client.RemoteEndPoint}");
else
    Console.WriteLine("I can't connect");