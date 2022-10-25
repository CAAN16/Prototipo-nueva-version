using CapaPresentacion.Formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmFormularios : Form
    {
        public frmFormularios()
        {
            InitializeComponent();
        }

        private Form FormActivo = null;
        private void AbrirFormHijo(Form FormHijo)
        {
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
            FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(FormHijo);
            panelContenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            btnFormulario.BorderSize = 1;
            btnFormulario.TextColor = Color.FromArgb(26, 152, 34);

            btnResultados.BorderSize = 0;
            btnResultados.TextColor = Color.FromArgb(0, 0, 0);
            AbrirFormHijo(new frmCrearForm());
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            btnFormulario.BorderSize = 0;
            btnFormulario.TextColor = Color.FromArgb(0, 0, 0);

            btnResultados.BorderSize = 1;
            btnResultados.TextColor = Color.FromArgb(26, 152, 34);
            AbrirFormHijo(new frmResultados());
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal frm = new frmprincipal();
            frm.Show();
        }
    }
}
