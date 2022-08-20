using System.Net;
using System.Net.Sockets;

namespace ClientChat
{
    public partial class Form1 : Form
    {

        private string NomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader stwReceptor;
        private TcpClient tcpServidor;

        private delegate void AtualizaLogCallback(string mensagem);
        
        private delegate void FechaConexaoCallback(string motivo);

        private Thread mensagemThread;

        private IPAddress enderecoIp;
        private int portaHost;
        private bool Conectado;


        public Form1()
        {
            Application.ApplicationExit += new EventHandler(OnAppliationExit);
            InitializeComponent();
        }

        private void button_Conectar_Click(object sender, EventArgs e)
        {
            if(!Conectado)
            {
                InicializaConexao();
            }
            else
            {
                FechaConexao("Desconectado pelo usuário");
            }
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            EnviaMensagem();
        }

        private void textBox_Mensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                EnviaMensagem();
        }

        private void InicializaConexao()
        {
            try
            {
                enderecoIp = IPAddress.Parse(textBox_IP.Text);
                portaHost = int.Parse(textBox_Porta.Text);
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIp, portaHost);

                Conectado = true;

                NomeUsuario = textBox_Nome.Text;

                textBox_IP.Enabled = false;
                textBox_Porta.Enabled = false;
                textBox_Nome.Enabled = false;
                textBox_Mensagem.Enabled = true;
                button_Enviar.Enabled = true;

                button_Conectar.ForeColor = Color.Red;
                button_Conectar.Text = "Desconectar";

                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(textBox_Nome.Text);
                stwEnviador.Flush();

                mensagemThread = new Thread(new ThreadStart(RecebeMensagem));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                label_Status.Invoke(new Action(() =>
                {
                    label_Status.ForeColor = Color.Red;
                    label_Status.Text = $"Conectado ao servidor de chat {enderecoIp}:{portaHost}";
                }));
            }
            catch (Exception ex)
            {
                label_Status.Invoke(new Action(() =>
                {
                    label_Status.ForeColor = Color.Red;
                    label_Status.Text = "Erro na conexão\n" + ex.Message;
                }));
            }
        }

        private void RecebeMensagem()
        {
            stwReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = stwReceptor.ReadLine();

            if (ConResposta[0] == '1')
            {
                this.Invoke(new AtualizaLogCallback(this.AtualizaLog), new object[] { "Conectado com sucesso" });
            }
            else
            {
                string motivo = "Não conectado: ";
                motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                this.Invoke(new AtualizaLogCallback(this.FechaConexao), new object[] { motivo });
            }

            while(Conectado)
            {
                this.Invoke(new AtualizaLogCallback(this.AtualizaLog), new object[] { stwReceptor.ReadLine() }) ;
            }
        }

        private void AtualizaLog(string mensagem)
        {
            textBox_Log.AppendText(mensagem + "\r\n");
        }

        private void EnviaMensagem()
        {
            if(textBox_Mensagem.Lines.Length >= 1)
            {
                stwEnviador.WriteLine(textBox_Mensagem.Text);
                stwEnviador.Flush();
                textBox_Mensagem.Lines = null;
            }
            textBox_Mensagem.Text = "";
        }

        private void FechaConexao(string motivo)
        {
            textBox_Log.AppendText(motivo + "\r\n");

            textBox_IP.Enabled = true;
            textBox_Porta.Enabled = true;
            textBox_Nome.Enabled = true;
            textBox_Mensagem.Enabled = false;
            button_Enviar.Enabled = false;
            button_Conectar.ForeColor = Color.Green;
            button_Conectar.Text = "Conectar";

            Conectado = false;
            stwEnviador.Close();
            stwReceptor.Close();
            tcpServidor.Close();

            label_Status.Invoke(new Action(() =>
            {
                label_Status.ForeColor = Color.Red;
                label_Status.Text = $"Desconectado do servidor de chat {enderecoIp}:{portaHost}";
            }));

        }

        public void OnAppliationExit(object sender, EventArgs e)
        {
            if (Conectado)
            {
                Conectado = false;
                stwEnviador.Close();
                stwReceptor.Close();
                tcpServidor.Close();

                label_Status.Invoke(new Action(() =>
                {
                    label_Status.ForeColor = Color.Red;
                    label_Status.Text = $"Desconectado do servidor de chat {enderecoIp}:{portaHost}";
                }));
            }
        }

    }
}