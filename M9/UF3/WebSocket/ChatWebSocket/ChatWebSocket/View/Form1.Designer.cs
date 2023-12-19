namespace ChatWebSocket.View
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuari = new System.Windows.Forms.TextBox();
            this.textBoxEnviar = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(56, 49);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(185, 20);
            this.textBoxServer.TabIndex = 0;
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(475, 49);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(85, 23);
            this.buttonConectar.TabIndex = 1;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uri Server";
            // 
            // listBoxChat
            // 
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.Location = new System.Drawing.Point(56, 87);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(504, 290);
            this.listBoxChat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom Usuari";
            // 
            // textBoxUsuari
            // 
            this.textBoxUsuari.Location = new System.Drawing.Point(275, 49);
            this.textBoxUsuari.Name = "textBoxUsuari";
            this.textBoxUsuari.Size = new System.Drawing.Size(171, 20);
            this.textBoxUsuari.TabIndex = 4;
            // 
            // textBoxEnviar
            // 
            this.textBoxEnviar.Location = new System.Drawing.Point(56, 400);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(410, 20);
            this.textBoxEnviar.TabIndex = 6;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(485, 398);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 7;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsuari);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.textBoxServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxServer;
        public System.Windows.Forms.Button buttonConectar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBoxChat;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxUsuari;
        public System.Windows.Forms.TextBox textBoxEnviar;
        public System.Windows.Forms.Button buttonEnviar;
    }
}

