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
    public partial class alterar_forn2 : Form
    {
        public alterar_forn2()
        {
            InitializeComponent();
        }

        private void alterar_forn2_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            listar();
            txtparte.Clear();
           
        }

        public void listar()
        {
            Forn objfor = new Forn();

            dvgProd.AutoGenerateColumns = false;

            var lista = new BindingList<Forn>(objfor.listar(txtparte.Text));
            dvgProd.DataSource = lista;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dvgProd_MouseClick(object sender, MouseEventArgs e)
        {
            alterar_forn frm = new alterar_forn();

            frm.idforn = Convert.ToInt32(dvgProd.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
        }
    }
}
