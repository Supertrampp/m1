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
    public partial class del_prod : Form
    {
        
        Conexao acesso = new Conexao();
        int codigo;

        public del_prod()
        { InitializeComponent(); }

        private void del_prod_Load(object sender, EventArgs e)
        { }

        private void atualizarExibicao()
        {
            dvgProd.DataSource = acesso.GetTodosRegistros();
            
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == string.Empty)
            {
                MessageBox.Show("Digite um código para deletar");
                return;
            }
            
          
                  
            try
            {
                acesso.DeletarRegistro(int.Parse(txtnome.Text));
                atualizarExibicao();
                txtnome.Clear();
                Mensagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este código não existe");
                txtnome.Clear();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Mensagem()
        {
            MessageBox.Show("Operação realizada com sucesso !");
            txtnome.Clear();
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
    }
}

