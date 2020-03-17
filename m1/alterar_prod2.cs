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
    public partial class alterar_prod2 : Form
    {     
        public alterar_prod2()
        {
            InitializeComponent();
        }

        private void alterar_prod2_Load(object sender, EventArgs e)
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

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
     
        private void dvgProd_MouseClick(object sender, MouseEventArgs e)
        {
            alterar_prod frm = new alterar_prod();

            if(dvgProd.CurrentRow.Cells == null)
            {
                MessageBox.Show("errro");
            }
            else { 

            frm.idproduto = Convert.ToInt32(dvgProd.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            }
        }
    }
}







































/*using System;
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
    public partial class alterar_prod2 : Form
    {
        public alterar_prod2()
        {
            InitializeComponent();
        }

        private void alterar_prod2_Load(object sender, EventArgs e)
        {

        }
    }
}
*/
