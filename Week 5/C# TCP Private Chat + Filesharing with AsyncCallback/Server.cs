using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class Server
{
    private TcpListener listener;
    public event Action<string> OnMessageReceived;
    public event Action<string> OnFileReceived;

    public Server(string ip, int port)
    {
        listener = new TcpListener(IPAddress.Parse(ip), port);
    }

    public async Task StartAsync()
    {
        listener.Start();
        Console.WriteLine("Server started, waiting for connections...");

        while (true)
        {
            TcpClient client = await listener.AcceptTcpClientAsync();
            _ = HandleClientAsync(client);
        }
    }

    private async Task HandleClientAsync(TcpClient client)
    {
        using (NetworkStream stream = client.GetStream())
        {
            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                if (message.StartsWith("FILE:"))
                {
                    string filePath = message.Substring(5);
                    OnFileReceived?.Invoke(filePath);
                }
                else
                {
                    OnMessageReceived?.Invoke(message);
                }
            }
        }
    }

    public void Stop()
    {
        listener.Stop();
    }
}
