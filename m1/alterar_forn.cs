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
    public partial class alterar_forn : Form
    {
        public int idforn;
        public alterar_forn()
        {
            InitializeComponent();
        }
        
        private void alterar_forn_Load(object sender, EventArgs e)
        {
            Estado objestado = new Estado();
            cmbestado.DataSource = objestado.listar();
            cmbestado.DisplayMember = "descricao";
            cmbestado.ValueMember = "id";

            Forn objproduto = new Forn();
            objproduto.codigo = idforn;
            objproduto.preencher();

            txtdescricao.Text = objproduto.descricao;
            txtendereco.Text = objproduto.endereco;
            cmbestado.SelectedValue = objproduto.estado.Id;
            txtcidade.Text = objproduto.cidade;
            txttelefone.Text = objproduto.telefone;

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

            Forn objfor = new Forn();

            objfor.codigo = idforn;
            objfor.descricao = txtdescricao.Text;
            objfor.endereco = txtendereco.Text;
            objfor.cidade = txtcidade.Text;
            objfor.telefone = txttelefone.Text;

            Estado objestado = new Estado();
            objestado.Id = Convert.ToInt16(cmbestado.SelectedValue.ToString());
            objfor.estado = objestado;
         
            if (objfor.alterar())
            {
                MessageBox.Show("Registro Alterado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Oops! Algo de errado aconteceu!");
            }
            this.Close();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

    }
}
