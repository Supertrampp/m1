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
    public partial class alterar_prod : Form
    {
        public int idproduto;
        public alterar_prod()
        {
            InitializeComponent();
        }

        private void alterar_prod_Load(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            cmbCat.DataSource = objCategoria.listar();
            cmbCat.DisplayMember = "descricao";
            cmbCat.ValueMember = "id";

            Fornecedor objForneceddor = new Fornecedor();
            cmbFor.DataSource = objForneceddor.listar();
            cmbFor.DisplayMember = "descricao";
            cmbFor.ValueMember = "id";

            Unidade objunidade = new Unidade();
            cmbUn.DataSource = objunidade.listar();
            cmbUn.DisplayMember = "descricao";
            cmbUn.ValueMember = "id";

            Produto objproduto = new Produto();
            objproduto.codigo = idproduto;
            objproduto.preencher();

            txtdescricao.Text = objproduto.descricao;
            maskbarras.Text = objproduto.cod_barras.ToString();
            maskestoque.Text = objproduto.estoque.ToString();
            maskpreco.Text = objproduto.preco.ToString();
            cmbCat.SelectedValue = objproduto.categoria.Id;
            cmbFor.SelectedValue = objproduto.fornecedor.Id;
            cmbUn.SelectedValue = objproduto.unidade.Id;
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (txtdescricao.Text == "")
            {
                MessageBox.Show("O campo descrição é obrigatório!");
                return;
            }
            if (maskestoque.Text == "")
            {
                MessageBox.Show("O campo estoque é obrigatório!");
                return;
            }
            if (maskbarras.Text == "")
            {
                MessageBox.Show("O campo código de barras é obrigatório!");
                return;
            }
               
            Produto objproduto = new Produto();
            if (objproduto.excluir())
            {
                objproduto.codigo = idproduto;
            }


            objproduto.codigo = idproduto;
            objproduto.descricao = txtdescricao.Text;
            objproduto.cod_barras = int.Parse(maskbarras.Text);
            objproduto.estoque = int.Parse(maskestoque.Text);
           

            string preco = maskpreco.Text.ToString().Replace('.', ' ').Trim();

            Regex regex = new Regex(@"^[0-9]+(\,[0-9]{1,2})?$");
            Match match = regex.Match(preco);
            if (!match.Success)
            {
                MessageBox.Show("O campo preço não esta preenchido corretamente.");
                return;
            }
            else
            {
                objproduto.preco = double.Parse(preco);
            }

            


            Categoria objcat = new Categoria();
            objcat.Id = Convert.ToInt16(cmbCat.SelectedValue.ToString());
            objproduto.categoria = objcat;

            Fornecedor objfor = new Fornecedor();
            objfor.Id = Convert.ToInt16(cmbFor.SelectedValue.ToString());
            objproduto.fornecedor = objfor;

            Unidade objun = new Unidade();
            objun.Id = Convert.ToInt16(cmbUn.SelectedValue.ToString());
            objproduto.unidade = objun;

            if (objproduto.cadastrar())
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

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
