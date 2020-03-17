using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class Produto
    {

        private int _codigo;
        private string _descricao;
        private int _cod_barras;
        private double _preco;
        private int _estoque;
        private Categoria _categoria;
        private Fornecedor _fornecedor;
        private Unidade _unidade;


        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public int estoque
        {
            get { return _estoque; }
            set { _estoque = value; }
        }

        public double preco
        {

            get
            {
                return _preco;
            }

            set
            {

                _preco = value;

            }

        }

        public int cod_barras
        {

            get
            {
                return _cod_barras;
            }

            set
            {

                _cod_barras = value;

            }

        }

        public string descricao
        {

            get
            {
                return _descricao;
            }

            set
            {

                _descricao = value;
            }

        }

        public string categoria_descricao
        {

            get
            {
                return this.categoria.Descricao;
            }


        }


        public Categoria categoria
        {

            get
            {

                return _categoria;

            }

            set
            {

                _categoria = value;

            }

        }

        public string fornecedor_descricao
        {

            get
            {
                return this.fornecedor.Descricao;
            }


        }

        public Fornecedor fornecedor
        {

            get
            {

                return _fornecedor;

            }

            set
            {

                _fornecedor = value;

            }

        }
        

        public string unidade_descricao
        {

            get
            {
                return this.unidade.Descricao;
            }


        }

        public Unidade unidade
        {

            get
            {

                return _unidade;

            }

            set
            {

                _unidade = value;

            }

        }

        public bool alterar()
        {


            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "UPDATE produtos set descricao='" + this.descricao + "', cod_barras='" + this.cod_barras + "', preco='" + this.preco + "', categoria=" + this.categoria.Id + ", fornecedor=" + this.fornecedor.Id + ", unidade=" + this.unidade.Id + " , estoque='" + this.estoque + "' where codigo=" + this.codigo + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                cmd.ExecuteNonQuery();//executa comando no banco de dados

                return true;


            }
            catch (Exception ex)
            {

                return false;

            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        public bool excluir()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "DELETE FROM produtos WHERE codigo=" + this.codigo + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                cmd.ExecuteNonQuery();//executa comando no banco de dados

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        public bool cadastrar()
        {
            try
            {
                NpgsqlConnection pgsqlConnection = null;

                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";

                sql = "INSERT INTO produtos(descricao, cod_barras, categoria, preco, fornecedor, unidade, estoque) VALUES (@descricao, @cod_barras, @categoria, @preco, @fornecedor, @unidade, @estoque);";

                NpgsqlCommand command = new NpgsqlCommand(sql, pgsqlConnection);
                command.Parameters.AddWithValue("@descricao", this._descricao);
                command.Parameters.AddWithValue("@cod_barras", this._cod_barras);
                command.Parameters.AddWithValue("@categoria", this._categoria.Id);
                command.Parameters.AddWithValue("@preco", this.preco);
                command.Parameters.AddWithValue("@fornecedor", this._fornecedor.Id);
                command.Parameters.AddWithValue("@unidade", this._unidade.Id);
                command.Parameters.AddWithValue("@estoque", this._estoque);

                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Produto> listar(string parte)
        {
            List<Produto> arr = new List<Produto>(); //criou um obj da classe List que contem somente objetos da classe Sexo

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from produtos where descricao ilike ('" + parte + "%');";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Produto objproduto = new Produto();
                    objproduto.codigo = Convert.ToInt32(dr["codigo"]);
                    objproduto.descricao = dr["descricao"].ToString();
                    objproduto.cod_barras = Convert.ToInt32(dr["cod_barras"]);
                    objproduto.preco = Convert.ToDouble(dr["preco"]);
                    objproduto.estoque = Convert.ToInt32(dr["estoque"]);

                    Categoria objcategoria = new Categoria();
                    objcategoria.Id = Convert.ToInt16(dr["categoria"].ToString());

                    objcategoria.preencher();

                    objproduto.categoria = objcategoria;

                    Fornecedor objfor = new Fornecedor();
                    objfor.Id = Convert.ToInt16(dr["fornecedor"].ToString());

                    objfor.preencher();

                    objproduto.fornecedor = objfor;

                    Unidade objun = new Unidade();
                    objun.Id = Convert.ToInt16(dr["unidade"].ToString());

                    objun.preencher();

                    objproduto.unidade = objun;

                    arr.Add(objproduto);
               }
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return arr;
        }

        public void preencher()
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from produtos where codigo=" + this.codigo + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                this.descricao = dr["descricao"].ToString();
                this.cod_barras = Convert.ToInt32(dr["cod_barras"]);
                this.preco = Convert.ToDouble(dr["preco"]);
                this.estoque = Convert.ToInt32(dr["estoque"]);
                

                Categoria objcategoria = new Categoria();
                objcategoria.Id = Convert.ToInt16(dr["categoria"].ToString());

                this.categoria = objcategoria;

                Fornecedor objfor = new Fornecedor();
                objfor.Id = Convert.ToInt16(dr["fornecedor"].ToString());

                this.fornecedor = objfor;

                Unidade objun = new Unidade();
                objun.Id = Convert.ToInt16(dr["unidade"].ToString());

                this.unidade = objun;
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }





        public bool alterar2()
        {


            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "UPDATE produtos set estoque='" + this.estoque + "' where codigo=" + this.codigo + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                cmd.ExecuteNonQuery();//executa comando no banco de dados

                return true;


            }
            catch (Exception ex)
            {

                return false;

            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
    }
}
