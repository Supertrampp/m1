
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace M1
{
    class Conexao
    {
        static string serverName = "127.0.0.1";                                          
        static string port = "5432";                                                           
        static string userName = "postgres";                                              
        static string password = "postgres";                                             
        static string databaseName = "crud";                                      
        NpgsqlConnection pgsqlConnection = null;
        string connString = null;
        
        public Conexao()
        {
            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                        serverName, port, userName, password, databaseName);
        }

        //Pega todos os registros
        public DataTable GetTodosRegistros()
            {
                DataTable dt = new DataTable();
                try
                {
                    using (pgsqlConnection = new NpgsqlConnection(connString))
                    {
                        // abre a conexão com o PgSQL e define a instrução SQL
                        pgsqlConnection.Open();
                    string cmdSeleciona = "Select codigo, descricao from produtos order by codigo";
                    //string cmdSeleciona = "Select codigo as CÓDIGO, descricao as DESCRICÃO, preco as PREÇO, cod_barras as BARRAS from produtos";

                        using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                        {
                            Adpt.Fill(dt);
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    pgsqlConnection.Close();
                }

                return dt;
            }

        //Pega um registro pelo codigo
        public DataTable GetRegistroPorId(int codigo)
        {

            DataTable dt = new DataTable();

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from produtos Where descricao = " + codigo;

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return dt;
        }


        //Deleta registros
        public void DeletarRegistro(int codigo)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("Delete From produtos Where codigo = '{0}'", codigo);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        //Deleta registros
        public void DeletarRegistroForn(int codigo)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("Delete From forn Where codigo = '{0}'", codigo);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        //Pega todos os registros
        public DataTable GetTodosRegistrosForn()
        {
            DataTable dt = new DataTable();
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select codigo, descricao from forn order by codigo";
                    //string cmdSeleciona = "Select codigo as CÓDIGO, descricao as DESCRICÃO, preco as PREÇO, cod_barras as BARRAS from produtos";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }

        //Deleta registros
        public void DeletarRegistroUser(int codigo)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //abre a conexao                
                    pgsqlConnection.Open();

                    string cmdDeletar = String.Format("Delete From usuarios Where codigo = '{0}'", codigo);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDeletar, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }

        //Pega todos os registros
        public DataTable GetTodosRegistrosUser()
        {
            DataTable dt = new DataTable();
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select codigo, login from usuarios order by codigo";
                    //string cmdSeleciona = "Select codigo as CÓDIGO, descricao as DESCRICÃO, preco as PREÇO, cod_barras as BARRAS from produtos";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }


        //Pega todos os registros
        public DataTable GetTodosRegistrosPe(int codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from produtos order by codigo";
                    //string cmdSeleciona = "Select codigo as CÓDIGO, descricao as DESCRICÃO, preco as PREÇO, cod_barras as BARRAS from produtos";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        //Pega todos os registros
        public DataTable GetTodosRegistrosPed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from pedido order by codigo";
                    //string cmdSeleciona = "Select codigo as CÓDIGO, descricao as DESCRICÃO, preco as PREÇO, cod_barras as BARRAS from produtos";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }

        //Pega todos os registros
        public DataTable GetTodosRegistrosEstoque()
        {
            DataTable dt = new DataTable();
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select codigo, descricao, estoque from produtos where estoque < 5";
                    //string cmdSeleciona = "Select codigo as CÓDIGO, descricao as DESCRICÃO, preco as PREÇO, cod_barras as BARRAS from produtos";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
    }
}
