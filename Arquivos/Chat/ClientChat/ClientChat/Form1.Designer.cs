namespace ClientChat
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
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Porta = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button_Conectar = new System.Windows.Forms.Button();
            this.textBox_Mensagem = new System.Windows.Forms.TextBox();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(15, 10);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(404, 23);
            this.textBox_IP.TabIndex = 0;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // textBox_Porta
            // 
            this.textBox_Porta.Location = new System.Drawing.Point(425, 10);
            this.textBox_Porta.Name = "textBox_Porta";
            this.textBox_Porta.Size = new System.Drawing.Size(135, 23);
            this.textBox_Porta.TabIndex = 1;
            this.textBox_Porta.Text = "1000";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(15, 39);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(404, 23);
            this.textBox_Nome.TabIndex = 2;
            this.textBox_Nome.Text = "Visitante";
            // 
            // button_Conectar
            // 
            this.button_Conectar.ForeColor = System.Drawing.Color.Green;
            this.button_Conectar.Location = new System.Drawing.Point(425, 39);
            this.button_Conectar.Name = "button_Conectar";
            this.button_Conectar.Size = new System.Drawing.Size(135, 23);
            this.button_Conectar.TabIndex = 3;
            this.button_Conectar.Text = "Conectar";
            this.button_Conectar.UseVisualStyleBackColor = true;
            this.button_Conectar.Click += new System.EventHandler(this.button_Conectar_Click);
            // 
            // textBox_Mensagem
            // 
            this.textBox_Mensagem.Location = new System.Drawing.Point(15, 327);
            this.textBox_Mensagem.Name = "textBox_Mensagem";
            this.textBox_Mensagem.Size = new System.Drawing.Size(401, 23);
            this.textBox_Mensagem.TabIndex = 5;
            this.textBox_Mensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Mensagem_KeyPress);
            // 
            // button_Enviar
            // 
            this.button_Enviar.Location = new System.Drawing.Point(425, 327);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(135, 23);
            this.button_Enviar.TabIndex = 6;
            this.button_Enviar.Text = "Enviar";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // label_Status
            // 
            this.label_Status.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_Status.Location = new System.Drawing.Point(18, 358);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(542, 83);
            this.label_Status.TabIndex = 7;
            this.label_Status.Text = "Não conectado";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(12, 68);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.Size = new System.Drawing.Size(548, 253);
            this.textBox_Log.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Enviar);
            this.Controls.Add(this.textBox_Mensagem);
            this.Controls.Add(this.button_Conectar);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.textBox_Porta);
            this.Controls.Add(this.textBox_IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_IP;
        private TextBox textBox_Porta;
        private TextBox textBox_Nome;
        private Button button_Conectar;
        private TextBox textBox_Mensagem;
        private Button button_Enviar;
        private Label label_Status;
        private TextBox textBox_Log;
    }
}