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
    public partial class rela_prod_prod : Form
    {
        public rela_prod_prod()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            listar();
            txtparte.Clear();
        }

        public void listar()
        {
            Produto objproduto = new Produto();

            dvgProd.AutoGenerateColumns = false;

            var lista = new BindingList<Produto>(objproduto.listar(txtparte.Text));
            dvgProd.DataSource = lista;           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rela_prod_prod_Load(object sender, EventArgs e)
        {

        }
   
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmlistaprodutos_Load(object sender, EventArgs e)
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
    }
}












/*

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
    public partial class rela_prod_prod : Form
    {
        int codigo;
        Conexao2 acesso = new Conexao2();


        public rela_prod_prod()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rela_prod_prod_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                atualizarExibicao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void atualizarExibicao()
        {
            dvgProd.DataSource = acesso.GetTodosRegistros();
        }
    }
}


*/
    





