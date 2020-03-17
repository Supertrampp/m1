using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M1
{
    public partial class cad_prod : Form
    {
        public cad_prod()
        {
            InitializeComponent();
        }

        double preco;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbunidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void higiene_Load(object sender, EventArgs e)
        {
            
        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            
            Categoria objCategoria = new Categoria();
            cmbCategoria.DataSource = objCategoria.listar();

            cmbCategoria.DisplayMember = "descricao";
            cmbCategoria.ValueMember = "id";

            Fornecedor objForneceddor = new Fornecedor();
            cmbFornecedor.DataSource = objForneceddor.listar();

            cmbFornecedor.DisplayMember = "descricao";
            cmbFornecedor.ValueMember = "id";


            Unidade objunidade = new Unidade();
            cmbUn.DataSource = objunidade.listar();

            cmbUn.DisplayMember = "descricao";
            cmbUn.ValueMember = "id";         
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {         
            if (txtdescricao.Text == "")
            {
                MessageBox.Show("O campo descrição é obrigatório!");
                return;
            }

            if (maskestoque.Text == "")
            {
                MessageBox.Show("O campo estoque é obrigatório!");
                return;
            }

            if (maskbarras.Text == "")
            {
                MessageBox.Show("O campo código de barras é obrigatório!");
                return;
            }
    
            Produto objprod = new Produto();
            objprod.descricao = txtdescricao.Text;
            objprod.cod_barras = int.Parse(maskbarras.Text);
            string preco = maskpreco.Text.ToString().Replace('.',' ').Trim();
           
            Regex regex = new Regex(@"^[0-9]+(\,[0-9]{1,2})?$");
            Match match = regex.Match(preco);
            if (!match.Success)
            {
                MessageBox.Show("O campo preço não esta preenchido corretamente.");
                return;
            } else
            {
                objprod.preco = double.Parse(preco);                
            }

            objprod.estoque = int.Parse(maskestoque.Text);

            Categoria objdepto = new Categoria();
            objdepto.Id = Convert.ToInt16(cmbCategoria.SelectedValue.ToString());
            objprod.categoria = objdepto;

            Fornecedor objfor = new Fornecedor();
            objfor.Id = Convert.ToInt16(cmbFornecedor.SelectedValue.ToString());
            objprod.fornecedor = objfor;

            Unidade objun = new Unidade();
            objun.Id = Convert.ToInt16(cmbUn.SelectedValue.ToString());
            objprod.unidade = objun;

            if (objprod.cadastrar())
            {
                MessageBox.Show("Registro cadastrado com sucesso!");
                txtdescricao.Clear();
                maskbarras.Clear();
                maskpreco.Clear();
                maskestoque.Clear();

            } else
            {
                MessageBox.Show("Registro não cadastrado");
                txtdescricao.Clear();
                maskbarras.Clear();
                maskpreco.Clear();
                maskestoque.Clear();
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
    public partial class cad_prod : Form
    {
        public cad_prod()
        {
            InitializeComponent();
        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // classe para comboBox unidade
        class Unidade
        {
            private int id;

            public int Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                }
            }

            private string descricao;

            public string Descricao
            {
                get
                {
                    return this.descricao;
                }
                set
                {
                    this.descricao = value;
                }
            }

            public List<Unidade> listar()
            {
                List<Unidade> arr = new List<Unidade>();

                Unidade obj1 = new Unidade();
                obj1.id = 1;
                obj1.descricao = "PC";
                arr.Add(obj1);

                Unidade obj2 = new Unidade();
                obj2.id = 2;
                obj2.descricao = "KG";
                arr.Add(obj2);

                Unidade obj3 = new Unidade();
                obj3.id = 3;
                obj3.descricao = "UN";
                arr.Add(obj3);

                return arr;
            }
        }

        // classe para comboBox fornecedor
        class Fornecedor
        {
            private int id;

            public int Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                }
            }

            private string descricao;

            public string Descricao
            {
                get
                {
                    return this.descricao;
                }
                set
                {
                    this.descricao = value;
                }
            }

            public List<Fornecedor> listar()
            {
                List<Fornecedor> arr = new List<Fornecedor>();

                Fornecedor obj1 = new Fornecedor();
                obj1.id = 1;
                obj1.descricao = "Fornecedor 01";
                arr.Add(obj1);

                Fornecedor obj2 = new Fornecedor();
                obj2.id = 2;
                obj2.descricao = "Fornecedor 02";
                arr.Add(obj2);

                Fornecedor obj3 = new Fornecedor();
                obj3.id = 3;
                obj3.descricao = "Fornecedor 03";
                arr.Add(obj3);

                Fornecedor obj4 = new Fornecedor();
                obj4.id = 4;
                obj4.descricao = "Fornecedor 04";
                arr.Add(obj4);

                Fornecedor obj5 = new Fornecedor();
                obj5.id = 5;
                obj5.descricao = "Fornecedor 05";
                arr.Add(obj5);

                return arr;
            }
        }


        class Categoria
        {
            private int id;

            public int Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                }
            }

            private string descricao;

            public string Descricao
            {
                get
                {
                    return this.descricao;
                }
                set
                {
                    this.descricao = value;
                }
            }

            public List<Categoria> listar()
            {
                List<Categoria> arr = new List<Categoria>();

                Categoria obj1 = new Categoria();
                obj1.id = 1;
                obj1.descricao = "Higiêne";
                arr.Add(obj1);

                Categoria obj2 = new Categoria();
                obj2.id = 2;
                obj2.descricao = "Limpeza";
                arr.Add(obj2);

                Categoria obj3 = new Categoria();
                obj3.id = 3;
                obj3.descricao = "Aliementação";
                arr.Add(obj3);

                return arr;
            }
        }




        private void higiene_Load(object sender, EventArgs e)
        {
            Fornecedor objfornecedor = new Fornecedor();

            cmbfornecedor.DataSource = objfornecedor.listar();
            cmbfornecedor.DisplayMember = "descricao";
            cmbfornecedor.ValueMember = "id";

            Unidade objunidade = new Unidade();

            cmbunidade.DataSource = objunidade.listar();
            cmbunidade.DisplayMember = "descricao";
            cmbunidade.ValueMember = "id";

            Categoria objcategoria = new Categoria();

            cmbcat.DataSource = objcategoria.listar();
            cmbcat.DisplayMember = "descricao";
            cmbcat.ValueMember = "id";
        }

        private void cmbunidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

*/