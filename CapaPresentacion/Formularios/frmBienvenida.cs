using CapaEntidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            bunifuCircleProgressbar1.Value += 1;
            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Sesion.usuario;
            this.Opacity = 0.0;
            bunifuCircleProgressbar1.Value = 0;
            timer1.Start();
        }
    }
}
