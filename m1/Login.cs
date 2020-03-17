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
    public partial class Login : Form
    {

        


        public Login()
        {
            InitializeComponent();
        }

        //botao para sair
        private void btnsair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em sair");
            Application.Exit();
        }

        //botao para entrar no sistema
        private void btnentrar_Click(object sender, EventArgs e)
        {
            Usuario objusuario = new Usuario(); //Cria um objeto da classe usuario
            objusuario.Login = txtlogin.Text; // Atribui o valor da caixa de texto email ao atributo email da classe usuario
            objusuario.Senha = txtsenha.Text; // atribui o valor da caixa de texto senha ao atributo senha da classe usuario

          

            objusuario.Cargo = cmbestado.SelectedValue.ToString();

            if (objusuario.logar()) //chama o metodo logar da classe usuario
            {
                Principal frm = new Principal();
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Usuário Inválido!"); //mostra mensagem para o usuário com login inválido
            }

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            Cargo objestado = new Cargo();
            cmbestado.DataSource = objestado.listar();
            cmbestado.DisplayMember = "descricao";
            cmbestado.ValueMember = "id";
        }
    }
}
