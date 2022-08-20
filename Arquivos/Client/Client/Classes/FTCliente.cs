using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client.Classes
{
    public class FTCliente
    {
        static IPEndPoint ipEnd_cliente;
        static Socket clientSocket;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/";

        public static Label LabelMensagem;

        public static void EnviarArquivo(string arquivo)
        {
            try
            {
                ipEnd_cliente = new IPEndPoint(IPAddress.Parse(EnderecoIP)  , PortaHost);
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";
                pasta = arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1);

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo);

                if(nomeArquivoByte.Length > 50000 * 1024)
                {
                    LabelMensagem.Invoke(new Action(() =>
                    {
                        LabelMensagem.ForeColor = Color.Red;
                        LabelMensagem.Text = "Arquivo maior que 50Mb, impossível de enviar";
                    }));
                    return;
                }

                string caminhoCompleto = pasta + arquivo;
                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLen.CopyTo(clientData, 0);
                nomeArquivoByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);

                clientSocket.Connect(ipEnd_cliente);
                clientSocket.Send(clientData, 0, clientData.Length, 0);
                clientSocket.Close();
                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Green;
                    LabelMensagem.Text = $"Arquivo [{arquivo}] transferido";
                }));

            }
            catch (Exception ex)
            {
                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = $"Erro {ex.Message}";
                }));
            }
            finally
            {
                clientSocket.Close();
            }
        }
    }
}
