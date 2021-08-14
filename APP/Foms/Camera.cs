using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Foms
{
    public partial class FrmCamera : Form
    {
        private APP.Capturar.Capturar _camera;

        public FrmCamera()
        {
            InitializeComponent();

            // Considerar a primeira câmera que for encontrada no sistema
            const int VIDEODEVICE = 0;
            // Resolucao de 640x480, 24 bits por pixel. A sua câmera tem que suportar essa resolução, senão, altere para uma resolução suportada.
            const int VIDEOWIDTH = 640;
            const int VIDEOHEIGHT = 480;
            const int VIDEOBITSPERPIXEL = 24;

            _camera = new Capturar.Capturar(VIDEODEVICE, VIDEOWIDTH, VIDEOHEIGHT, VIDEOBITSPERPIXEL, picCamera);
        }

        private void btnCapturarCamera_Click(object sender, EventArgs e)
        {
            
        }
    }
}
