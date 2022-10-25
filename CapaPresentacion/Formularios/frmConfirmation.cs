using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        public static void FormConfirmation(string mensaje)
        {
            frmConfirmation frm = new frmConfirmation(mensaje);
            frm.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuccess_Load(object sender, EventArgs e)
        {

        }
    }
}
