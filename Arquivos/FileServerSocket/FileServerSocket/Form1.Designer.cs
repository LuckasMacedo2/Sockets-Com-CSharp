namespace FileServerSocket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Porta = new System.Windows.Forms.TextBox();
            this.button_Conexao = new System.Windows.Forms.Button();
            this.button_PararServidor = new System.Windows.Forms.Button();
            this.linkLabel_Pasta = new System.Windows.Forms.LinkLabel();
            this.listBox_Logs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TFS - Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(12, 43);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(371, 23);
            this.textBox_IP.TabIndex = 1;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // textBox_Porta
            // 
            this.textBox_Porta.Location = new System.Drawing.Point(427, 43);
            this.textBox_Porta.Name = "textBox_Porta";
            this.textBox_Porta.Size = new System.Drawing.Size(103, 23);
            this.textBox_Porta.TabIndex = 2;
            this.textBox_Porta.Text = "1000";
            // 
            // button_Conexao
            // 
            this.button_Conexao.Location = new System.Drawing.Point(12, 72);
            this.button_Conexao.Name = "button_Conexao";
            this.button_Conexao.Size = new System.Drawing.Size(244, 53);
            this.button_Conexao.TabIndex = 3;
            this.button_Conexao.Text = "Estabelecer conexão";
            this.button_Conexao.UseVisualStyleBackColor = true;
            this.button_Conexao.Click += new System.EventHandler(this.button_Conexao_Click);
            // 
            // button_PararServidor
            // 
            this.button_PararServidor.Location = new System.Drawing.Point(262, 72);
            this.button_PararServidor.Name = "button_PararServidor";
            this.button_PararServidor.Size = new System.Drawing.Size(268, 53);
            this.button_PararServidor.TabIndex = 4;
            this.button_PararServidor.Text = "Parar servidor";
            this.button_PararServidor.UseVisualStyleBackColor = true;
            this.button_PararServidor.Click += new System.EventHandler(this.button_PararServidor_Click);
            // 
            // linkLabel_Pasta
            // 
            this.linkLabel_Pasta.Location = new System.Drawing.Point(16, 139);
            this.linkLabel_Pasta.Name = "linkLabel_Pasta";
            this.linkLabel_Pasta.Size = new System.Drawing.Size(512, 23);
            this.linkLabel_Pasta.TabIndex = 7;
            this.linkLabel_Pasta.TabStop = true;
            this.linkLabel_Pasta.Text = "Clique para selecionar a pasta ...";
            this.linkLabel_Pasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Pasta_LinkClicked);
            // 
            // listBox_Logs
            // 
            this.listBox_Logs.FormattingEnabled = true;
            this.listBox_Logs.ItemHeight = 15;
            this.listBox_Logs.Location = new System.Drawing.Point(12, 165);
            this.listBox_Logs.Name = "listBox_Logs";
            this.listBox_Logs.Size = new System.Drawing.Size(516, 274);
            this.listBox_Logs.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.listBox_Logs);
            this.Controls.Add(this.linkLabel_Pasta);
            this.Controls.Add(this.button_PararServidor);
            this.Controls.Add(this.button_Conexao);
            this.Controls.Add(this.textBox_Porta);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_IP;
        private TextBox textBox_Porta;
        private Button button_Conexao;
        private Button button_PararServidor;
        private LinkLabel linkLabel_Pasta;
        private ListBox listBox_Logs;
    }
}