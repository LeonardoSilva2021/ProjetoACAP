using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP.MODEL;
using APP.Conexão;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;

namespace APP.DAO
{
    public class InscricaoDAO : Conexao
    {
        MySqlCommand comando = null;

        // Método para salvar os dados das Inscrições
        public void Salvar(InscricaoMODEL inscrição)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO inscricao(Nome, RG, CPF, Nascimento, Endereco, Telefone, Nome_Clube, Categoria, Posicao_Futsal, Posicao_Campo, Convenio, Data_Inscricao, Nome_Pai, Nome_Mae, Profissao_Pai, Profissao_Mae, Problema_Saude, Tamanho_Uniforme, Uniforme_Jogo, Uniforme_Treino, Uniforme_Passeio, Uniforme_Pago) VALUES (@Nome, @RG, @CPF, @Nascimento, @Endereco, @Telefone, @Nome_Clube, @Categoria, @Posicao_Futsal, @Posicao_Campo, @Convenio, @Data_Inscricao, @Nome_Pai, @Nome_Mae, @Profissao_Pai, @Profissao_Mae, @Problema_Saude, @Tamanho_Uniforme, @Uniforme_Jogo, @Uniforme_Treino, @Uniforme_Passeio, @Uniforme_Pago)", conecta);

                comando.Parameters.AddWithValue("@Nome", inscrição.Nome);
                comando.Parameters.AddWithValue("@RG", inscrição.RG);
                comando.Parameters.AddWithValue("@CPF", inscrição.CPF);
                comando.Parameters.AddWithValue("@Nascimento", inscrição.Nascimento);
                comando.Parameters.AddWithValue("@Endereco", inscrição.Endereco);
                comando.Parameters.AddWithValue("@Telefone", inscrição.Telefone);
                comando.Parameters.AddWithValue("@Nome_Clube", inscrição.Nome_Clube);
                comando.Parameters.AddWithValue("@Categoria", inscrição.Categoria);
                comando.Parameters.AddWithValue("@Posicao_Futsal", inscrição.Posicao_Futsal);
                comando.Parameters.AddWithValue("@Posicao_Campo", inscrição.Posicao_Campo);
                comando.Parameters.AddWithValue("@Convenio", inscrição.Convenio);
                comando.Parameters.AddWithValue("@Data_Inscricao", inscrição.Data_Inscricao);
                comando.Parameters.AddWithValue("@Nome_Pai", inscrição.Nome_Pai);
                comando.Parameters.AddWithValue("@Nome_Mae", inscrição.Nome_Mae);
                comando.Parameters.AddWithValue("@Profissao_Pai", inscrição.Profissao_Pai);
                comando.Parameters.AddWithValue("@Profissao_Mae", inscrição.Profissao_Mae);
                comando.Parameters.AddWithValue("@Problema_Saude", inscrição.Problema_Saude);
                comando.Parameters.AddWithValue("@Tamanho_Uniforme", inscrição.Tamanho_Uniforme);
                comando.Parameters.AddWithValue("@Uniforme_Jogo", inscrição.Uniforme_Jogo);
                comando.Parameters.AddWithValue("@Uniforme_Treino", inscrição.Uniforme_Treino);
                comando.Parameters.AddWithValue("@Uniforme_Passeio", inscrição.Uniforme_Passeio);
                comando.Parameters.AddWithValue("@Uniforme_Pago", inscrição.Uniforme_Pago);            

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        } 
    }
}
