using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using APP.BLL;
using APP.MODEL;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Data;

namespace APP.Foms
{
    public partial class FrmJogador : Form
    {
        public FrmJogador()
        {
            InitializeComponent();
        }

        // Método que salva a imagem no banco de dados


        public void SalvarImagem(InscricaoMODEL inscriçãoMODEL)
        {
            

           
        }


        // Método para converter imagem em byte
        public static byte[] ConvertImageToByte(System.Drawing.Image image)
        {
            if (image == null)
                return null;

            byte[] data;

            using (MemoryStream stream = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(image);
                bmp.Save(stream, ImageFormat.Jpeg);
                bmp.Save(stream, ImageFormat.Png);
                data = stream.ToArray();
            }

            return data;
        }

        // Método para converter byte em imagem
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        // Método Salvar

        public void Salvar(InscricaoMODEL inscricao)
        {
            // Puxa a variavel da classe model e passa o objeto para salvar 

            inscricao.Nome = txtNomeInscricao.Text;
            inscricao.RG = txtRGInscricao.Text;
            inscricao.CPF = txtCPFInscricao.Text;
            inscricao.Nascimento = txtNascimentoInscricao.Text;
            inscricao.Endereco = txtEnderecoInscricao.Text;
            inscricao.Telefone = txtTelefoleInscricao.Text;
            inscricao.Nome_Clube = txtFutsalInscricao.Text;
            inscricao.Categoria = cbxCategoriaFutsalInscricao.Text;
            inscricao.Posicao_Futsal = cbxPosicaoFutsalInscricao.Text;
            inscricao.Posicao_Campo = cbxPosicaoCampoInscricao.Text;
            inscricao.Data_Inscricao = txtDataIncricao.Text;
            inscricao.Convenio = txtConvenioInscricao.Text;
            inscricao.Nome_Pai = txtNomePaiInscricao.Text;
            inscricao.Profissao_Pai = txtProfissaoPaiInscicao.Text;
            inscricao.Nome_Mae = txtNomeMaeInscricao.Text;
            inscricao.Profissao_Mae = txtProfissaoMaeIncricao.Text;
            inscricao.Problema_Saude = txtProbSaudeInscricao.Text;
            inscricao.Tamanho_Uniforme = cbxUnifInscricao.Text;

            foreach (Control c in this.Controls)
            {
                if (c is RadioButton)
                    if ((c as RadioButton).Checked)
                       
                            inscricao.Uniforme_Jogo = btnSimJogoInscricao.Text;
                            inscricao.Uniforme_Jogo = btnNaoJogoInscricao.Text;
                            inscricao.Uniforme_Treino = btnSimTreinoInscricao.Text;
                            inscricao.Uniforme_Treino = btnNaoTreinoInscricao.Text;
            }
            

            InscricaoBLL inscricaoBLL = new InscricaoBLL();

            inscricaoBLL.Salvar(inscricao);

            FrmMensagemSalvar mensagemSalvar = new FrmMensagemSalvar();
            mensagemSalvar.Show();
        }

        // Chama o método salvar para o botão

        private void Button1_Click(object sender, EventArgs e)
        {
            InscricaoMODEL inscriçãoMODEL = new InscricaoMODEL();
            Salvar(inscriçãoMODEL);

        }

        // Variavel para introduzir a barra de rolagem

        private Guna.UI.Lib.ScrollBar.PanelScrollHelper Barra;

        // Método para a barra de rolagem funcionar

        private void FrmJogador_Load(object sender, EventArgs e)
        {
            Barra = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlInscricao, vsbBarraInscricao, true);

            Barra.UpdateScrollBar();
        }

        // Máscara CPF: 000.000.000-00
    
