using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace APP.Conexão
{
    public class Conexao
    {
        // String de conexão

        string conexao = "DATABASE=acap; SERVER=localhost; UID=root; PWD=Progsid4o05@";
        protected MySqlConnection conecta = null;

        // Método para conectar-se ao banco
        public void AbrirConexao()
        {
            try
            {
                conecta = new MySqlConnection(conexao);
                conecta.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para fechar a conexão com o banco
        public void FecharConexao()
        {
            try
            {
                conecta = new MySqlConnection(conexao);
                conecta.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
