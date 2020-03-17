using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M1
{
    public partial class caixa2 : Form
    {
        public int idproduto;
        public caixa2()
        {
            InitializeComponent();
        }

        private void caixa2_Load(object sender, EventArgs e)
        {
            Produto objproduto = new Produto();
            objproduto.codigo = idproduto;
            objproduto.preencher();

            txtdescricao.Text = objproduto.descricao;
            maskestoque.Text = objproduto.estoque.ToString();

            maskpreco.Text = objproduto.preco.ToString();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            Produto objproduto = new Produto();
           

            objproduto.codigo = idproduto;
            objproduto.descricao = txtdescricao.Text;
            objproduto.preco = double.Parse(maskpreco.Text);
            int estoque = Convert.ToInt32(maskestoque.Text);
            int qtdcomp = Convert.ToInt32(qtd.Text);
            objproduto.estoque = estoque - qtdcomp;

            double preco = Convert.ToDouble(maskpreco.Text);

            double total = qtdcomp * preco;

            txttotal.Text = Convert.ToString(total);
            

            if (objproduto.alterar2())
            {
                MessageBox.Show("Registro Alterado com Sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Oops! Algo de errado aconteceu!");
                return;
            }
        }


    }
    }
