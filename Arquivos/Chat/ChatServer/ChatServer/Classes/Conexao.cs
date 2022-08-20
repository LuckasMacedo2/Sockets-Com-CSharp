using System.Net.Sockets;

namespace ChatServer.Classes
{
    public class Conexao
    {
        TcpClient tcpClient;
        private Thread thrSender;
        private StreamReader srReceptor;
        private StreamWriter swEnviador;
        private string usuarioAtual;
        private string resposta;

        public Conexao(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            thrSender = new Thread(AceitaCliente);
            thrSender.IsBackground = true;
            thrSender.Start();
        }

        private void FechaConexao()
        {
            tcpClient.Close();
            srReceptor.Close();
            swEnviador.Close();
        }

        private void AceitaCliente()
        {
            srReceptor = new StreamReader(tcpClient.GetStream());
            swEnviador = new StreamWriter(tcpClient.GetStream());

            usuarioAtual = srReceptor.ReadLine();

            if(usuarioAtual != "")
            {
                if(Servidor.htUsuarios.Contains(usuarioAtual))
                {
                    swEnviador.WriteLine("0|Este nome de usuário já existe.");
                    swEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else if(usuarioAtual == "Administrador")
                {
                    swEnviador.WriteLine("0|Este nome de usuário é reservado.");
                    swEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else
                {
                    swEnviador.WriteLine("1");
                    swEnviador.Flush();

                    Servidor.IncluiUsuario(tcpClient, usuarioAtual);
                }
            }
            else
            {
                FechaConexao();
                return;
            }

            try
            {
                while((resposta = srReceptor.ReadLine()) != "")
                {
                    if(resposta == null)
                    {
                        Servidor.RemoveUsuario(tcpClient);
                    }
                    else
                    {
                        Servidor.EnviaMensagem(usuarioAtual, resposta);
                    }
                }
            }
            catch (Exception ex)
            {
                Servidor.RemoveUsuario(tcpClient);
            }
        }
    }
}
