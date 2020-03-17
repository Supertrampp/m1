using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace M1
{
    public class Usuario
    {
        private int codigo;
        private string login;
        private string senha;
        private string cargo;


        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public string Login
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }

        public string Senha
        {
            get
            {
                return this.senha;
            }
            set
            {
                this.senha = value;
            }
        }

        public string Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        public bool logar()
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao2 objconexao = new Conexao2();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from usuarios where login = '"+this.login+"' and senha = '"+this.senha+"' and cargo = '"+this.cargo+"' limit 1;";
                
               

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.codigo = Convert.ToInt32(dr["codigo"]);

                    if (this.login == dr["login"].ToString() && this.senha == dr["senha"].ToString() && this.cargo == dr["cargo"].ToString())
                    {
                        Registrolog.Log("user:" + this.login + " Login efetuado com sucesso");
                        dados._nomeuser = this.login;
                        dados._cargo_user = this.cargo;


                        return true;
                    }
                    else
                    {
                        Registrolog.Log("user:" + this.login + " falhou login");
                        dados._nomeuser = "xxxxx";
                        return false;
                    }

                }
                else
                {

                    return false;
               }

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

        public void logout()
        {

            Registrolog.Log("user: " + dados._nomeuser + " Saiu do sistema");
        }
        public static string GerarHashMd5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

    }

}
