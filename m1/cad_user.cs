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
    public partial class cad_user : Form
    {
        public cad_user()
        {
            InitializeComponent();
        }

        private void cad_user_Load(object sender, EventArgs e)
        {
            Cargo objCargo = new Cargo();
            cmbcargo.DataSource = objCargo.listar();

            cmbcargo.DisplayMember = "descricao";
            cmbcargo.ValueMember = "id";
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "")
            {
                MessageBox.Show("O campo login é obrigatório!");
                return;
            }

            if (txtsenha.Text == "")
            {
                MessageBox.Show("O campo senha é obrigatório!");
                return;
            }

            manter_usuarios objprod = new manter_usuarios();
            objprod.login = txtlogin.Text;
            objprod.senha = txtsenha.Text;
           
            Cargo objdepto = new Cargo();
            objdepto.Id = Convert.ToInt16(cmbcargo.SelectedValue.ToString());
            objprod.cargo = objdepto;

            if (objprod.cadastrar())
            {
                MessageBox.Show("Registro cadastrado com sucesso!");
                txtlogin.Clear();
                txtsenha.Clear();
            }
            else
            {
                MessageBox.Show("Registro não cadastrado");
                txtlogin.Clear();
                txtsenha.Clear();
            }
        }
    }
}
