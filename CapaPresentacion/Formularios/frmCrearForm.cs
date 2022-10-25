using Bunifu.Framework.UI;
using CapaPresentacion.Controles_Dinamicos;
using CapaPresentacion.Controles_Dinamicos.Mail;
using CapaPresentacion.Globales;
using Controles_personalizados;
using RJCodeAdvance.RJControls;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{

    public partial class frmCrearForm : Form
    {

        #region Variables
        //--------------------------------VARIABLES GLOBALES---------------------------------------------------------------------------------------------------------------------------------
        private PanelRedondeado panelLateral = new PanelRedondeado();

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //--------------------------------VARIABLES PARA PREGUNTA DE NOMBRE COMPLETO--------------------------------------------------------------------------------------------------------- 
        private PanelRedondeado tempPanelPrincipal_NombreC;
        private BunifuImageButton tempEliminarNombreC;
        private Pregunta_TipoNombre NombreC = new Pregunta_TipoNombre("panelNombreC", "lbl", Obtener_Contadores.Total_NombreC, "Texbox",
            "Nombre completo", "Tex", "Nombre", "Tex2", "Apellidos", "imagen", Properties.Resources.contacts_512px, "label", "Nombre Completo",
            "EliminarNombreC");

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //--------------------------------VARIABLES PARA PREGUNTA DE MAIL-------------------------------------------------------------------------------------------------------------------- 
        private PanelRedondeado tempPanelPrincipal_Mail;
        private BunifuImageButton tempEliminarMail;
        private Preguntas Mail = new Pregunta_TipoMail("panelMail", "lblMail", Obtener_Contadores.Total_Mail, "TexboxMail",
            "Mail", "TexMail", "Respuesta", "imagenMail", Properties.Resources.mail_azul, "labelMail", "Mail", "EliminarMail");
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //--------------------------------VARIABLES PARA PREGUNTA DE TELEFONO---------------------------------------------------------------------------------------------------------------- 
        private PanelRedondeado tempPanelPrincipal_Tel;
        private BunifuImageButton tempEliminarTel;
        private Preguntas Tel = new Preguntas("panelTel", "lblTel", Obtener_Contadores.Total_Tel, "TexboxTel",
        "Telefono", "TexTel", "Respuesta", "imagenTel", Properties.Resources.phone_rosa, "labelTel", "Telefono", "EliminarTel");

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //--------------------------------VARIABLES PARA PREGUNTA DE TEXTO CORTO-------------------------------------------------------------------------------------------------------------
        private PanelRedondeado tempPanelPrincipal_TextC;
        private BunifuImageButton tempEliminarTextC;
        private Preguntas TextC = new Preguntas("panelTextC", "lblTextC", Obtener_Contadores.Total_TextC, "TexboxTextC",
            "Escribe tu pregunta aquí", "TexTextC", "Texto para respuesta corta", "imagenTextC", Properties.Resources.text_azul2, "labelTextC", "Texto Corto", "EliminarTextC");
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //--------------------------------VARIABLES PARA PREGUNTA DE TEXTO LARGO-------------------------------------------------------------------------------------------------------------
        private PanelRedondeado tempPanelPrincipal_TextL;
        private BunifuImageButton tempEliminarTextL;
        private Preguntas TextL = new Preguntas("panelTextL", "lblTextL", Obtener_Contadores.Total_TextL, "TexboxTextL",
            "Escribe tu pregunta aquí", "TexTextL", "Texto para respuesta larga", "imagenTextL", Properties.Resources.textolargo_amarillo, "labelTextL", "Texto Largo", "EliminarTextL");
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //--------------------------------VARIABLES PARA PREGUNTA DE SELECCIÓN INDIVIDUAL----------------------------------------------------------------------------------------------------
        private PanelRedondeado tempPanelPrincipal_SeleI;
        private BunifuImageButton tempEliminarSeleI;
        private RJButton tempButtonSeleI;
        private BunifuImageButton tempEliminarOpcSeleI;
        private Pregunta_TipoSeleccionI SeleI = new Pregunta_TipoSeleccionI();
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //--------------------------------VARIABLES PARA PREGUNTA DE SELECCIÓN MULTIPLE------------------------------------------------------------------------------------------------------
        private PanelRedondeado tempPanelPrincipal_SeleM;
        private BunifuImageButton tempEliminarSeleM;
        private RJButton tempButtonSeleM;
        private Pregunta_TipoSeleccionM SeleM = new Pregunta_TipoSeleccionM("panelSeleccionM",
        "lblSeleccionM", Obtener_Contadores.Total_SeleM, "TexboxSeleccionM", "Escribe tu pregunta aquí",
        "TexboxOpcciónSeleccionM", "Opcción1", "CheckBoxSeleccionM", "EliminarOpccionSeleccionM",
        "buttonSeleccionM", "Agregar campo", "imagenSeleccionM", Properties.Resources.done,
        "labelSeleccionM", "Selección Múltiple", "EliminarSeleccionM");
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion

        public frmCrearForm()
        {
            Colores.NormalColor = Color.FromArgb(26, 152, 34);
            InitializeComponent();
            for (int i = 0; i < 133; i++)
            {
                if ((i == 0 || i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63 || i == 72 || i == 81 || i == 90 || i == 99 || i == 108 || i == 117 || i == 126))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 249;
                    ArreglosGlobales.PosicionSeleM[i] = 249;
                }
                else if ((i == 1 || i == 10 || i == 19 || i == 28 || i == 37 || i == 46 || i == 55 || i == 64 || i == 73 || i == 82 || i == 91 || i == 100 || i == 109 || i == 118 || i == 127))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 84;
                    ArreglosGlobales.PosicionSeleM[i] = 84;
                }
                else if ((i == 2 || i == 11 || i == 20 || i == 29 || i == 38 || i == 47 || i == 56 || i == 65 || i == 74 || i == 83 || i == 92 || i == 101 || i == 110 || i == 119 || i == 128))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 75;
                    ArreglosGlobales.PosicionSeleM[i] = 75;
                }
                else if ((i == 3 || i == 12 || i == 21 || i == 30 || i == 39 || i == 48 || i == 57 || i == 66 || i == 75 || i == 84 || i == 93 || i == 102 || i == 111 || i == 120 || i == 129))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 134;
                    ArreglosGlobales.PosicionSeleM[i] = 134;
                }
                else if ((i == 4 || i == 13 || i == 22 || i == 31 || i == 40 || i == 49 || i == 58 || i == 67 || i == 76 || i == 85 || i == 94 || i == 103 || i == 112 || i == 121 || i == 130))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 201;
                    ArreglosGlobales.PosicionSeleM[i] = 201;
                }
                else if ((i == 5 || i == 14 || i == 23 || i == 32 || i == 41 || i == 50 || i == 59 || i == 68 || i == 77 || i == 86 || i == 95 || i == 104 || i == 113 || i == 122 || i == 131))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 211;
                    ArreglosGlobales.PosicionSeleM[i] = 211;
                }
                else if ((i == 6 || i == 15 || i == 24 || i == 33 || i == 42 || i == 51 || i == 60 || i == 69 || i == 78 || i == 87 || i == 96 || i == 105 || i == 114 || i == 123 || i == 132))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 188;
                    ArreglosGlobales.PosicionSeleM[i] = 188;
                }
                else if ((i == 7 || i == 16 || i == 25 || i == 34 || i == 43 || i == 52 || i == 61 || i == 70 || i == 79 || i == 88 || i == 97 || i == 106 || i == 115 || i == 124 || i == 133))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 199;
                    ArreglosGlobales.PosicionSeleM[i] = 199;
                }
                else if ((i == 8 || i == 17 || i == 26 || i == 35 || i == 44 || i == 53 || i == 62 || i == 71 || i == 80 || i == 89 || i == 98 || i == 107 || i == 116 || i == 125 || i == 134))
                {
                    ArreglosGlobales.PosicionSeleI[i] = 210;
                    ArreglosGlobales.PosicionSeleM[i] = 210;
                }
            }
        }


        private void btnTemas_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Colores.LigthColor = ControlPaint.LightLight(colorDialog1.Color);
                Colores.DarkColor = ControlPaint.Dark(colorDialog1.Color);
                Colores.NormalColor = colorDialog1.Color;
                panelRedondeado2.BackColor = Colores.DarkColor;
                //panelContenedor.BackColor = Colores.LigthColor;
                //panelhijo.BackColor = Colores.LigthColor;
                panelRedondeado1.BorderRadius = 24;
                panelRedondeado1.Borderzise = 0;
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    P.BorderRadius = 24;
                    P.Borderzise = 0;
                    foreach (var a in P.Controls.OfType<RJButton>())
                    {

                        if (a is RJButton)
                        {
                            a.BorderColor = Colores.NormalColor;
                        }
                    }

                    foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                    {

                        if (a is BunifuMaterialTextbox)
                        {
                            a.LineFocusedColor = Colores.NormalColor;
                        }
                    }

                    foreach (var a in P.Controls.OfType<RJRadioButton>())
                    {
                        if (a is RJRadioButton)
                            a.CheckedColor = Colores.NormalColor;
                    }

                    foreach (var a in P.Controls.OfType<RJToggleButton>())
                    {

                        if (a is RJToggleButton)
                            a.OnBackColor = Colores.NormalColor;
                    }

                    foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                    {
                        if (a is BunifuCheckbox && a.Checked == true)
                        {
                            a.CheckedOnColor = Colores.NormalColor;
                        }
                        else
                        {
                            a.ChechedOffColor = Color.FromArgb(132, 135, 140);
                            a.CheckedOnColor = Colores.NormalColor;
                            a.BackColor = Color.FromArgb(132, 135, 140);
                        }

                    }
                }

                txtTituloForm.LineFocusedColor = Colores.NormalColor;
                txtDescripcion.LineFocusedColor = Colores.NormalColor;

            }
        }
        private void txtTituloForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

            }
        }

        private void panelRedondeado1_Click(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = true;
            txtTituloForm.Enabled = true;
            txtTituloForm.Focus();
            panelRedondeado3.Visible = true;
            foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
            {
                if (P is PanelRedondeado && P.Name != "panelRedondeado1")
                {
                    foreach (var a in P.Controls.OfType<PanelRedondeado>())
                    {
                        if (a is PanelRedondeado && a.Name == "panelLateral1")
                            P.Controls.Remove(a);

                    }
                    foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                    {

                        if (a is BunifuMaterialTextbox)
                            a.Enabled = false;
                    }
                    foreach (var a in P.Controls.OfType<RJButton>())
                    {

                        if (a is RJButton)
                        {
                            a.Enabled = false;
                        }
                    }
                    foreach (var a in P.Controls.OfType<BunifuImageButton>())
                    {

                        if (a is BunifuImageButton)
                            a.Enabled = false;
                    }
                    foreach (var a in P.Controls.OfType<RJToggleButton>())
                    {

                        if (a is RJToggleButton)
                            a.Enabled = false;
                    }
                    foreach (var a in P.Controls.OfType<RJRadioButton>())
                    {
                        if (a is RJRadioButton)
                            a.Enabled = false;
                    }
                    foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                    {
                        if (a is BunifuCheckbox)
                            a.Enabled = false;
                    }
                }
                else
                {
                    foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                    {

                        if (a is BunifuMaterialTextbox)
                            a.Enabled = true;
                    }
                }
            }
        }

        private void Espacio()
        {
            Panel espacio = new Panel
            {
                Name = "Espacio" + Obtener_Contadores.Total_Preguntas.ToString(),
                Dock = DockStyle.Top,
                Height = 20
            };
            panelhijo.Controls.Add(espacio);
            espacio.BringToFront();
        }

        #region Pregunta de Nombre Completo
        private void btnNombreCompleto_Click(object sender, EventArgs e)
        {
            NombreC.InicializarCampos();
            tempPanelPrincipal_NombreC = NombreC.AgregarPregunta(panelhijo);
            tempPanelPrincipal_NombreC.Click += PanelNombreC_Click;
            tempEliminarNombreC = NombreC.BotonEliminar();
            tempEliminarNombreC.Click += EliminarNombreC_Click;
            Espacio();

        }

        private void EliminarNombreC_Click(object sender, EventArgs e)
        {
            tempEliminarNombreC = sender as BunifuImageButton;
            NombreC.EliminarPregunta(tempEliminarNombreC, panelhijo);
        }

        private void PanelNombreC_Click(object sender, EventArgs e)
        {
            tempPanelPrincipal_NombreC = sender as PanelRedondeado;
            NombreC.ActivarPregunta(tempPanelPrincipal_NombreC, panelhijo, panelLateral);
            panelRedondeado3.Visible = false;
            txtDescripcion.Enabled = false;
            txtTituloForm.Enabled = false;
        }
        #endregion


        #region Pregunta de Mail
        private void btnMail_Click(object sender, EventArgs e)
        {

            Mail.InicializarCampos();
            tempPanelPrincipal_Mail = Mail.AgregarPregunta(panelhijo);
            tempPanelPrincipal_Mail.Click += PanelMail_Click;
            tempEliminarMail = Mail.BotonEliminar();
            tempEliminarMail.Click += EliminarMail_Click;
            Espacio();
        }

        private void PanelMail_Click(object sender, EventArgs e)
        {
            tempPanelPrincipal_Mail = sender as PanelRedondeado;
            Mail.ActivarPregunta(tempPanelPrincipal_Mail, panelhijo, panelLateral);
            panelRedondeado3.Visible = false;
            txtDescripcion.Enabled = false;
            txtTituloForm.Enabled = false;
        }

        private void EliminarMail_Click(object sender, EventArgs e)
        {
            tempEliminarMail = sender as BunifuImageButton;
            Mail.EliminarPregunta(tempEliminarMail, panelhijo);
        }
        #endregion


        #region Pregunta de Telefono
        private void btnTelefono_Click(object sender, EventArgs e)
        {
            Tel.InicializarCampos();
            tempPanelPrincipal_Tel = Tel.AgregarPregunta(panelhijo);
            tempPanelPrincipal_Tel.Click += PanelTel_Click;
            tempEliminarTel = Tel.BotonEliminar();
            tempEliminarTel.Click += EliminarTel_Click;
            Espacio();
        }

        private void PanelTel_Click(object sender, EventArgs e)
        {
            tempPanelPrincipal_Tel = sender as PanelRedondeado;
            Tel.ActivarPregunta(tempPanelPrincipal_Tel, panelhijo, panelLateral);
            panelRedondeado3.Visible = false;
            txtDescripcion.Enabled = false;
            txtTituloForm.Enabled = false;
        }

        private void EliminarTel_Click(object sender, EventArgs e)
        {
            tempEliminarTel = sender as BunifuImageButton;
            Tel.EliminarPregunta(tempEliminarTel, panelhijo);

        }
        #endregion


        #region Pregunta de Texto Corto
        private void btnTextoCorto_Click(object sender, EventArgs e)
        {
            TextC.InicializarCampos();
            tempPanelPrincipal_TextC = TextC.AgregarPregunta(panelhijo);
            tempPanelPrincipal_TextC.Click += PanelTextC_Click;
            tempEliminarTextC = TextC.BotonEliminar();
            tempEliminarTextC.Click += EliminarTextC_Click;
            Espacio();
        }

        private void PanelTextC_Click(object sender, EventArgs e)
        {
            tempPanelPrincipal_TextC = sender as PanelRedondeado;
            TextC.ActivarPregunta(tempPanelPrincipal_TextC, panelhijo, panelLateral);
            panelRedondeado3.Visible = false;
            txtDescripcion.Enabled = false;
            txtTituloForm.Enabled = false;
        }

        private void EliminarTextC_Click(object sender, EventArgs e)
        {
            tempEliminarTextC = sender as BunifuImageButton;
            TextC.EliminarPregunta(tempEliminarTextC, panelhijo);

        }
        #endregion


        #region Pregunta de Texto Largo
        private void btnTextoLargo_Click(object sender, EventArgs e)
        {
            TextL.InicializarCampos();
            tempPanelPrincipal_TextL = TextL.AgregarPregunta(panelhijo);
            tempPanelPrincipal_TextL.Click += PanelTextL_Click;
            tempEliminarTextL = TextL.BotonEliminar();
            tempEliminarTextL.Click += EliminarTextL_Click;
            Espacio();
        }

        private void PanelTextL_Click(object sender, EventArgs e)
        {
            tempPanelPrincipal_TextL = sender as PanelRedondeado;
            TextL.ActivarPregunta(tempPanelPrincipal_TextL, panelhijo, panelLateral);
            panelRedondeado3.Visible = false;
            txtDescripcion.Enabled = false;
            txtTituloForm.Enabled = false;
        }

        private void EliminarTextL_Click(object sender, EventArgs e)
        {
            tempEliminarTextL = sender as BunifuImageButton;
            TextL.EliminarPregunta(tempEliminarTextL, panelhijo);
        }
        #endregion


        #region Pregunta de Selección Individual
        private void btnSelecciónIndividual_Click(object sender, EventArgs e)
        {
            tempPanelPrincipal_SeleI = SeleI.AgregarPregunta(panelhijo, Colores.NormalColor);
            tempPanelPrincipal_SeleI.Click += PanelSeleccionI1_Click;

            tempButtonSeleI = SeleI.BotonCampo();
            tempButtonSeleI.Click += ButtonSeleccionI1_Click1;

            tempEliminarSeleI = SeleI.BotonEliminar();
            tempEliminarSeleI.Click += EliminarSeleccionI_Click;
            Espacio();
            foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
            {
                if (P is PanelRedondeado)
                {
                    foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                    {
                        a.Enabled = false;
                    }

                    foreach (var a in P.Controls.OfType<RJButton>())
                    {
                        a.Enabled = false;
                        a.BorderColor = Colores.NormalColor;
                    }

                    foreach (var a in P.Controls.OfType<BunifuImageButton>())
                    {
                        a.Enabled = false;
                    }
                }
            }

        }



        private void PanelSeleccionI1_Click(object sender, EventArgs e)
        {
            tempPanelPrincipal_SeleI = sender as PanelRedondeado;
            SeleI.ActivarPregunta(tempPanelPrincipal_SeleI, panelhijo, panelLateral);
            txtDescripcion.Enabled = false;
            txtTituloForm.Enabled = false;
            panelRedondeado3.Visible = false;

        }

        private void EliminarSeleccionI_Click(object sender, EventArgs e)
        {
            tempEliminarSeleI = sender as BunifuImageButton;
            SeleI.EliminarPregunta(tempEliminarSeleI, panelhijo);
        }

        private void ButtonSeleccionI1_Click1(object sender, EventArgs e)
        {
            tempButtonSeleI = sender as RJButton;
            SeleI.AgregarCampo(tempButtonSeleI, tempPanelPrincipal_SeleI, panelLateral, Colores.NormalColor);

        }
        #endregion


        #region Pregunta de Selección Multiple
        private void btnSelecciónMultiple_Click(object sender, EventArgs e)
        {
            SeleM.InicializarCampos();
            tempPanelPrincipal_SeleM = SeleM.AgregarPregunta(panelhijo);
            tempPanelPrincipal_SeleM.Click += PanelSeleccionM_Click;
            tempButtonSeleM = SeleM.BotonCampo();
            tempButtonSeleM.Click += ButtonSeleccionM_Click;
            tempEliminarSeleM = SeleM.BotonEliminar();
            tempEliminarSeleM.Click += EliminarSeleccionM_Click;
            Espacio();
        }

        private void PanelSeleccionM_Click(object sender, EventArgs e)
        {
            tempPanelPrincipal_SeleM = sender as PanelRedondeado;
            SeleM.ActivarPregunta(tempPanelPrincipal_SeleM, panelhijo, panelLateral);
            txtDescripcion.Enabled = false;
            txtTituloForm.Enabled = false;
            panelRedondeado3.Visible = false;


        }

        private void EliminarSeleccionM_Click(object sender, EventArgs e)
        {
            tempEliminarSeleM = sender as BunifuImageButton;
            SeleM.EliminarPregunta(tempEliminarSeleM, panelhijo);
        }

        private void ButtonSeleccionM_Click(object sender, EventArgs e)
        {
            tempButtonSeleM = sender as RJButton;
            SeleM.AgregarCampo(tempButtonSeleM, tempPanelPrincipal_SeleM, panelLateral);
        }
        #endregion

        private void panelRedondeado4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
