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
    public partial class cad_forn : Form
    {
        public cad_forn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (txtdescricao.Text == "")
            {
                MessageBox.Show("O campo descrição é obrigatório!");
                return;
            }

            if (txtendereco.Text == "")
            {
                MessageBox.Show("O campo endereço é obrigatório!");
                return;
            }

            Forn objprod = new Forn();
            objprod.descricao = txtdescricao.Text;
            objprod.endereco = txtendereco.Text;
            objprod.cidade = txtcidade.Text;
            objprod.telefone = txttelefone.Text;

            Estado objdepto = new Estado();
            objdepto.Id = Convert.ToInt16(cmbestado.SelectedValue.ToString());

            objprod.estado = objdepto;

            if (objprod.cadastrar())
            {
                MessageBox.Show("Registro cadastrado com sucesso!");
                txtdescricao.Clear();
                txtendereco.Clear();
                txtcidade.Clear();
                txttelefone.Clear();
            }
            else
            {
                MessageBox.Show("Registro não cadastrado");
                txtdescricao.Clear();
                txtendereco.Clear();
                txtcidade.Clear();
                txttelefone.Clear();
            }
        }

        private void fornecedores_Load(object sender, EventArgs e)
        {
            Estado objestado = new Estado();
            cmbestado.DataSource = objestado.listar();
            cmbestado.DisplayMember = "descricao";
            cmbestado.ValueMember = "id";
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
