﻿namespace M1
{
    partial class alterar_forn2
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
            this.atualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtparte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgProd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // atualizar
            // 
            this.atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atualizar.Image = global::M1.Properties.Resources.atualizar;
            this.atualizar.Location = new System.Drawing.Point(16, 173);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(50, 50);
            this.atualizar.TabIndex = 30;
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "SAIR";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::M1.Properties.Resources.cancelar;
            this.button1.Location = new System.Drawing.Point(15, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbuscar.Location = new System.Drawing.Point(439, 10);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(143, 23);
            this.btnbuscar.TabIndex = 27;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "PESQUISAR";
            // 
            // txtparte
            // 
            this.txtparte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtparte.Location = new System.Drawing.Point(85, 12);
            this.txtparte.Name = "txtparte";
            this.txtparte.Size = new System.Drawing.Size(326, 20);
            this.txtparte.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "VISUALIZAR";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::M1.Properties.Resources.View;
            this.button2.Location = new System.Drawing.Point(15, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dvgProd
            // 
            this.dvgProd.AllowUserToAddRows = false;
            this.dvgProd.AllowUserToDeleteRows = false;
            this.dvgProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvgProd.Location = new System.Drawing.Point(87, 45);
            this.dvgProd.Name = "dvgProd";
            this.dvgProd.RowHeadersVisible = false;
            this.dvgProd.Size = new System.Drawing.Size(495, 316);
            this.dvgProd.TabIndex = 22;
            this.dvgProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvgProd_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codigo";
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descricao";
            this.Column2.HeaderText = "NOME";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "endereco";
            this.Column6.HeaderText = "ENDERECO";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "estado_descricao";
            this.Column3.HeaderText = "ESTADO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cidade";
            this.Column4.HeaderText = "CIDADE";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "telefone";
            this.Column5.HeaderText = "TELEFONE";
            this.Column5.Name = "Column5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "ATUALIZAR";
            // 
            // alterar_forn2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtparte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dvgProd);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 27);
            this.Name = "alterar_forn2";
            this.ShowIcon = false;
            this.Text = "TELA DE ALTERAR FORNECEDORES";
            this.Load += new System.EventHandler(this.alterar_forn2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtparte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dvgProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
    }
}