using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmInformation : Form
    {
        public frmInformation(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        public static void FormConfirmation(string mensaje)
        {
            frmInformation frm = new frmInformation(mensaje);
            frm.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
