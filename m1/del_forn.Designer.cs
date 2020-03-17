namespace M1
{
    partial class del_forn
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
            this.button3 = new System.Windows.Forms.Button();
            this.dvgProd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnome = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdeletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::M1.Properties.Resources.atualizar;
            this.button3.Location = new System.Drawing.Point(17, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 37;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dvgProd
            // 
            this.dvgProd.AllowUserToAddRows = false;
            this.dvgProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dvgProd.Location = new System.Drawing.Point(85, 83);
            this.dvgProd.Name = "dvgProd";
            this.dvgProd.RowHeadersVisible = false;
            this.dvgProd.Size = new System.Drawing.Size(495, 282);
            this.dvgProd.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codigo";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descricao";
            this.Column2.HeaderText = "NOME";
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(204, 30);
            this.txtnome.Mask = "00000";
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(54, 20);
            this.txtnome.TabIndex = 32;
            this.txtnome.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Image = global::M1.Properties.Resources.cancelar;
            this.button1.Location = new System.Drawing.Point(17, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtdeletar
            // 
            this.txtdeletar.Location = new System.Drawing.Point(264, 28);
            this.txtdeletar.Name = "txtdeletar";
            this.txtdeletar.Size = new System.Drawing.Size(141, 23);
            this.txtdeletar.TabIndex = 30;
            this.txtdeletar.Text = "DELETAR";
            this.txtdeletar.UseVisualStyleBackColor = true;
            this.txtdeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "DIGITE O CODIGO PARA DELETAR";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::M1.Properties.Resources.View;
            this.button2.Location = new System.Drawing.Point(17, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "ATUALIZAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(26, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "SAIR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "VISUALIZAR";
            // 
            // del_forn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dvgProd);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdeletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "del_forn";
            this.ShowIcon = false;
            this.Text = "TELA PARA DELETAR FORNECEDORES";
            this.Load += new System.EventHandler(this.del_forn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dvgProd;
        private System.Windows.Forms.MaskedTextBox txtnome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtdeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}