using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class UdpClientExample
{
    private const int ServerPort = 5000;
    private static readonly IPAddress ServerIp = IPAddress.Parse("127.0.0.1");

    static void Main()
    {
        using (var client = new UdpClient())
        {
            IPEndPoint serverEndPoint = new IPEndPoint(ServerIp, ServerPort);

            Console.Write("Enter a nickname: ");
            string nickname = Console.ReadLine();
            byte[] nicknameData = Encoding.UTF8.GetBytes(nickname);
            client.Send(nicknameData, nicknameData.Length, serverEndPoint);

            Console.WriteLine("Enter 'stop' to stop the client.");

            while (true)
            {
                Console.Write("Enter a message: ");
                string message = Console.ReadLine();

                if (message == "stop")
                    break;

                byte[] data = Encoding.UTF8.GetBytes(message);
                client.Send(data, data.Length, serverEndPoint);
            }
        }
    }
}