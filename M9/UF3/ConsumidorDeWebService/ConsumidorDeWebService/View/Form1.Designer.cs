namespace ConsumidorDeWebService.View
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArtistes = new System.Windows.Forms.DataGridView();
            this.bFiltrar = new System.Windows.Forms.Button();
            this.tbFiltre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAfegir = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEsborrar = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtre:";
            // 
            // dgvArtistes
            // 
            this.dgvArtistes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtistes.Location = new System.Drawing.Point(44, 92);
            this.dgvArtistes.MultiSelect = false;
            this.dgvArtistes.Name = "dgvArtistes";
            this.dgvArtistes.ReadOnly = true;
            this.dgvArtistes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtistes.Size = new System.Drawing.Size(470, 268);
            this.dgvArtistes.TabIndex = 1;
            // 
            // bFiltrar
            // 
            this.bFiltrar.Location = new System.Drawing.Point(529, 24);
            this.bFiltrar.Name = "bFiltrar";
            this.bFiltrar.Size = new System.Drawing.Size(75, 23);
            this.bFiltrar.TabIndex = 2;
            this.bFiltrar.Text = "Filtrar";
            this.bFiltrar.UseVisualStyleBackColor = true;
            // 
            // tbFiltre
            // 
            this.tbFiltre.Location = new System.Drawing.Point(71, 26);
            this.tbFiltre.Name = "tbFiltre";
            this.tbFiltre.Size = new System.Drawing.Size(443, 20);
            this.tbFiltre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom:";
            // 
            // bAfegir
            // 
            this.bAfegir.Location = new System.Drawing.Point(529, 257);
            this.bAfegir.Name = "bAfegir";
            this.bAfegir.Size = new System.Drawing.Size(75, 23);
            this.bAfegir.TabIndex = 5;
            this.bAfegir.Text = "Afegir";
            this.bAfegir.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(529, 298);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 6;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bEsborrar
            // 
            this.bEsborrar.Location = new System.Drawing.Point(529, 337);
            this.bEsborrar.Name = "bEsborrar";
            this.bEsborrar.Size = new System.Drawing.Size(75, 23);
            this.bEsborrar.TabIndex = 7;
            this.bEsborrar.Text = "Esborrar";
            this.bEsborrar.UseVisualStyleBackColor = true;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(71, 389);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(443, 20);
            this.tbNom.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Artistes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.bEsborrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAfegir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFiltre);
            this.Controls.Add(this.bFiltrar);
            this.Controls.Add(this.dgvArtistes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvArtistes;
        public System.Windows.Forms.Button bFiltrar;
        public System.Windows.Forms.TextBox tbFiltre;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button bAfegir;
        public System.Windows.Forms.Button bModificar;
        public System.Windows.Forms.Button bEsborrar;
        public System.Windows.Forms.TextBox tbNom;
        public System.Windows.Forms.Label label3;
    }
}

