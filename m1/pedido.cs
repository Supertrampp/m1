using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class Pedido
    {

        private int _codigo;
        private string _produto1;
        private string _produto2;
        private string _produto3;
        private string _produto4;
        private string _produto5;
        private int _qtd1;
        private int _qtd2;
        private int _qtd3;
        private int _qtd4;
        private int _qtd5;
        private Fornecedor _fornecedor;
        private string _endfor;
        private string _telfor;
        private string _nome;
        private string _endemp;
        private string _telemp;

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string produto1
        {
            get { return _produto1; }
            set { _produto1 = value; }
        }
        public string produto2
        {
            get { return _produto2; }
            set { _produto2 = value; }
        }
        public string produto3
        {
            get { return _produto3; }
            set { _produto3 = value; }
        }
        public string produto4
        {
            get { return _produto4; }
            set { _produto4 = value; }
        }
        public string produto5
        {
            get { return _produto5; }
            set { _produto5 = value; }
        }
        public int qtd1
        {
            get { return _qtd1; }
            set { _qtd1 = value; }
        }
        public int qtd2
        {
            get { return _qtd2; }
            set { _qtd2 = value; }
        }
        public int qtd3
        {
            get { return _qtd3; }
            set { _qtd3 = value; }
        }
        public int qtd4
        {
            get { return _qtd4; }
            set { _qtd4 = value; }
        }
        public int qtd5
        {
            get { return _qtd5; }
            set { _qtd5 = value; }
        }
        public string endfor
        {
            get { return _endfor; }
            set { _endfor = value; }
        }
        public string telfor
        {
            get { return _telfor; }
            set { _telfor = value; }
        }
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string endemp
        {
            get { return _endemp; }
            set { _endemp = value; }
        }
        public string telemp
        {
            get { return _telemp; }
            set { _telemp = value; }
        }

        public string fornecedor_descricao
        {
            get {return this.fornecedor.Descricao;}
        }

        public Fornecedor fornecedor
        {
            get{return _fornecedor;}

            set{  _fornecedor = value;}
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

                sql = "INSERT INTO pedido(produto1, qtd1, produto2, qtd2, produto3, qtd3, produto4, qtd4, produto5, qtd5, fornecedor, endfor, telfor, nome, endemp, telemp) VALUES (@produto1, @qtd1, @produto2, @qtd2, @produto3, @qtd3, @produto4, @qtd4, @produto5, @qtd5, @fornecedor, @endfor, @telfor, @nome, @endemp, @telemp);";

                NpgsqlCommand command = new NpgsqlCommand(sql, pgsqlConnection);
                command.Parameters.AddWithValue("@produto1", this._produto1);
                command.Parameters.AddWithValue("@qtd1", this._qtd1);
                command.Parameters.AddWithValue("@produto2", this._produto2);
                command.Parameters.AddWithValue("@qtd2", this._qtd2);
                command.Parameters.AddWithValue("@produto3", this._produto3);
                command.Parameters.AddWithValue("@qtd3", this._qtd3);
                command.Parameters.AddWithValue("@produto4", this._produto4);
                command.Parameters.AddWithValue("@qtd4", this._qtd4);
                command.Parameters.AddWithValue("@produto5", this._produto5);
                command.Parameters.AddWithValue("@qtd5", this._qtd5);
                command.Parameters.AddWithValue("@fornecedor", this._fornecedor.Id);
                command.Parameters.AddWithValue("@endfor", this._endfor);
                command.Parameters.AddWithValue("@telfor", this._telfor);
                command.Parameters.AddWithValue("@nome", this._nome);
                command.Parameters.AddWithValue("@endemp", this._endemp);
                command.Parameters.AddWithValue("@telemp", this._telemp);


                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
        
    }
}
