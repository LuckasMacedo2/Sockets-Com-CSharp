namespace ChatServer
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
            this.button_Start = new System.Windows.Forms.Button();
            this.listBox_Logs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(12, 12);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(221, 23);
            this.textBox_IP.TabIndex = 0;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // textBox_Porta
            // 
            this.textBox_Porta.Location = new System.Drawing.Point(239, 12);
            this.textBox_Porta.Name = "textBox_Porta";
            this.textBox_Porta.Size = new System.Drawing.Size(87, 23);
            this.textBox_Porta.TabIndex = 1;
            this.textBox_Porta.Text = "1000";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(332, 11);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(162, 23);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start server";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // listBox_Logs
            // 
            this.listBox_Logs.FormattingEnabled = true;
            this.listBox_Logs.ItemHeight = 15;
            this.listBox_Logs.Location = new System.Drawing.Point(12, 41);
            this.listBox_Logs.Name = "listBox_Logs";
            this.listBox_Logs.Size = new System.Drawing.Size(482, 199);
            this.listBox_Logs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 248);
            this.Controls.Add(this.listBox_Logs);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_Porta);
            this.Controls.Add(this.textBox_IP);
            this.Name = "Form1";
            this.Text = "Servidor de chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_IP;
        private TextBox textBox_Porta;
        private Button button_Start;
        private ListBox listBox_Logs;
    }
}