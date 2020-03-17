using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class Categoria
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
            List<Categoria> arr = new List<Categoria>(); //criou um obj da classe List que contem somente objetos da classe Sexo

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from cmbcategoria order by descricao;";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Categoria objdepto = new Categoria();
                    objdepto.id = Convert.ToInt32(dr["id"]);
                    objdepto.descricao = dr["descricao"].ToString();
                    arr.Add(objdepto);

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


            //conectar com o banco de dados

            //executar o comando sql

            //transladar os dados do banco de dados para a estrutura de objetos

            //fechar a conexao


            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from cmbcategoria where id=" + this.id + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                this.descricao = dr["descricao"].ToString();



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

