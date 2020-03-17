namespace M1
{
    partial class caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caixa));
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtparte = new System.Windows.Forms.TextBox();
            this.dvgProd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.maskestoque = new System.Windows.Forms.MaskedTextBox();
            this.qtd = new System.Windows.Forms.TextBox();
            this.maskpreco = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.btngravar = new System.Windows.Forms.Button();
            this.txttotalcompra = new System.Windows.Forms.TextBox();
            this.DESCRIÇÃO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbuscar.Location = new System.Drawing.Point(201, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(105, 23);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // txtparte
            // 
            this.txtparte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtparte.Location = new System.Drawing.Point(8, 12);
            this.txtparte.Name = "txtparte";
            this.txtparte.Size = new System.Drawing.Size(174, 20);
            this.txtparte.TabIndex = 16;
            // 
            // dvgProd
            // 
            this.dvgProd.AllowUserToAddRows = false;
            this.dvgProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dvgProd.EnableHeadersVisualStyles = false;
            this.dvgProd.Location = new System.Drawing.Point(8, 38);
            this.dvgProd.Name = "dvgProd";
            this.dvgProd.RowHeadersVisible = false;
            this.dvgProd.ShowRowErrors = false;
            this.dvgProd.Size = new System.Drawing.Size(404, 119);
            this.dvgProd.TabIndex = 18;
            this.dvgProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvgProd_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codigo";
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descricao";
            this.Column2.HeaderText = "DESCRICAO";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cod_barras";
            this.Column3.HeaderText = "CODIGO DE BARRAS";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(459, 199);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(102, 20);
            this.txttotal.TabIndex = 19;
            // 
            // maskestoque
            // 
            this.maskestoque.Enabled = false;
            this.maskestoque.Location = new System.Drawing.Point(92, 66);
            this.maskestoque.Mask = "000";
            this.maskestoque.Name = "maskestoque";
            this.maskestoque.Size = new System.Drawing.Size(28, 20);
            this.maskestoque.TabIndex = 45;
            this.maskestoque.ValidatingType = typeof(int);
            // 
            // qtd
            // 
            this.qtd.Location = new System.Drawing.Point(100, 257);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(53, 20);
            this.qtd.TabIndex = 44;
            // 
            // maskpreco
            // 
            this.maskpreco.Enabled = false;
            this.maskpreco.Location = new System.Drawing.Point(92, 40);
            this.maskpreco.MaxLength = 7;
            this.maskpreco.Name = "maskpreco";
            this.maskpreco.Size = new System.Drawing.Size(53, 20);
            this.maskpreco.TabIndex = 43;
            // 
            // txtdescricao
            // 
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Enabled = false;
            this.txtdescricao.Location = new System.Drawing.Point(100, 177);
            this.txtdescricao.MaxLength = 30;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(207, 20);
            this.txtdescricao.TabIndex = 42;
            // 
            // btngravar
            // 
            this.btngravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngravar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btngravar.Image = global::M1.Properties.Resources.salvard;
            this.btngravar.Location = new System.Drawing.Point(7, 302);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(50, 50);
            this.btngravar.TabIndex = 47;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // txttotalcompra
            // 
            this.txttotalcompra.Enabled = false;
            this.txttotalcompra.Location = new System.Drawing.Point(459, 229);
            this.txttotalcompra.Name = "txttotalcompra";
            this.txttotalcompra.Size = new System.Drawing.Size(102, 20);
            this.txttotalcompra.TabIndex = 48;
            // 
            // DESCRIÇÃO
            // 
            this.DESCRIÇÃO.AutoSize = true;
            this.DESCRIÇÃO.Location = new System.Drawing.Point(13, 184);
            this.DESCRIÇÃO.Name = "DESCRIÇÃO";
            this.DESCRIÇÃO.Size = new System.Drawing.Size(69, 13);
            this.DESCRIÇÃO.TabIndex = 49;
            this.DESCRIÇÃO.Text = "DESCRIÇÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "PREÇO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "ESTOQUE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "TOTAL DO PRODUTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "TOTAL DA COMPRA";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(265, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(331, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 92);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskestoque);
            this.groupBox2.Controls.Add(this.maskpreco);
            this.groupBox2.Location = new System.Drawing.Point(8, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 133);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "GRAVAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "FINALIZAR COMPRA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "CANCELAR";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::M1.Properties.Resources.cancelar;
            this.button2.Location = new System.Drawing.Point(530, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 60;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DESCRIÇÃO);
            this.Controls.Add(this.txttotalcompra);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dvgProd);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtparte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "caixa";
            this.ShowIcon = false;
            this.Text = "TELA DO CAIXA";
            this.Load += new System.EventHandler(this.caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtparte;
        private System.Windows.Forms.DataGridView dvgProd;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.MaskedTextBox maskestoque;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.TextBox maskpreco;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.TextBox txttotalcompra;
        private System.Windows.Forms.Label DESCRIÇÃO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}