        private void TxtCPFInscricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCPFInscricao.TextLength)
                {
                    case 0:
                        txtCPFInscricao.Text = "";
                        break;
                    case 3:
                        txtCPFInscricao.Text = txtCPFInscricao.Text + ".";
                        txtCPFInscricao.SelectionStart = 5;
                        break;
                    case 7:
                        txtCPFInscricao.Text = txtCPFInscricao.Text + ".";
                        txtCPFInscricao.SelectionStart = 9;
                        break;
                    case 11:
                        txtCPFInscricao.Text = txtCPFInscricao.Text + "-";
                        txtCPFInscricao.SelectionStart = 13;
                        break;
                }
            }
            txtCPFInscricao.MaxLength = 14;
        }

        // Máscra RG: 00.000.000-0

        private void TxtRGInscricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtRGInscricao.TextLength)
                {
                    case 0:
                        txtRGInscricao.Text = "";
                        break;
                    case 2:
                        txtRGInscricao.Text = txtRGInscricao.Text + ".";
                        txtRGInscricao.SelectionStart = 4;
                        break;
                    case 6:
                        txtRGInscricao.Text = txtRGInscricao.Text + ".";
                        txtRGInscricao.SelectionStart = 8;
                        break;
                    case 10:
                        txtRGInscricao.Text = txtRGInscricao.Text + "-";
                        txtRGInscricao.SelectionStart = 12;
                        break;
                }
            }
            txtRGInscricao.MaxLength = 12;
        }

        // Máscara Telefone: (00) 00000-0000

        private void TxtTelefoleInscricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelefoleInscricao.TextLength)
                {
                    case 0:
                        txtTelefoleInscricao.Text = "(";
                        break;
                    case 3:
                        txtTelefoleInscricao.Text = txtTelefoleInscricao.Text + ")";
                        txtTelefoleInscricao.SelectionStart = 4;
                        break;
                    case 9:
                        txtTelefoleInscricao.Text = txtTelefoleInscricao.Text + "-";
                        txtTelefoleInscricao.SelectionStart = 11;
                        break;
                }
            }
            txtTelefoleInscricao.MaxLength = 14;
        }

        // Máscara Data de Nascimento: 00/00/0000

        private void TxtDataNasInscricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtNascimentoInscricao.TextLength)
                {
                    case 0:
                        txtNascimentoInscricao.Text = "";
                        break;
                    case 2:
                        txtNascimentoInscricao.Text = txtNascimentoInscricao.Text + "/";
                        txtNascimentoInscricao.SelectionStart = 4;
                        break;
                    case 5:
                        txtNascimentoInscricao.Text = txtNascimentoInscricao.Text + "/";
                        txtNascimentoInscricao.SelectionStart = 9;
                        break;
                }
            }
            txtNascimentoInscricao.MaxLength = 10;
        }

        // Máscara Data de Inscrição: 00/00/0000

        private void TxtDataIncricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtDataIncricao.TextLength)
                {
                    case 0:
                        txtDataIncricao.Text = "";
                        break;
                    case 2:
                        txtDataIncricao.Text = txtDataIncricao.Text + "/";
                        txtDataIncricao.SelectionStart = 4;
                        break;
                    case 5:
                        txtDataIncricao.Text = txtDataIncricao.Text + "/";
                        txtDataIncricao.SelectionStart = 9;
                        break;
                }
            }
            txtDataIncricao.MaxLength = 10;
        }

        // Método para Abrir uma imagem

        private void BtnAbrirInscricao_Click(object sender, EventArgs e)
        {
            InscricaoMODEL inscriçãoMODEL = new InscricaoMODEL();

            // Abre a janela de arquivos 

            ofdImagemsIncricao.FileName = ".png";
            ofdImagemsIncricao.Title = "Abrir - Software ACAP";
            ofdImagemsIncricao.Filter = "JPEG|*.JPG|PNG|*.png";
            ofdImagemsIncricao.ShowDialog();
 
        }

        private void OfdImagemsIncricao_FileOk(object sender, CancelEventArgs e)
        {
            // Mostra a imagem no formulário

            pnlFotoInscricao.BackgroundImage = Image.FromFile(ofdImagemsIncricao.FileName);
        }
  
        // Método para limpar os objetos

        public void Limpar()
        {
            txtConvenioInscricao.Clear();
            txtRGInscricao.Clear();
            txtProbSaudeInscricao.Clear();
            txtProfissaoMaeIncricao.Clear();
            txtProfissaoPaiInscicao.Clear();
            txtTelefoleInscricao.Clear();
            txtCPFInscricao.Clear();
            txtDataIncricao.Clear();
            txtEnderecoInscricao.Clear();
            txtFutsalInscricao.Clear();
            txtNascimentoInscricao.Clear();
            txtNomeInscricao.Clear();
            txtNomeMaeInscricao.Clear();
            txtNomePaiInscricao.Clear();
            cbxCategoriaFutsalInscricao.SelectedIndex = -1;
            cbxPosicaoCampoInscricao.SelectedIndex = -1;
            cbxPosicaoFutsalInscricao.SelectedIndex = -1;
            cbxUnifInscricao.SelectedIndex = -1;
            btnSimJogoInscricao.Checked = false;
            btnNaoJogoInscricao.Checked = false;
        }

        // Método para limpar o textbox de pesquisa e listar os inserts do banco

        private void TxtPesqInscricao_Enter(object sender, EventArgs e)
        {
            try
            {
                // Limpa o textbox

                if (txtPesqInscricao.Text == "Insira o Nome Completo")
                {
                    txtPesqInscricao.Text = string.Empty;
                }

                // Inicia a conexão com o banco

                MySqlConnection conecta = new MySqlConnection("DATABASE=acap; SERVER=localhost; UID=root; PWD=Progsid4o05@");
                conecta.Open();

                // Cria um comando para o banco executar e chama o objeto auto completar no textbox

                MySqlCommand comando = new MySqlCommand("SELECT Nome FROM inscricao", conecta);
                MySqlDataReader dr = comando.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    collection.Add(dr.GetString(0));
                }
                txtPesqInscricao.AutoCompleteCustomSource = collection;
                conecta.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para carregar as informações na tela

        private void BtnPesInscricao_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicia uma tela de splash para carregar os dados

                FrmCaregando caregando = new FrmCaregando();
                caregando.Show();

                // Inicia uma conexão com o banco

                MySqlConnection conecta = new MySqlConnection("DATABASE=acap; SERVER=localhost; UID=root; PWD=Progsid4o05@");
                conecta.Open();

                // Cria um comando para que o banco execute

                MySqlCommand comando = new MySqlCommand("SELECT * FROM inscricao WHERE Nome = ?", conecta);
                comando.Parameters.Add("@Nome", MySqlDbType.Text).Value = txtPesqInscricao.Text;

                comando.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = comando.ExecuteReader();
                dr.Read();

                // Traz os dados dos textbox e dos combobox para o formulário

                txtNomeInscricao.Text = dr.GetString(1);
                txtRGInscricao.Text = dr.GetString(2);
                txtCPFInscricao.Text = dr.GetString(3);
                txtNascimentoInscricao.Text = dr.GetString(4);
                txtEnderecoInscricao.Text = dr.GetString(5);
                txtTelefoleInscricao.Text = dr.GetString(6);
                txtFutsalInscricao.Text = dr.GetString(7);
                cbxCategoriaFutsalInscricao.Text = dr.GetString(8);
                cbxPosicaoFutsalInscricao.Text = dr.GetString(9);
                cbxPosicaoCampoInscricao.Text = dr.GetString(10);
                txtConvenioInscricao.Text = dr.GetString(11);
                txtDataIncricao.Text = dr.GetString(12);
                txtNomePaiInscricao.Text = dr.GetString(13);
                txtNomeMaeInscricao.Text = dr.GetString(14);
                txtProfissaoPaiInscicao.Text = dr.GetString(15);
                txtProfissaoMaeIncricao.Text = dr.GetString(16);
                txtProbSaudeInscricao.Text = dr.GetString(17);
                cbxUnifInscricao.Text = dr.GetString(18);

                // Trazendo os radiobuttons para o formulário

                // Radio button uniforme jogo

                if (!dr.IsDBNull(dr.GetOrdinal("Uniforme_Jogo")))
                {
                    btnSimJogoInscricao.Text = dr.GetString("Uniforme_Jogo");
                    btnNaoJogoInscricao.Text = dr.GetString("Uniforme_Jogo");
                    btnSimJogoInscricao.Text = "Sim";
                    btnNaoJogoInscricao.Text = "Não";

                    if (btnSimJogoInscricao.Text == dr.GetString(19))
                    {
                        btnSimJogoInscricao.Checked = true;
  
                    }
                     if (btnNaoJogoInscricao.Text == dr.GetString(19))
                    {
                        btnNaoJogoInscricao.Checked = true;

                    }

                }

                // Radio button uniforme treino

                if (!dr.IsDBNull(dr.GetOrdinal("Uniforme_Treino")))
                {
                    btnSimTreinoInscricao.Text = dr.GetString("Uniforme_Treino");
                    btnNaoTreinoInscricao.Text = dr.GetString("Uniforme_Treino");
                    btnSimTreinoInscricao.Text = "Sim";
                    btnNaoTreinoInscricao.Text = "Não";

                    if (btnSimTreinoInscricao.Text == dr.GetString(20))
                    {
                        btnSimTreinoInscricao.Checked = true;

                    }
                     if (btnNaoTreinoInscricao.Text == dr.GetString(20))
                    {
                        btnNaoTreinoInscricao.Checked = true;
                        
                    }                
                }

                // Radio button uniforme passeio

                if (!dr.IsDBNull(dr.GetOrdinal("Uniforme_Passeio")))
                {
                    btnSimPasseioInscricao.Text = dr.GetString("Uniforme_Passeio");
                    btnNaoPasseioInscricao.Text = dr.GetString("Uniforme_Passeio");
                    btnSimPasseioInscricao.Text = "Sim";
                    btnNaoPasseioInscricao.Text = "Não";

                    if (btnSimPasseioInscricao.Text == dr.GetString(21))
                    {
                        btnSimPasseioInscricao.Checked = true;
                        
                    }
                    if (btnNaoPasseioInscricao.Text == dr.GetString(21))
                    {
                        btnNaoPasseioInscricao.Checked = true;
                        
                    }
                }

                // Radio button uniforme pago

                if (!dr.IsDBNull(dr.GetOrdinal("Uniforme_Pago")))
                {
                    btnSimPagoInscricao.Text = dr.GetString("Uniforme_Pago");
                    btnNaoPagoInscricao.Text = dr.GetString("Uniforme_Pago");
                    btnSimPagoInscricao.Text = "Sim";
                    btnNaoPagoInscricao.Text = "Não";

                    if (btnSimPagoInscricao.Text == dr.GetString(22))
                    {
                        btnSimPagoInscricao.Checked = true;
 
                    }
                    if (btnNaoPagoInscricao.Text == dr.GetString(22))
                    {
                        btnNaoPagoInscricao.Checked = true;
                       
                    }
                }
                InscricaoMODEL inscriçãoMODEL = new InscricaoMODEL();

                

                // Fecha a conexão com banco

                conecta.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    // Limpa os textbox ao clicar

    private void TxtNomeInscricao_Enter(object sender, EventArgs e)
        {
            if (txtNomeInscricao.Text == "Insira o Nome Completo")                
            {
                txtNomeInscricao.Text = string.Empty;
            }
        }

        private void TxtRGInscricao_Enter(object sender, EventArgs e)
        {
            if (txtRGInscricao.Text == "RG") 
            {
                txtRGInscricao.Text = string.Empty;
            }
        }

        private void TxtCPFInscricao_Enter(object sender, EventArgs e)
        {
            if (txtCPFInscricao.Text == "CPF")
            {
                txtCPFInscricao.Text = string.Empty;
            }
        }

        private void TxtNascimentoInscricao_Enter(object sender, EventArgs e)
        {
            if (txtNascimentoInscricao.Text == "Nascimento")
            {
                txtNascimentoInscricao.Text = string.Empty;
            }
        }

        private void TxtEnderecoInscricao_Enter(object sender, EventArgs e)
        {
            if (txtEnderecoInscricao.Text == "Insira o Endereço")
            {
                txtEnderecoInscricao.Text = string.Empty;
            }
        }

        private void TxtTelefoleInscricao_Enter(object sender, EventArgs e)
        {
            if (txtTelefoleInscricao.Text == "Telefone")
            {
                txtTelefoleInscricao.Text = string.Empty;
            }
        }

        private void TxtFutsalInscricao_Enter(object sender, EventArgs e)
        {
            if (txtFutsalInscricao.Text == "Insira o Nome do Clube")
            {
                txtFutsalInscricao.Text = string.Empty;
            }
        }

        private void TxtDataIncricao_Enter(object sender, EventArgs e)
        {
            if (txtDataIncricao.Text == "Data")
            {
                txtDataIncricao.Text = string.Empty;
            }
        }

        private void TxtConvenioInscricao_Enter(object sender, EventArgs e)
        {
            if (txtConvenioInscricao.Text == "Insira o Convênio")
            {
                txtConvenioInscricao.Text = string.Empty;
            }
        }

        private void TxtNomePaiInscricao_Enter(object sender, EventArgs e)
        {
            if (txtNomePaiInscricao.Text == "Insira o Nome Completo do Pai")
            {
                txtNomePaiInscricao.Text = string.Empty;
            }
        }

        private void TxtProfissaoPaiInscicao_Enter(object sender, EventArgs e)
        {
            if (txtProfissaoPaiInscicao.Text == "Insira a Profissão do Pai")
            {
                txtProfissaoPaiInscicao.Text = string.Empty;
            }
        }

        private void TxtNomeMaeInscricao_Enter(object sender, EventArgs e)
        {
            if (txtNomeMaeInscricao.Text == "Insira o Nome Completo da Mãe")
            {
                txtNomeMaeInscricao.Text = string.Empty;
            }
        }

        private void TxtProfissaoMaeIncricao_Enter(object sender, EventArgs e)
        {
            if (txtProfissaoMaeIncricao.Text == "Insira a Profissão da Mãe")
            {
                txtProfissaoMaeIncricao.Text = string.Empty;
            }
        }

        private void TxtProbSaudeInscricao_Enter(object sender, EventArgs e)
        {
            if (txtProbSaudeInscricao.Text == "Insira a Respota")
            {
                txtProbSaudeInscricao.Text = string.Empty;
            }
        }

        // Abre o Form que tem a camera

        private void BtnCameraInscricao_Click(object sender, EventArgs e)
        {
            FrmCamera camera = new FrmCamera();
            camera.Show();
        }

        private void BtnLimparInscricao_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}