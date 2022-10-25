using BunifuAnimatorNS;
using CapaEntidades;
using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = string.Empty;
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.isPassword = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DarkGray;
                txtContraseña.isPassword = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                N_Usuarios pass = new N_Usuarios();
                Usuarios usuario = new N_Usuarios().ListandoUsuarios().Where(u => u.usuario == txtUsuario.Text
                 && u.pasword == pass.generarSha1(txtContraseña.Text)).FirstOrDefault();
                if (txtUsuario.Text == "Usuario" || txtContraseña.Text == "Contraseña")
                {
                    frmInformation.FormConfirmation("Por favor completa todos los campos");
                }
                else
                {
                    if (usuario != null)
                    {
                        Sesion.idusuario = usuario.id_usuario;
                        Sesion.nombre = usuario.nombre;
                        Sesion.usuario = usuario.usuario;
                        Sesion.correo = usuario.correo;

                        this.Hide();
                        frmBienvenida bienvenida = new frmBienvenida();
                        bienvenida.ShowDialog();
                        frmprincipal frm = new frmprincipal();
                        bunifuTransition1.ShowSync(frm, false, Animation.Scale);
                    }
                    else
                    {
                        txtUsuario.Text = "Usuario";
                        txtContraseña.Text = "Contraseña";
                        txtContraseña.isPassword = false;
                        txtUsuario.ForeColor = Color.DimGray;
                        txtContraseña.ForeColor = Color.DimGray;
                        frmInformation.FormConfirmation("Usuario o contraseña incorrecta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearCuenta frm = new frmCrearCuenta();
            bunifuTransition1.ShowSync(frm, false, Animation.HorizSlide);
            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
