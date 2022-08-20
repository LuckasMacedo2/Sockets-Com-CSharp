using System.Net;
using System.Net.Sockets;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            IPEndPoint enpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            // Associando um socket a um endpoint
            socket.Bind(enpoint);

            // Escutando as requisições
            socket.Listen(5);

            Console.WriteLine("Escutando...");

            Socket escutar = socket.Accept();

            byte[] bytes = new byte[255];

            int tamanho = escutar.Receive(bytes, 0, bytes.Length, SocketFlags.None);

            Array.Resize(ref bytes, tamanho);

            Console.WriteLine("Mensagem do cliente: ");
            Console.WriteLine(System.Text.Encoding.Default.GetString(bytes));

            socket.Close();

            Console.WriteLine("Servidor finalizado\n Pressione qualquer tecla para finalizar ...");
            Console.ReadLine();
        }
    }
}