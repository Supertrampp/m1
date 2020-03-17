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
    public partial class rel_ped : Form
    {
        Conexao acesso = new Conexao();
        int codigo;
        public rel_ped()
        {
            InitializeComponent();
        }

        private void rel_ped_Load(object sender, EventArgs e)
        {

        }
        private void atualizarExibicao()
        {
            dvgProd.DataSource = acesso.GetTodosRegistrosPed();

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
