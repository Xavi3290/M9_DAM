namespace PruebaWebService1.View
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCharacters = new System.Windows.Forms.DataGridView();
            this.dgvHouses = new System.Windows.Forms.DataGridView();
            this.cbCharacters = new System.Windows.Forms.ComboBox();
            this.cbHouses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(29, 85);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(240, 150);
            this.dgvBooks.TabIndex = 0;
            // 
            // cbBooks
            // 
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(29, 58);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(121, 21);
            this.cbBooks.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // dgvCharacters
            // 
            this.dgvCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacters.Location = new System.Drawing.Point(321, 85);
            this.dgvCharacters.MultiSelect = false;
            this.dgvCharacters.Name = "dgvCharacters";
            this.dgvCharacters.ReadOnly = true;
            this.dgvCharacters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCharacters.Size = new System.Drawing.Size(240, 150);
            this.dgvCharacters.TabIndex = 4;
            // 
            // dgvHouses
            // 
            this.dgvHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouses.Location = new System.Drawing.Point(621, 85);
            this.dgvHouses.MultiSelect = false;
            this.dgvHouses.Name = "dgvHouses";
            this.dgvHouses.ReadOnly = true;
            this.dgvHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouses.Size = new System.Drawing.Size(240, 150);
            this.dgvHouses.TabIndex = 5;
            // 
            // cbCharacters
            // 
            this.cbCharacters.FormattingEnabled = true;
            this.cbCharacters.Location = new System.Drawing.Point(321, 58);
            this.cbCharacters.Name = "cbCharacters";
            this.cbCharacters.Size = new System.Drawing.Size(121, 21);
            this.cbCharacters.TabIndex = 6;
            // 
            // cbHouses
            // 
            this.cbHouses.FormattingEnabled = true;
            this.cbHouses.Location = new System.Drawing.Point(621, 58);
            this.cbHouses.Name = "cbHouses";
            this.cbHouses.Size = new System.Drawing.Size(121, 21);
            this.cbHouses.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHouses);
            this.Controls.Add(this.cbCharacters);
            this.Controls.Add(this.dgvHouses);
            this.Controls.Add(this.dgvCharacters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.dgvBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvBooks;
        public System.Windows.Forms.ComboBox cbBooks;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvCharacters;
        public System.Windows.Forms.DataGridView dgvHouses;
        public System.Windows.Forms.ComboBox cbCharacters;
        public System.Windows.Forms.ComboBox cbHouses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

