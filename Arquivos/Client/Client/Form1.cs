using Client.Classes;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTCliente.LabelMensagem = label_Status;
        }

        private void linkLabel_Arquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Enviar arquivo";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                linkLabel_Arquivo.Text = dialog.FileName;
            }
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_IP.Text) || string.IsNullOrEmpty(textBox_Porta.Text) || linkLabel_Arquivo.Text == "Clique para selecionar um arquivo")
            {
                label_Status.ForeColor = Color.Red;
                label_Status.Text = "Dados inválidos";
                return;
            }

            string enderecoIP = textBox_IP.Text;
            int porta = int.Parse(textBox_Porta.Text);
            string nomeArquivo = linkLabel_Arquivo.Text;

            FTCliente.EnderecoIP = enderecoIP;
            FTCliente.PortaHost = porta;

            try
            {
                Task.Factory.StartNew(() =>
                {
                    FTCliente.EnviarArquivo(nomeArquivo);
                });
            }
            catch (Exception ex)
            {
                label_Status.ForeColor = Color.Red;
                label_Status.Text = "Erro: " + ex.Message;
                throw;
            }
        }
    }
}