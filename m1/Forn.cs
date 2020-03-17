using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class Forn
    {
        private int _codigo;
        private string _descricao;
        private string _endereco;
        private string _cidade;
        private string _telefone;
        private Estado _estado;
        
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
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

        public string endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                _endereco = value;
            }
        }

        public string cidade
        {
            get
            {
                return _cidade;
            }
            set
            {
                _cidade = value;
            }
        }

        public string telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
            }
        }

        public string estado_descricao
        {
           get
            {
                return this.estado.Descricao;
            }
        }

        public Estado estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
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
                sql = "UPDATE forn set descricao='" + this.descricao + "', endereco='" + this.endereco + "', estado='" + this.estado.Id + "', cidade='" + this.cidade + "', telefone='" + this.telefone + "' where codigo=" + this.codigo + ";";

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
                sql = "DELETE FROM forn WHERE codigo=" + this.codigo + ";";

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

                sql = "INSERT INTO forn(descricao, endereco, estado, cidade, telefone) VALUES (@descricao, @endereco, @estado, @cidade, @telefone);";

                NpgsqlCommand command = new NpgsqlCommand(sql, pgsqlConnection);
                command.Parameters.AddWithValue("@descricao", this._descricao);
                command.Parameters.AddWithValue("@endereco", this._endereco);
                command.Parameters.AddWithValue("@estado", this._estado.Id);
                command.Parameters.AddWithValue("@cidade", this._cidade);
                command.Parameters.AddWithValue("@telefone", this._telefone);             

                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Forn> listar(string parte)
        {
            List<Forn> arr = new List<Forn>(); //criou um obj da classe List que contem somente objetos da classe Sexo

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from forn where descricao ilike ('" + parte + "%');";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Forn objforn = new Forn();
                    objforn.codigo = Convert.ToInt32(dr["codigo"]);
                    objforn.descricao = dr["descricao"].ToString();
                    objforn.endereco = dr["endereco"].ToString();
                    objforn.cidade = dr["cidade"].ToString();
                    objforn.telefone = dr["telefone"].ToString();

                    Estado objestado = new Estado();
                    objestado.Id = Convert.ToInt16(dr["estado"].ToString());

                    objestado.preencher();

                    objforn.estado = objestado;
                  
                    arr.Add(objforn);
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
                sql = "select * from forn where codigo=" + this.codigo + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                this.descricao = dr["descricao"].ToString();
                this.endereco = dr["endereco"].ToString();
                this.cidade = dr["cidade"].ToString();
                this.telefone = dr["telefone"].ToString();

                Estado objestado = new Estado();
                objestado.Id = Convert.ToInt16(dr["estado"].ToString());

                this.estado = objestado;
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
