using System;
using System.Windows.Forms;

namespace APP.Foms
{
    public partial class FrmCaregando : Form
    {
        public FrmCaregando()
        {
            InitializeComponent();
        }

        // Método para fazer o progressbar funcionar

        private void TmrCarregar_Tick(object sender, EventArgs e)
        {
            if(bunifuCircleProgressbar1.Value < 100)
            {
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 2;
            }
            else
            {               
                this.Close();
            }
        }
    }
}
