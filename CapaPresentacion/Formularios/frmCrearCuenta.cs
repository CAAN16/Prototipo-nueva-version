using BunifuAnimatorNS;
using CapaEntidades;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class frmCrearCuenta : Form
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        frmLogin frm = new frmLogin();
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = string.Empty;
                txtNombre.ForeColor = Color.Black;
                gboNombre.Text = "Nombre";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;
                gboNombre.Text = string.Empty;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.Black;
                gboUsuario.Text = "Usuario";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
                gboUsuario.Text = string.Empty;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {

            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = string.Empty;
                txtCorreo.ForeColor = Color.Black;
                gboCorreo.Text = "Correo";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.DimGray;
                gboCorreo.Text = string.Empty;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                if (chkMostrar.Checked == true)
                {
                    txtContraseña.Text = string.Empty;
                    txtContraseña.ForeColor = Color.Black;
                    gboContraseña.Text = "Contraseña";
                    txtContraseña.UseSystemPasswordChar = false;
                }
                else
                {
                    txtContraseña.Text = string.Empty;
                    txtContraseña.ForeColor = Color.Black;
                    gboContraseña.Text = "Contraseña";
                    txtContraseña.UseSystemPasswordChar = true;
                }

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                gboContraseña.Text = string.Empty;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmar_Pass_Enter(object sender, EventArgs e)
        {

            if (txtConfirmar_Pass.Text == "Confirmación")
            {
                if (chkMostrar.Checked == true)
                {
                    txtConfirmar_Pass.Text = string.Empty;
                    txtConfirmar_Pass.ForeColor = Color.Black;
                    gboConfimación.Text = "Confirmación";
                    txtConfirmar_Pass.UseSystemPasswordChar = false;
                }
                else
                {
                    txtConfirmar_Pass.Text = string.Empty;
                    txtConfirmar_Pass.ForeColor = Color.Black;
                    gboConfimación.Text = "Confirmación";
                    txtConfirmar_Pass.UseSystemPasswordChar = true;
                }

            }
        }

        private void txtConfirmar_Pass_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar_Pass.Text == "")
            {
                txtConfirmar_Pass.Text = "Confirmación";
                txtConfirmar_Pass.ForeColor = Color.DimGray;
                gboConfimación.Text = string.Empty;
                txtConfirmar_Pass.UseSystemPasswordChar = false;
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkMostrar.Checked == true || chkMostrar.Checked == false) && (txtConfirmar_Pass.Text == "Confirmación" && txtContraseña.Text == "Contraseña"))
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtConfirmar_Pass.UseSystemPasswordChar = false;
            }
            else if (chkMostrar.Checked == true && (txtContraseña.Text != "" || txtConfirmar_Pass.Text != ""))
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtConfirmar_Pass.UseSystemPasswordChar = false;
            }
            else if (chkMostrar.Checked == false && txtContraseña.Text != "Contraseña" && txtContraseña.Text != "" && (txtConfirmar_Pass.Text == "Confirmación" || txtConfirmar_Pass.Text == ""))
            {
                txtConfirmar_Pass.UseSystemPasswordChar = false;
                txtContraseña.UseSystemPasswordChar = true;
            }
            else if (chkMostrar.Checked == false && txtConfirmar_Pass.Text != "Confirmación" && txtConfirmar_Pass.Text != "" && (txtContraseña.Text == "Contraseña" || txtContraseña.Text == ""))
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtConfirmar_Pass.UseSystemPasswordChar = true;
            }
            else if (chkMostrar.Checked == false && (txtContraseña.Text != "" || txtConfirmar_Pass.Text != ""))
            {
                txtContraseña.UseSystemPasswordChar = true;
                txtConfirmar_Pass.UseSystemPasswordChar = true;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(frm, false, Animation.HorizSlide);
            this.Hide();
        }

        private void btnInicar_Sesion_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(frm, false, Animation.HorizSlide);
            this.Hide();




        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = string.Empty;
                N_Usuarios usuario = new N_Usuarios();
                Usuarios Usuario = new Usuarios
                {
                    id_usuario = Convert.ToInt32(txtidusuario.Text),
                    nombre = txtNombre.Text,
                    usuario = txtUsuario.Text,
                    correo = txtCorreo.Text,
                    pasword = usuario.generarSha1(txtContraseña.Text)
                };

                if (Usuario.id_usuario == 0)
                {
                    if (txtNombre.Text == "Nombre" || txtUsuario.Text == "Usuario" || txtCorreo.Text == "Correo" || txtContraseña.Text == "Contraseña" || txtConfirmar_Pass.Text == "Confirmación")
                    {
                        respuesta = "Por favor completa todos los campos";
                        frmInformation.FormConfirmation(respuesta);
                    }
                    else
                    {
                        if (txtContraseña.Text == txtConfirmar_Pass.Text)
                        {
                            if (usuario.UsuarioExiste(txtUsuario.Text, txtCorreo.Text))
                            {
                                respuesta = "El usuario o correo ya existe";
                                frmInformation.FormConfirmation(respuesta);
                            }
                            else
                            {
                                int idusuariogenerado = usuario.RegistrandoUusario(Usuario);
                                if (idusuariogenerado != 0)
                                {
                                    frmConfirmation.FormConfirmation("El usuario se ha registrado exitosamente");
                                    bunifuTransition1.ShowSync(frm, false, BunifuAnimatorNS.Animation.HorizSlide);
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
