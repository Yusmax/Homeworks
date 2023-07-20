using System.Net;
using System.Net.Sockets;
 
var tcpListener = new TcpListener(IPAddress.Any, 8080);
try
{
    tcpListener.Start();    // запуск сервера
    Console.WriteLine("Server started. Waiting for connection... ");
 
    while (true)
    {
        // получаем подключение в виде TcpClient
        using var tcpClient = await tcpListener.AcceptTcpClientAsync();
        Console.WriteLine($"Connected with: {tcpClient.Client.RemoteEndPoint}");
    }
}
finally
{
    Console.WriteLine("Server stopped!");
    tcpListener.Stop(); // выключение сервера
}