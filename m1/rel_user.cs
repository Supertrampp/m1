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
    public partial class rel_user : Form
    {
        public rel_user()
        {
            InitializeComponent();
        }

        private void rel_user_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            listar();
            txtparte.Clear();
        }

        public void listar()
        {
            manter_usuarios objproduto = new manter_usuarios();

            dvgProd.AutoGenerateColumns = false;

            var lista = new BindingList<manter_usuarios>(objproduto.listar(txtparte.Text));
            dvgProd.DataSource = lista;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            if(txtparte.Text == string.Empty)
            {
                MessageBox.Show("Digite parte da descrição");
            }
            else { 
            listar();
            txtparte.Clear();
        }
        }
    }
}
