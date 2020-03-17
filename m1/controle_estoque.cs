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
    public partial class controle_estoque : Form
    {
        Conexao acesso = new Conexao();
        int codigo;
        public controle_estoque()
        {
            InitializeComponent();
        }

        private void controle_estoque_Load(object sender, EventArgs e)
        {

        }

        private void atualizarExibicao()
        {
            dvgProd.DataSource = acesso.GetTodosRegistrosEstoque();

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

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

    }
}
