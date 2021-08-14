using System;
using System.Drawing;
using System.Windows.Forms;
using APP.Foms;
using Guna.UI2.WinForms;

namespace APP
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        FrmJogador jogador = new FrmJogador();

        // Função para a foto do design se movimente na tela

        private void MoveImage(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            picSlide.Location = new Point(b.Location.X + 165, b.Location.Y - 31);
            picSlide.SendToBack();
        }

        private void Guna2Button2_CheckedChanged(object sender, EventArgs e)
        {
            MoveImage(sender);
        }

        // Função para mostrar um formulário em um panel

        private void PnlForms_Paint(object sender, PaintEventArgs e)
        {
            jogador.TopLevel = false;
            jogador.AutoScroll = false;
            pnlForms.Controls.Add(jogador);
            jogador.Show();
            jogador.BringToFront();
        }
    }
}
