using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP.DAO;
using APP.Conexão;
using APP.MODEL;
using System.Windows.Forms;

namespace APP.BLL
{
    public class InscricaoBLL : Conexao
    {
        InscricaoDAO inscricao = new InscricaoDAO();

        // Método para salvar Inscrição
        public void Salvar(InscricaoMODEL inscriçãoMODEL)
        {
            try
            {
                inscricao.Salvar(inscriçãoMODEL);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }        
    }
}
