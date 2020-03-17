using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace M1
{
    public partial class novo_pedido : Form
    {
        public int idproduto;
        public novo_pedido()
        {
            InitializeComponent();
        }

        private void novo_pedido_Load(object sender, EventArgs e)
        {        
            Fornecedor objForneceddor = new Fornecedor();
            cmbFornecedor.DataSource = objForneceddor.listar();

            cmbFornecedor.DisplayMember = "descricao";
            cmbFornecedor.ValueMember = "id";

            txtprod2.Hide();
            qtd2.Hide();
            label6.Hide();
            label2.Hide();

            txtprod3.Hide();
            qtd3.Hide();
            label8.Hide();
            label7.Hide();

            txtprod4.Hide();
            qtd4.Hide();
            label10.Hide();
            label9.Hide();

            txtprod5.Hide();
            qtd5.Hide();
            label11.Hide();
            label12.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txtprod1.Text == string.Empty)
            {
                MessageBox.Show("É necessário ter a descrição do produto");
                return;
            }
            string teste = qtd1.Text;
            Regex r = new Regex("\\d");
            if (r.IsMatch(teste))
            {
                //
            }
            else
            {
                if (qtd1.Text == "")
                {
                    MessageBox.Show("É necessário um valor de quantidade");
                    return;
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                    qtd1.Clear();
                    return;
                }
            }
            txtprod2.Show();
            qtd2.Show();
            label6.Show();
            label2.Show();
            button2.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (txtprod2.Text == string.Empty)
            {
                MessageBox.Show("É necessário ter a descrição do produto");
                return;
            }
            string teste = qtd2.Text;
            Regex r = new Regex("\\d");
            if (r.IsMatch(teste))
            {
                //
            }
            else
            {
                if (qtd2.Text == "")
                {
                    MessageBox.Show("É necessário um valor de quantidade");
                    return;
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                    qtd2.Clear();
                    return;
                }
            }
            txtprod3.Show();
            qtd3.Show();
            label8.Show();
            label7.Show();
            button3.Hide();
            button4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtprod4.Show();
            qtd4.Show();
            label9.Show();
            label10.Show();
            button4.Hide();
            button5.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtprod5.Show();
            qtd5.Show();
            label11.Show();
            label12.Show();
            
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if(txtprod1.Text == string.Empty)
            {
                MessageBox.Show("É necessário ter pelo menos um item no pedido");
                return;
            }
            

            string teste = qtd1.Text;
            Regex r = new Regex("\\d");
            if (r.IsMatch(teste))
            {
                //
            }
            else
            {
                if (qtd1.Text == "")
                {
                    MessageBox.Show("É necessário um valor de quantidade");
                    return;
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                    qtd1.Clear();
                    return;
                }
            }
            string teste2 = qtd2.Text;
            Regex r2 = new Regex("\\d");
            if (r.IsMatch(teste2))
            {
                //
            }
            else
            {              
                if (qtd2.Text == "")
                {
                    qtd2.Text = "000";
                }
                else
                {
                    MessageBox.Show("Valor inválido.");
                    qtd2.Clear();
                    return;
                }             
            }
            string teste3 = qtd3.Text;
            Regex r3 = new Regex("\\d");
            if (r.IsMatch(teste3))
            {
                //
            }
            else
            {
                if (qtd3.Text == "")
                {
                    qtd3.Text = "000";
                }
                else
                {
                    MessageBox.Show("Valor inválido.");
                    qtd3.Clear();
                    return;
                }
            }
            string teste4 = qtd4.Text;
            Regex r4 = new Regex("\\d");
            if (r.IsMatch(teste4))
            {
                //
            }
            else
            {
                if (qtd4.Text == "")
                {
                    qtd4.Text = "000";
                }
                else
                {
                    MessageBox.Show("Valor inválido.");
                     qtd4.Clear();
                    return;
                }
            }
            string teste5 = qtd5.Text;
            Regex r5 = new Regex("\\d");
            if (r.IsMatch(teste5))
            {
                //
            }
            else
            {
                if (qtd5.Text == "")
                {
                    qtd5.Text = "000";
                }
                else
                {
                    MessageBox.Show("Valor inválido.");
                    qtd5.Clear();
                    return;
                }
            }

            if(txtendereco.Text == string.Empty)
            {
                MessageBox.Show("O campo endereço do fornecedor é obrigatório");
                return;
            }
            if (txtnome.Text == string.Empty)
            {
                MessageBox.Show("O campo nome da empresa é obrigatório");
                return;
            }
            if (txtendemp.Text == string.Empty)
            {
                MessageBox.Show("O campo endereço da empresa é obrigatório");
                return;
            }
            if (txtprod2.Text == string.Empty)
            {
                txtprod2.Text = "-";
            }
            if (txtprod3.Text == string.Empty)
            {
                txtprod3.Text = "-";
            }
            if (txtprod4.Text == string.Empty)
            {
                txtprod4.Text = "-";
            }
            if (txtprod5.Text == string.Empty)
            {
                txtprod5.Text = "-";
            }

            Pedido objprod = new Pedido();
            objprod.produto1 = txtprod1.Text;
            objprod.qtd1 = int.Parse(qtd1.Text);
            objprod.produto2 = txtprod2.Text;
            objprod.qtd2 = int.Parse(qtd2.Text);
            objprod.produto3 = txtprod3.Text;
            objprod.qtd3 = int.Parse(qtd3.Text);
            objprod.produto4 = txtprod4.Text;
            objprod.qtd4 = int.Parse(qtd4.Text);
            objprod.produto5 = txtprod5.Text;
            objprod.qtd5 = int.Parse(qtd5.Text);

            objprod.endfor = txtendereco.Text;
            objprod.telfor = txttelefone.Text;
            objprod.nome = txtnome.Text;
            objprod.endemp = txtendemp.Text;
            objprod.telemp = txttelemp.Text;

            Fornecedor objfor = new Fornecedor();
            objfor.Id = Convert.ToInt16(cmbFornecedor.SelectedValue.ToString());
            objprod.fornecedor = objfor;         

            if (objprod.cadastrar())
            {
                MessageBox.Show("Registro cadastrado com sucesso!");
                txtprod1.Clear();
                qtd1.Clear();
                txtprod2.Clear();
                qtd2.Clear();             
                txtprod3.Clear();
                qtd3.Clear();             
                txtprod4.Clear();
                qtd4.Clear();              
                txtprod5.Clear();
                qtd5.Clear();
                txtendereco.Clear();
                txttelefone.Clear();
                txtnome.Clear();
                txtendemp.Clear();
                txttelemp.Clear();

                txtprod2.Hide();
                qtd2.Hide();
                label6.Hide();
                label2.Hide();

                txtprod3.Hide();
                qtd3.Hide();
                label8.Hide();
                label7.Hide();

                txtprod4.Hide();
                qtd4.Hide();
                label10.Hide();
                label9.Hide();

                txtprod5.Hide();
                qtd5.Hide();
                label11.Hide();
                label12.Hide();
            }
            else
            {
                MessageBox.Show("Registro não cadastrado");
               
            }
        }
    }
}
