using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class manter_usuarios
    {

        private int _codigo;
        private string _login;
        private string _senha;
        private Cargo _cargo;
       
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public string cargo_descricao
        {
            get
           {
                return this.cargo.Descricao;
            }


        }


        public Cargo cargo
        {

            get
            {

                return _cargo;

            }

            set
            {

                _cargo = value;

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
                sql = "UPDATE usuarios set login='" + this.login + "', senha='" + this.senha + "', cargo=" + this.cargo.Id + ", where codigo=" + this.codigo + ";";

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
                sql = "DELETE FROM usuarios WHERE codigo=" + this.codigo + ";";

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

                sql = "INSERT INTO usuarios(login, senha, cargo) VALUES (@login, @senha, @cargo);";

                NpgsqlCommand command = new NpgsqlCommand(sql, pgsqlConnection);
                command.Parameters.AddWithValue("@login", this._login);
                command.Parameters.AddWithValue("@senha", this._senha);
                command.Parameters.AddWithValue("@cargo", this._cargo.Id);
                
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<manter_usuarios> listar(string parte)
        {
            List<manter_usuarios> arr = new List<manter_usuarios>(); //criou um obj da classe List que contem somente objetos da classe Sexo

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from usuarios where login ilike ('" + parte + "%');";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    manter_usuarios objproduto = new manter_usuarios();
                    objproduto.codigo = Convert.ToInt32(dr["codigo"]);
                    objproduto.login = dr["login"].ToString();
                    objproduto.senha = dr["senha"].ToString();
                 
                    Cargo objestado = new Cargo();
                    objestado.Id = Convert.ToInt16(dr["cargo"].ToString());

                    objestado.preencher();

                    objproduto.cargo = objestado;



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
                sql = "select * from usuarios where codigo = '"+this.codigo+"' ;";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                this.login = dr["login"].ToString();
                this.senha = dr["senha"].ToString();
               
                Cargo objcategoria = new Cargo();
                objcategoria.Id = Convert.ToInt16(dr["cargo"].ToString());

                this.cargo = objcategoria;            
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
    }
}
