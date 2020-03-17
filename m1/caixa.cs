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
    public partial class caixa : Form
    {
        double totalcompra = 0;
        public int idproduto;
        public caixa()
        {
            InitializeComponent();
        }

        private void caixa_Load(object sender, EventArgs e)
        {
            
        }
        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            if (txtparte.Text == string.Empty)
            {
                MessageBox.Show("Digite parte da descrição");
            }
            else
            {
                listar();
                txtparte.Clear();
            }
        }

        public void listar()
        {
            Produto objproduto = new Produto();

            dvgProd.AutoGenerateColumns = false;

            var lista = new BindingList<Produto>(objproduto.listar(txtparte.Text));
            dvgProd.DataSource = lista;
        }

        private void dvgProd_MouseClick(object sender, MouseEventArgs e)
        {
            

            idproduto = Convert.ToInt32(dvgProd.CurrentRow.Cells[0].Value);
            Produto objproduto = new Produto();
            objproduto.codigo = idproduto;
            objproduto.preencher();

            txtdescricao.Text = objproduto.descricao;
            maskestoque.Text = objproduto.estoque.ToString();

            maskpreco.Text = objproduto.preco.ToString();

            idproduto = Convert.ToInt32(dvgProd.CurrentRow.Cells[0].Value);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if(maskestoque.Text == "")
            {
                MessageBox.Show("Não tem produto para venda");
                return;
            }

            int val = int.Parse(maskestoque.Text);

            if (val <= 0)
            {
                MessageBox.Show("Produto sem estoque");
                return;
            }
            if(qtd.Text == "")
            {
                MessageBox.Show("Digite a quantidade");
                return;
            }


            Produto objproduto = new Produto();
            objproduto.codigo = idproduto;
            objproduto.descricao = txtdescricao.Text;
            objproduto.preco = double.Parse(maskpreco.Text);
            int estoque = Convert.ToInt32(maskestoque.Text);
            int qtdcomp = Convert.ToInt32(qtd.Text);

            if(val < qtdcomp)
            {
                MessageBox.Show("Não temos essa quantidade em estoque.");
                qtd.Clear();
                return;
            }



            objproduto.estoque = estoque - qtdcomp;

            double preco = Convert.ToDouble(maskpreco.Text);

            double total = qtdcomp * preco;

            txttotal.Text = Convert.ToString(total);

            totalcompra = total + totalcompra;
                

            txttotalcompra.Text = Convert.ToString(totalcompra);


            if (objproduto.alterar2())
            {
                MessageBox.Show("Produto vendido.");
                txtdescricao.Clear();
                maskestoque.Clear();
                maskpreco.Clear();
                qtd.Clear();
                txttotal.Clear();
                
            }
            else
            {
                MessageBox.Show("Oops! Algo de errado aconteceu!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Total da compra " + totalcompra);
            this.Close();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
