using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.MODEL
{
    public class InscricaoMODEL
    {

        // Método para chamar as informações do banco de dados

        public int IdInscricao { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Nome_Clube { get; set; }
        public string Categoria { get; set; }
        public string Posicao_Futsal { get; set; }
        public string Posicao_Campo { get; set; }
        public string Convenio { get; set; }
        public string Data_Inscricao { get; set; }
        public string Nome_Pai { get; set; }
        public string Nome_Mae { get; set; }
        public string Profissao_Pai { get; set; }
        public string Profissao_Mae { get; set; }
        public string Problema_Saude { get; set; }
        public string Tamanho_Uniforme { get; set; }
        public string Uniforme_Jogo { get; set; }
        public string Uniforme_Treino { get; set; }
        public string Uniforme_Passeio { get; set; }
        public string Uniforme_Pago { get; set; }
    }
}
