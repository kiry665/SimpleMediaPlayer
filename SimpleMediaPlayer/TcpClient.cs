using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class TcpClientEx
{
    private const int bufferSize = 4096;
    private TcpClient tcpClient;
    private NetworkStream networkStream;
    public bool connected = false;

    public async Task Connect(string ipAddress, int port)
    {
        try
        {
            if (!connected)
            {
                tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(ipAddress, port);
                networkStream = tcpClient.GetStream();
                connected = true;
                Console.WriteLine("Connected to the server.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error connecting to the server: {ex.Message}");
        }
    }

    public async Task SendData(string data)
    {
        try
        {
            if (networkStream != null && tcpClient != null)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                await networkStream.WriteAsync(buffer, 0, buffer.Length);
                Console.WriteLine("Data sent successfully.");
            }
            else
            {
                Console.WriteLine("Not connected to the server.");
                connected = false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending data: {ex.Message}");
        }
    }

    public void Disconnect()
    {
        networkStream?.Dispose();
        tcpClient?.Close();
        connected = false;
        Console.WriteLine("Disconnected from the server.");
    }
}
