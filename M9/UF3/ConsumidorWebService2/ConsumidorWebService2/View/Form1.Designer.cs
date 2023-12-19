namespace ConsumidorWebService2.View
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
            this.dgvMaquillaje = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGenteMarca = new System.Windows.Forms.DataGridView();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMarcaProducto = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridView();
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.bFiltrar = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquillaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenteMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaquillaje
            // 
            this.dgvMaquillaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquillaje.Location = new System.Drawing.Point(37, 64);
            this.dgvMaquillaje.MultiSelect = false;
            this.dgvMaquillaje.Name = "dgvMaquillaje";
            this.dgvMaquillaje.ReadOnly = true;
            this.dgvMaquillaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaquillaje.Size = new System.Drawing.Size(238, 209);
            this.dgvMaquillaje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maquillaje";
            // 
            // dgvGenteMarca
            // 
            this.dgvGenteMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGenteMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenteMarca.Location = new System.Drawing.Point(328, 103);
            this.dgvGenteMarca.MultiSelect = false;
            this.dgvGenteMarca.Name = "dgvGenteMarca";
            this.dgvGenteMarca.ReadOnly = true;
            this.dgvGenteMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenteMarca.Size = new System.Drawing.Size(238, 170);
            this.dgvGenteMarca.TabIndex = 6;
            // 
            // tbMarca
            // 
            this.tbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMarca.Location = new System.Drawing.Point(326, 64);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gente con la Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Marca + Producto";
            // 
            // dgvMarcaProducto
            // 
            this.dgvMarcaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMarcaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcaProducto.Location = new System.Drawing.Point(37, 311);
            this.dgvMarcaProducto.MultiSelect = false;
            this.dgvMarcaProducto.Name = "dgvMarcaProducto";
            this.dgvMarcaProducto.ReadOnly = true;
            this.dgvMarcaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcaProducto.Size = new System.Drawing.Size(238, 209);
            this.dgvMarcaProducto.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipo Color";
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicas.Location = new System.Drawing.Point(326, 311);
            this.dgvCaracteristicas.MultiSelect = false;
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            this.dgvCaracteristicas.ReadOnly = true;
            this.dgvCaracteristicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaracteristicas.Size = new System.Drawing.Size(241, 209);
            this.dgvCaracteristicas.TabIndex = 14;
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFiltrar.Location = new System.Drawing.Point(37, 12);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(100, 20);
            this.tbFiltrar.TabIndex = 16;
            // 
            // bFiltrar
            // 
            this.bFiltrar.Location = new System.Drawing.Point(168, 12);
            this.bFiltrar.Name = "bFiltrar";
            this.bFiltrar.Size = new System.Drawing.Size(75, 23);
            this.bFiltrar.TabIndex = 17;
            this.bFiltrar.Text = "Filtro";
            this.bFiltrar.UseVisualStyleBackColor = true;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(326, 21);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrecio.Location = new System.Drawing.Point(464, 64);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Marca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 546);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.bFiltrar);
            this.Controls.Add(this.tbFiltrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCaracteristicas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMarcaProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.dgvGenteMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMaquillaje);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquillaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenteMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvMaquillaje;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvGenteMarca;
        public System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgvMarcaProducto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvCaracteristicas;
        public System.Windows.Forms.TextBox tbFiltrar;
        public System.Windows.Forms.Button bFiltrar;
        public System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label8;
    }
}

