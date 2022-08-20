using FileServerSocket.Classes;

namespace FileServerSocket
{
    public partial class Form1 : Form
    {
        Task tarefa;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_PararServidor_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                listBox_Logs.Invoke(new Action(() =>
                {
                    listBox_Logs.Items.Add("Erro " + ex.Message);
                    listBox_Logs.SetSelected(listBox_Logs.Items.Count - 1, true);
                }));
            }
        }

        private void button_Conexao_Click(object sender, EventArgs e)
        {
            int porta = int.Parse(textBox_Porta.Text);
            string endIp = textBox_IP.Text;

            try
            {
                FTServer.EnderecoIP = endIp;
                FTServer.PortaHost = porta;

                tarefa = Task.Factory.StartNew(() =>
                {
                    FTServer.IniciarServidor();
                });
            }
            catch (Exception ex)
            {
                listBox_Logs.Invoke(new Action(() =>
                {
                    listBox_Logs.Items.Add("Erro ao receber o aquivo " + ex.Message);
                    listBox_Logs.SetSelected(listBox_Logs.Items.Count - 1, true);
                }));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel_Pasta.Text = FTServer.PastaRecepcaoArquivos;
            FTServer.ListaMensagem = listBox_Logs;
        }

        private void linkLabel_Pasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() != DialogResult.Cancel)
            {
                FTServer.PastaRecepcaoArquivos = dialog.SelectedPath + @"\";
                linkLabel_Pasta.Text = FTServer.PastaRecepcaoArquivos;
            }
        }
    }
}