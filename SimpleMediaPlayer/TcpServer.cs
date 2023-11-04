using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMediaPlayer
{
    internal class TcpServer
    {
        private Form1 formInstance;
        public TcpServer(Form1 form)
        {
            formInstance = form;
        }
        private TcpListener server;
        private bool isRunning;

        public async Task Start(int port)
        {
            try
            {
                server = new TcpListener(IPAddress.Any, port);
                server.Start();
                isRunning = true;

                Console.WriteLine($"Сервер запущен. Ожидание подключений на порту {port}...");

                while (isRunning)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();

                    _ = HandleClientAsync(client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при запуске сервера: {ex.Message}");
            }
        }

        public void Stop()
        {
            isRunning = false;
            server.Stop();
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                Console.WriteLine("Клиент подключен.");
                NetworkStream stream = client.GetStream();

                // Чтение данных от клиента в бесконечном цикле
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine("Получены данные от клиента: " + data);

                    formInstance.RecieveData(data);

                    string response = "Сообщение получено успешно.";
                    byte[] responseData = Encoding.ASCII.GetBytes(response);
                    await stream.WriteAsync(responseData, 0, responseData.Length);
                    Console.WriteLine("Отправлен ответ клиенту: " + response);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обработке клиента: {ex.Message}");
            }
        }
    }
}
