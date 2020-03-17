namespace M1
{
    partial class caixa2
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
            this.maskpreco = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.qtd = new System.Windows.Forms.TextBox();
            this.maskestoque = new System.Windows.Forms.MaskedTextBox();
            this.btngravar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskpreco
            // 
            this.maskpreco.Location = new System.Drawing.Point(61, 108);
            this.maskpreco.MaxLength = 7;
            this.maskpreco.Name = "maskpreco";
            this.maskpreco.Size = new System.Drawing.Size(100, 20);
            this.maskpreco.TabIndex = 37;
            // 
            // txtdescricao
            // 
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Location = new System.Drawing.Point(61, 71);
            this.txtdescricao.MaxLength = 30;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(230, 20);
            this.txtdescricao.TabIndex = 36;
            // 
            // qtd
            // 
            this.qtd.Location = new System.Drawing.Point(61, 188);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(100, 20);
            this.qtd.TabIndex = 38;
            // 
            // maskestoque
            // 
            this.maskestoque.Location = new System.Drawing.Point(61, 134);
            this.maskestoque.Mask = "000";
            this.maskestoque.Name = "maskestoque";
            this.maskestoque.Size = new System.Drawing.Size(26, 20);
            this.maskestoque.TabIndex = 39;
            this.maskestoque.ValidatingType = typeof(int);
            // 
            // btngravar
            // 
            this.btngravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngravar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btngravar.Image = global::M1.Properties.Resources.salvard;
            this.btngravar.Location = new System.Drawing.Point(61, 267);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(50, 50);
            this.btngravar.TabIndex = 40;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(61, 227);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 41;
            // 
            // caixa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.maskestoque);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.maskpreco);
            this.Controls.Add(this.txtdescricao);
            this.Name = "caixa2";
            this.Text = "caixa2";
            this.Load += new System.EventHandler(this.caixa2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maskpreco;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.MaskedTextBox maskestoque;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.TextBox txttotal;
    }
}