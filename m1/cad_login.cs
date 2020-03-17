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
    public partial class cad_login : Form
    {
        
        public cad_login()
        {
            InitializeComponent();
        }

        private void cad_login_Load(object sender, EventArgs e)
        {

        }


       

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
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


        private void dvgProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto ob = new Produto();
            ob.codigo = Convert.ToInt32(maskcodigo);

            
        }
    }
}
