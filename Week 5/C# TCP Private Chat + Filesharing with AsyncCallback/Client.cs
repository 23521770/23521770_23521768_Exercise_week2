using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class Client
{
    private TcpClient tcpClient;
    private NetworkStream stream;

    public Client(string ip, int port)
    {
        tcpClient = new TcpClient();
        tcpClient.Connect(ip, port);
        stream = tcpClient.GetStream();
    }

    public async Task SendMessageAsync(string message)
    {
        byte[] buffer = Encoding.UTF8.GetBytes(message);
        await stream.WriteAsync(buffer, 0, buffer.Length);
    }

    public async Task SendFileAsync(string filePath)
    {
        byte[] fileData = File.ReadAllBytes(filePath);
        await stream.WriteAsync(Encoding.UTF8.GetBytes("FILE:" + filePath), 0, fileData.Length);
    }

    public void Close()
    {
        stream.Close();
        tcpClient.Close();
    }
}
