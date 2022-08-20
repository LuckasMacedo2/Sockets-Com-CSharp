using ChatServer.Classes;
using System.Net;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);
        bool conectado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if(conectado)
            {
                Application.Exit();
                return;
            }

            if(textBox_IP.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço IP");
                textBox_IP.Focus();
                return;
            }

            try
            {
                IPAddress enderecoIP = IPAddress.Parse(textBox_IP.Text);
                int portaHost = int.Parse(textBox_Porta.Text);

                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                mainServidor.IniciaAtendimento();

                listBox_Logs.Items.Add("Aguardando conexões...");
                listBox_Logs.SetSelected(listBox_Logs.Items.Count - 1, true);
            }
            catch (Exception ex)
            {
                listBox_Logs.Items.Add("Erro: " + ex.Message);
                listBox_Logs.SetSelected(listBox_Logs.Items.Count - 1, true);
                return;
            }

            conectado = true;
            textBox_IP.Enabled = false;
            textBox_Porta.Enabled = false;
            button_Start.ForeColor = Color.Red;
            button_Start.Text = "Sair";
        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string mensagem)
        {
            listBox_Logs.Items.Add(mensagem);
            listBox_Logs.SetSelected(listBox_Logs.Items.Count - 1, true);
        }
    }
}