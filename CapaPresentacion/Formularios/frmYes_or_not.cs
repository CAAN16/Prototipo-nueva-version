using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmYes_or_not : Form
    {
        public frmYes_or_not(string mensaje)
        {
            InitializeComponent();
            lblMessage.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
