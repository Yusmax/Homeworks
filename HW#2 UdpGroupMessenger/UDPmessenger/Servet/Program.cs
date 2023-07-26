using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

class UdpServerExample
{
    private const int ServerPort = 5000;

    static void Main()
    {
        UdpClient server = new UdpClient(ServerPort);
        Dictionary<IPEndPoint, string> clientNicknames = new Dictionary<IPEndPoint, string>();

        Console.WriteLine("UDP Server is listening...");

        try
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, ServerPort);
            while (true)
            {
                byte[] data = server.Receive(ref clientEndPoint);
                string message = Encoding.UTF8.GetString(data);

                if (!clientNicknames.ContainsKey(clientEndPoint))
                {
                    // If the client is new and doesn't have a nickname, set it.
                    string nickname = message;
                    clientNicknames.Add(clientEndPoint, nickname);
                    Console.WriteLine($"Nickname set for {clientEndPoint}: {nickname}");
                }
                else
                {
                    // If the client already has a nickname, display the message with the nickname.
                    string nickname = clientNicknames[clientEndPoint];
                    Console.WriteLine($"{nickname}: {message}");
                }
            }
        }
        catch (SocketException ex)
        {
            Console.WriteLine($"Error receiving message: {ex.Message}");
        }
        finally
        {
            server.Close();
        }
    }
}