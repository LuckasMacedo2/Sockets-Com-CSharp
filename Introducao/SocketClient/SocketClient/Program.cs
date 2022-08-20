using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            

            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

                socket.Connect(endpoint);

                Console.WriteLine("Cone~xão realizada com sucesso...");
                Console.WriteLine("Informe a informação para enviar:");
                Console.WriteLine();

                string info = Console.ReadLine();

                byte[] infoEnviar = Encoding.Default.GetBytes(info);

                socket.Send(infoEnviar, 0, infoEnviar.Length, SocketFlags.None);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro aoo conectar ao servidor");
            }

            socket.Close();

            Console.WriteLine("Sucesso! Digite qualquer tecla para continuar");
            Console.ReadLine();

        }
    }
}