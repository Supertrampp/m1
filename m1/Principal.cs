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
    public partial class Principal : Form
    {
       
        public Principal()
        {
            InitializeComponent();
        }

        //botao sair
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você saiu do sistema");
            Application.Exit();
        }

        //tela principal
        private void Cadastro_Load(object sender, EventArgs e)
        {
            lbluseratual.Text = dados._nomeuser;
            lblcargo.Text = dados._cargo_user;
        }

        //tela cadastro de produtos
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_prod frm = new cad_prod();
            if (lblcargo.Text == "2")
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso.");
                return;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //tela alterar produtos
        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterar_prod2 frm = new alterar_prod2();
            if (lblcargo.Text == "2")
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso.");
                return;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //tela de deletar produtos
        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            del_prod frm = new del_prod();
            if (lblcargo.Text == "2")
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso.");
                return;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //tela de cadastro de forncedores
        private void porProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_forn frm = new cad_forn();
            if (lblcargo.Text == "2")
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso.");
                return;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //tela de alterar forncedores
        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alterar_forn2 frm = new alterar_forn2();
            if (lblcargo.Text == "2")
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso.");
                return;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //tela de deletar fornecedor
        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            del_forn frm = new del_forn();
            if (lblcargo.Text == "2")
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso.");
                return;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //tela de relatorios de produtos
        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rela_prod_prod frm = new rela_prod_prod();
           
                frm.MdiParent = this;
                frm.Show();         
        }

        //tela de relatorios de forncedores
        private void fornecedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           rela_forn frm = new rela_forn();
            
                frm.MdiParent = this;
                frm.Show();         
        }

        //telas para cadastro de usuarios
        private void cad_user_Click(object sender, EventArgs e)
        {
            cad_user frm = new cad_user();
            if ((lblcargo.Text == "1") || (lblcargo.Text == "2"))
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso");
                frm.Hide();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //tela de listar usuarios
        private void lista_user_Click(object sender, EventArgs e)
        {
            rel_user frm = new rel_user();
            if ((lblcargo.Text == "1") || (lblcargo.Text == "2"))
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso");
                frm.Hide();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //tela de deletar usuarios
        private void deleta_user_Click(object sender, EventArgs e)
        {
            del_user frm = new del_user();
            if ((lblcargo.Text == "1") || (lblcargo.Text == "2"))
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso");
                frm.Hide();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        // telas de novo pedido
        private void novo_pedido_Click(object sender, EventArgs e)
        {
            novo_pedido frm = new novo_pedido();
            if ((lblcargo.Text == "1") || (lblcargo.Text == "2"))
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso");
                frm.Hide();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_ped frm = new rel_ped();
            if ((lblcargo.Text == "1") || (lblcargo.Text == "2"))
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso");
                frm.Hide();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //trocar usuario
        private void tROCARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();

            frm.Show();

            this.Close();
            this.Dispose();
        }

        //tela de caixa
        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixa frm = new caixa();
            if (lblcargo.Text == "2")
            {
                MessageBox.Show("Olá " + dados._nomeuser + " você não tem acesso.");
                return;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controle_estoque frm = new controle_estoque();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
