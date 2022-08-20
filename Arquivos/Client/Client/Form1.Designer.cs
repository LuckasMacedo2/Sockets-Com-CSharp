namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Porta = new System.Windows.Forms.TextBox();
            this.linkLabel_Arquivo = new System.Windows.Forms.LinkLabel();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(12, 35);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(301, 23);
            this.textBox_IP.TabIndex = 0;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "TFSClient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Porta
            // 
            this.textBox_Porta.Location = new System.Drawing.Point(319, 35);
            this.textBox_Porta.Name = "textBox_Porta";
            this.textBox_Porta.Size = new System.Drawing.Size(100, 23);
            this.textBox_Porta.TabIndex = 2;
            this.textBox_Porta.Text = "1000";
            // 
            // linkLabel_Arquivo
            // 
            this.linkLabel_Arquivo.Location = new System.Drawing.Point(12, 61);
            this.linkLabel_Arquivo.Name = "linkLabel_Arquivo";
            this.linkLabel_Arquivo.Size = new System.Drawing.Size(407, 23);
            this.linkLabel_Arquivo.TabIndex = 3;
            this.linkLabel_Arquivo.TabStop = true;
            this.linkLabel_Arquivo.Text = "Clique para selecionar um arquivo";
            this.linkLabel_Arquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Arquivo_LinkClicked);
            // 
            // button_Enviar
            // 
            this.button_Enviar.Location = new System.Drawing.Point(12, 87);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(407, 23);
            this.button_Enviar.TabIndex = 4;
            this.button_Enviar.Text = "Enviar arquivo";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // label_Status
            // 
            this.label_Status.ForeColor = System.Drawing.Color.Green;
            this.label_Status.Location = new System.Drawing.Point(12, 133);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(407, 129);
            this.label_Status.TabIndex = 5;
            this.label_Status.Text = "Status";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 289);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Enviar);
            this.Controls.Add(this.linkLabel_Arquivo);
            this.Controls.Add(this.textBox_Porta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_IP;
        private Label label1;
        private TextBox textBox_Porta;
        private LinkLabel linkLabel_Arquivo;
        private Button button_Enviar;
        private Label label_Status;
    }
}