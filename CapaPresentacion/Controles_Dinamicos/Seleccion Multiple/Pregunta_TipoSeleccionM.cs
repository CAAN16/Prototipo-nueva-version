using Bunifu.Framework.UI;
using CapaPresentacion.Controles_Dinamicos.Seleccion_Multiple;
using CapaPresentacion.Globales;
using Controles_personalizados;
using RJCodeAdvance.RJControls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Controles_Dinamicos
{
    public class Pregunta_TipoSeleccionM : Preguntas
    {
        #region Atributos Primarios
        private PanelRedondeado contenedor;
        private Label contador;
        private BunifuMaterialTextbox pregunta;
        private BunifuMaterialTextbox respuesta;
        private PictureBox imagen;
        private Label tipo;
        private BunifuImageButton eliminar;
        private PanelRedondeado linea1;
        private PanelRedondeado linea2;
        private Label obligatoria;
        private RJToggleButton toggleButton;
        private RJButton agregaropccion;
        private BunifuCheckbox seleccionar;
        private BunifuImageButton eliminar_opccion;

        protected PanelRedondeado Contenedor { get => contenedor; set => contenedor = value; }
        protected Label Contador { get => contador; set => contador = value; }
        protected BunifuMaterialTextbox Pregunta { get => pregunta; set => pregunta = value; }
        protected BunifuMaterialTextbox Respuesta { get => respuesta; set => respuesta = value; }
        protected PictureBox Imagen { get => imagen; set => imagen = value; }
        protected Label Tipo { get => tipo; set => tipo = value; }
        protected BunifuImageButton Eliminar { get => eliminar; set => eliminar = value; }
        protected PanelRedondeado Linea1 { get => linea1; set => linea1 = value; }
        protected PanelRedondeado Linea2 { get => linea2; set => linea2 = value; }
        protected Label Obligatoria { get => obligatoria; set => obligatoria = value; }
        protected RJToggleButton ToggleButton { get => toggleButton; set => toggleButton = value; }
        protected RJButton Agregaropccion { get => agregaropccion; set => agregaropccion = value; }
        protected BunifuCheckbox Seleccionar { get => seleccionar; set => seleccionar = value; }
        protected BunifuImageButton Eliminar_opccion { get => eliminar_opccion; set => eliminar_opccion = value; }

        #endregion

        #region Atributos Secundarios
        private string nombre_contenedor;
        private string nombre_contador;
        private int contador_pregunta;
        private string nombre_pregunta;
        private string text_pregunta;
        private string nombre_respuesta;
        private string text_respuesta;
        private string nombre_imagen;
        private Image image1;
        private string nombre_tipo;
        private string text_tipo;
        private string nombre_eliminar;
        private string nombre_checkbox;
        private string nombre_eliminaropccion;
        private string nombre_agregar;
        private string text_agregar;


        protected string Nombre_contenedor { get => nombre_contenedor; set => nombre_contenedor = value; }
        protected string Nombre_contador { get => nombre_contador; set => nombre_contador = value; }
        protected int Contador_pregunta { get => contador_pregunta; set => contador_pregunta = value; }
        protected string Nombre_pregunta { get => nombre_pregunta; set => nombre_pregunta = value; }
        protected string Text_pregunta { get => text_pregunta; set => text_pregunta = value; }
        protected string Nombre_respuesta { get => nombre_respuesta; set => nombre_respuesta = value; }
        protected string Text_respuesta { get => text_respuesta; set => text_respuesta = value; }
        protected string Nombre_imagen { get => nombre_imagen; set => nombre_imagen = value; }
        protected string Nombre_tipo { get => nombre_tipo; set => nombre_tipo = value; }
        protected string Text_tipo { get => text_tipo; set => text_tipo = value; }
        protected string Nombre_eliminar { get => nombre_eliminar; set => nombre_eliminar = value; }
        protected Image Image1 { get => image1; set => image1 = value; }
        protected string Nombre_checkbox { get => nombre_checkbox; set => nombre_checkbox = value; }
        protected string Nombre_eliminaropccion { get => nombre_eliminaropccion; set => nombre_eliminaropccion = value; }
        protected string Nombre_agregar { get => nombre_agregar; set => nombre_agregar = value; }
        protected string Text_agregar { get => text_agregar; set => text_agregar = value; }

        #endregion
        PanelRedondeado tempPanelPrincipal_SeleM;
        BunifuImageButton tempEliminarSeleM;
        RJButton tempButtonSeleM;
        AccionSecundaria_TipoSeleccionM EliminarOpcSeleM = new AccionSecundaria_TipoSeleccionM();

        public Pregunta_TipoSeleccionM(string nombre_contenedor,
        string nombre_contador, int contador_pregunta, string nombre_pregunta,
        string text_pregunta, string nombre_respuesta, string text_respuesta,
        string nombre_checkbox, string nombre_eliminaropccion, string nombre_agregar,
        string text_agregar, string nombre_imagen, Image image, string nombre_tipo,
        string text_tipo, string nombre_eliminar) : base(nombre_contenedor,
        nombre_contador, contador_pregunta, nombre_pregunta, text_pregunta,
        nombre_respuesta, text_respuesta, nombre_imagen, image, nombre_tipo, 
        text_tipo, nombre_eliminar)
        {
            Nombre_contenedor = nombre_contenedor;
            Nombre_contador = nombre_contador;
            Contador_pregunta = contador_pregunta;
            Nombre_pregunta = nombre_pregunta;
            Text_pregunta = text_pregunta;
            Nombre_checkbox = nombre_checkbox;
            Nombre_eliminaropccion = nombre_eliminaropccion;
            Nombre_agregar = nombre_agregar;
            Text_agregar = text_agregar;
            Nombre_respuesta = nombre_respuesta;
            Text_respuesta = text_respuesta;
            Nombre_imagen = nombre_imagen;
            Image1 = image;
            Nombre_tipo = nombre_tipo;
            Text_tipo = text_tipo;
            Nombre_eliminar = nombre_eliminar;
        }

        public override void InicializarCampos()
        {
            Contenedor = new PanelRedondeado
            {
                Height = 249,
                Name = Nombre_contenedor + Contador_pregunta.ToString(),
                Dock = DockStyle.Top,
                BorderRadius = 24,
                Borderzise = 0
            };
            Contador = new Label
            {
                Name = Nombre_contador + Contador_pregunta.ToString(),
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(14, 24),
                Size = new Size(36, 25),
                Text = Obtener_Contadores.Total_Preguntas.ToString()
            };
            Pregunta = new BunifuMaterialTextbox
            {
                Name = Nombre_pregunta + Contador_pregunta.ToString(),
                LineIdleColor = Color.White,
                LineFocusedColor = Colores.NormalColor,
                LineMouseHoverColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(60, 18),
                Width = 660,
                Height = 43,
                Text = Text_pregunta,
                Enabled = false
            };
            Respuesta = new BunifuMaterialTextbox
            {
                Name = Nombre_respuesta,
                LineIdleColor = Color.White,
                LineFocusedColor = Colores.NormalColor,
                LineMouseHoverColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 12),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(60, 75),
                Width = 620,
                Height = 43,
                Text = Text_respuesta,
                Enabled = false
            };
            Seleccionar = new BunifuCheckbox
            {
                Name = Nombre_checkbox,
                CheckedOnColor = Colores.NormalColor,
                ChechedOffColor = Color.FromArgb(132, 135, 140),
                BackColor = Color.ForestGreen,
                Checked = false,
                Location = new Point(27, 84),
                Enabled = false
            };
            Eliminar_opccion = new BunifuImageButton
            {
                Name = Nombre_eliminaropccion,
                BackColor = Color.White,
                Location = new Point(688, 84),
                Size = new Size(30, 30),
                Image = Properties.Resources.Close_512px,
                SizeMode = PictureBoxSizeMode.Zoom,
                Visible = false,
                Zoom = 10
            };
            Agregaropccion = new RJButton
            {
                Name = Nombre_agregar + Contador_pregunta.ToString(),
                BackColor = Color.White,
                BorderColor = Colores.NormalColor,
                ForeColor = Color.Black,
                Size = new Size(149, 35),
                BorderRadius = 6,
                BorderSize = 2,
                Text = Text_agregar,
                Location = new Point(60, 134),
                Enabled = false
            };
            Imagen = new PictureBox
            {
                Name = Nombre_imagen + Contador_pregunta.ToString(),
                Location = new Point(17, 201),
                Size = new Size(35, 35),
                Image = Image1,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Tipo = new Label
            {
                Name = Nombre_tipo + Contador_pregunta.ToString(),
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                Location = new Point(58, 211),
                Width = 200,
                Text = Text_tipo
            };

            Eliminar = new BunifuImageButton
            {
                Name = Nombre_eliminar + Contador_pregunta.ToString(),
                BackColor = Color.White,
                Image = Properties.Resources.trash_512px,
                Location = new Point(488, 201),
                Size = new Size(35, 35),
                SizeMode = PictureBoxSizeMode.Zoom,
                Zoom = 10,
                Enabled = false
            };

            Linea1 = new PanelRedondeado
            {
                BackColor = Color.LightGray,
                Location = new Point(538, 199),
                Size = new Size(2, 40)
            };
            Linea2 = new PanelRedondeado
            {
                BackColor = Color.LightGray,
                Location = new Point(15, 188),
                Size = new Size(700, 2)
            };
            Obligatoria = new Label
            {
                BackColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                Location = new Point(550, 210),
                Size = new Size(111, 24),
                Text = "Obligatoria"
            };
            ToggleButton = new RJToggleButton
            {
                BackColor = Color.White,
                Location = new Point(666, 210),
                OffBackColor = Color.Gray,
                OffToggleColor = Color.Gainsboro,
                OnBackColor = Colores.NormalColor,
                OnToggleColor = Color.WhiteSmoke,
                MinimumSize = new Size(47, 24),
                Size = new Size(47, 24),
                Enabled = false
            };
            Obtener_Contadores.Total_Preguntas++;
            Contador_pregunta++;
        }

        public override PanelRedondeado AgregarPregunta(Panel panelhijo) 
        {
            panelhijo.Controls.Add(Contenedor);
            Contenedor.BringToFront();
            Contenedor.Controls.Add(Contador);
            Contenedor.Controls.Add(Pregunta);
            Contenedor.Controls.Add(Respuesta);
            Contenedor.Controls.Add(Seleccionar);
            Contenedor.Controls.Add(Eliminar_opccion);
            Contenedor.Controls.Add(Agregaropccion);
            Contenedor.Controls.Add(Imagen);
            Contenedor.Controls.Add(Tipo);
            Contenedor.Controls.Add(Eliminar);
            Contenedor.Controls.Add(linea1);
            Contenedor.Controls.Add(linea2);
            Contenedor.Controls.Add(Obligatoria);
            Contenedor.Controls.Add(ToggleButton);

            return Contenedor;
        }

        public override BunifuImageButton BotonEliminar()
        {
            return Eliminar;
        }

        public BunifuImageButton BotonEliminarOpccion()
        {
            return Eliminar_opccion;
        }

        public RJButton BotonCampo()
        {
            return Agregaropccion;
        }

        public void EliminarPregunta(BunifuImageButton EliminarSeleM, Panel panelhijo)
        {
            if (EliminarSeleM.Name == "EliminarSeleccionM1")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM1")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[0] = 249;
                    ArreglosGlobales.PosicionSeleM[1] = 84;
                    ArreglosGlobales.PosicionSeleM[2] = 75;
                    ArreglosGlobales.PosicionSeleM[3] = 134;
                    ArreglosGlobales.PosicionSeleM[4] = 201;
                    ArreglosGlobales.PosicionSeleM[5] = 211;
                    ArreglosGlobales.PosicionSeleM[6] = 188;
                    ArreglosGlobales.PosicionSeleM[7] = 199;
                    ArreglosGlobales.PosicionSeleM[8] = 210;
                    ContSecundarioSeleM.ContadorR_SeleM = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM2")
                        {
                            P.Name = "panelSeleccionM1";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM2")
                                    a.Name = "lblSeleccionM1";

                                if (a is Label && a.Name == "labelSeleccionM2")
                                    a.Name = "labelSeleccionM1";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM2")
                                    a.Name = "TexboxSeleccionM1";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM2")
                                    a.Name = "TexSeleccionM1";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM2")
                                    a.Name = "imagenSeleccionM1";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM2")
                                    a.Name = "EliminarSeleccionM1";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM2")
                                    a.Name = "buttonSeleccionM1";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM2")
                                    a.Name = "CheckBoxSeleccionM1";
                            }
                            int indice = 9;
                            for(int i=0; i<9; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM = ContSecundarioSeleM.ContadorR_SeleM2;
                            ContSecundarioSeleM.ContadorR_SeleM2 = 2;
                            ArreglosGlobales.PosicionSeleM[9] = 249;
                            ArreglosGlobales.PosicionSeleM[10] = 84;
                            ArreglosGlobales.PosicionSeleM[11] = 75;
                            ArreglosGlobales.PosicionSeleM[12] = 134;
                            ArreglosGlobales.PosicionSeleM[13] = 201;
                            ArreglosGlobales.PosicionSeleM[14] = 211;
                            ArreglosGlobales.PosicionSeleM[15] = 188;
                            ArreglosGlobales.PosicionSeleM[16] = 199;
                            ArreglosGlobales.PosicionSeleM[17] = 210;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM3")
                        {
                            P.Name = "panelSeleccionM2";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM3")
                                    a.Name = "lblSeleccionM2";

                                if (a is Label && a.Name == "labelSeleccionM3")
                                    a.Name = "labelSeleccionM2";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM3")
                                    a.Name = "TexboxSeleccionM2";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM3")
                                    a.Name = "TexSeleccionM2";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM3")
                                    a.Name = "imagenSeleccionM2";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM3")
                                    a.Name = "EliminarSeleccionM2";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM3")
                                    a.Name = "buttonSeleccionM2";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM3")
                                    a.Name = "CheckBoxSeleccionM2";
                            }
                            int indice = 18;
                            for (int i = 9; i < 17; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }

                            ArreglosGlobales.PosicionSeleM[9] = ArreglosGlobales.PosicionSeleM[18];
                            ArreglosGlobales.PosicionSeleM[10] = ArreglosGlobales.PosicionSeleM[19];
                            ArreglosGlobales.PosicionSeleM[11] = ArreglosGlobales.PosicionSeleM[20];
                            ArreglosGlobales.PosicionSeleM[12] = ArreglosGlobales.PosicionSeleM[21];
                            ArreglosGlobales.PosicionSeleM[13] = ArreglosGlobales.PosicionSeleM[22];
                            ArreglosGlobales.PosicionSeleM[14] = ArreglosGlobales.PosicionSeleM[23];
                            ArreglosGlobales.PosicionSeleM[15] = ArreglosGlobales.PosicionSeleM[24];
                            ArreglosGlobales.PosicionSeleM[16] = ArreglosGlobales.PosicionSeleM[25];
                            ArreglosGlobales.PosicionSeleM[17] = ArreglosGlobales.PosicionSeleM[26];
                            ContSecundarioSeleM.ContadorR_SeleM2 = ContSecundarioSeleM.ContadorR_SeleM3;
                            ContSecundarioSeleM.ContadorR_SeleM3 = 2;
                            ArreglosGlobales.PosicionSeleM[18] = 249;
                            ArreglosGlobales.PosicionSeleM[19] = 84;
                            ArreglosGlobales.PosicionSeleM[20] = 75;
                            ArreglosGlobales.PosicionSeleM[21] = 134;
                            ArreglosGlobales.PosicionSeleM[22] = 201;
                            ArreglosGlobales.PosicionSeleM[23] = 211;
                            ArreglosGlobales.PosicionSeleM[24] = 188;
                            ArreglosGlobales.PosicionSeleM[25] = 199;
                            ArreglosGlobales.PosicionSeleM[26] = 210;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM4")
                        {

                            P.Name = "panelSeleccionM3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM4")
                                    a.Name = "lblSeleccionM3";

                                if (a is Label && a.Name == "labelSeleccionM4")
                                    a.Name = "labelSeleccionM3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM4")
                                    a.Name = "TexboxSeleccionM3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM4")
                                    a.Name = "TexSeleccionM3";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM4")
                                    a.Name = "imagenSeleccionM3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM4")
                                    a.Name = "EliminarSeleccionM3";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM4")
                                    a.Name = "buttonSeleccionM3";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM4")
                                    a.Name = "CheckBoxSeleccionM3";
                            }
                            int indice = 27;
                            for (int i = 18; i < 26; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM3 = ContSecundarioSeleM.ContadorR_SeleM4;
                            ContSecundarioSeleM.ContadorR_SeleM4 = 2;
                            ArreglosGlobales.PosicionSeleM[27] = 249;
                            ArreglosGlobales.PosicionSeleM[28] = 84;
                            ArreglosGlobales.PosicionSeleM[29] = 75;
                            ArreglosGlobales.PosicionSeleM[30] = 134;
                            ArreglosGlobales.PosicionSeleM[31] = 201;
                            ArreglosGlobales.PosicionSeleM[32] = 211;
                            ArreglosGlobales.PosicionSeleM[33] = 188;
                            ArreglosGlobales.PosicionSeleM[34] = 199;
                            ArreglosGlobales.PosicionSeleM[35] = 210;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM5")
                        {
                            int indice = 36;
                            for (int i = 27; i < 35; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM4 = ContSecundarioSeleM.ContadorR_SeleM5;
                            ContSecundarioSeleM.ContadorR_SeleM5 = 2;
                            ArreglosGlobales.PosicionSeleM[37] = 249;
                            ArreglosGlobales.PosicionSeleM[37] = 84;
                            ArreglosGlobales.PosicionSeleM[38] = 75;
                            ArreglosGlobales.PosicionSeleM[39] = 134;
                            ArreglosGlobales.PosicionSeleM[40] = 201;
                            ArreglosGlobales.PosicionSeleM[41] = 211;
                            ArreglosGlobales.PosicionSeleM[42] = 188;
                            ArreglosGlobales.PosicionSeleM[43] = 199;
                            ArreglosGlobales.PosicionSeleM[44] = 210;
                            P.Name = "panelSeleccionM4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM5")
                                    a.Name = "lblSeleccionM4";

                                if (a is Label && a.Name == "labelSeleccionM5")
                                    a.Name = "labelSeleccionM4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM5")
                                    a.Name = "TexboxSeleccionM4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM5")
                                    a.Name = "TexSeleccionM4";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM5")
                                    a.Name = "imagenSeleccionM4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM5")
                                    a.Name = "EliminarSeleccionM4";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM5")
                                    a.Name = "buttonSeleccionM4";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM5")
                                    a.Name = "CheckBoxSeleccionM4";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM6")
                        {
                            int indice = 45;
                            for (int i = 36; i < 44; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM5 = ContSecundarioSeleM.ContadorR_SeleM6;
                            ContSecundarioSeleM.ContadorR_SeleM6 = 2;
                            ArreglosGlobales.PosicionSeleM[45] = 180;
                            ArreglosGlobales.PosicionSeleM[46] = 62;
                            ArreglosGlobales.PosicionSeleM[47] = 57;
                            ArreglosGlobales.PosicionSeleM[48] = 95;
                            ArreglosGlobales.PosicionSeleM[49] = 146;
                            ArreglosGlobales.PosicionSeleM[50] = 155;
                            ArreglosGlobales.PosicionSeleM[51] = 135;
                            ArreglosGlobales.PosicionSeleM[52] = 143;
                            ArreglosGlobales.PosicionSeleM[53] = 152;
                            P.Name = "panelSeleccionM5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM6")
                                    a.Name = "lblSeleccionM5";

                                if (a is Label && a.Name == "labelSeleccionM6")
                                    a.Name = "labelSeleccionM5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM6")
                                    a.Name = "TexboxSeleccionM5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM6")
                                    a.Name = "TexSeleccionM5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM6")
                                    a.Name = "imagenSeleccionM5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM6")
                                    a.Name = "EliminarSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM6")
                                    a.Name = "buttonSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM6")
                                    a.Name = "CheckBoxSeleccionM5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM7")
                        {
                            int indice = 54;
                            for (int i = 45; i < 53; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[54] = 180;
                            ArreglosGlobales.PosicionSeleM[55] = 62;
                            ArreglosGlobales.PosicionSeleM[56] = 57;
                            ArreglosGlobales.PosicionSeleM[57] = 95;
                            ArreglosGlobales.PosicionSeleM[58] = 146;
                            ArreglosGlobales.PosicionSeleM[59] = 155;
                            ArreglosGlobales.PosicionSeleM[60] = 135;
                            ArreglosGlobales.PosicionSeleM[61] = 143;
                            ArreglosGlobales.PosicionSeleM[62] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM6 = ContSecundarioSeleM.ContadorR_SeleM7;
                            ContSecundarioSeleM.ContadorR_SeleM7 = 2;
                            P.Name = "panelSeleccionM6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM7")
                                    a.Name = "lblSeleccionM6";

                                if (a is Label && a.Name == "labelSeleccionM7")
                                    a.Name = "labelSeleccionM6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM7")
                                    a.Name = "TexboxSeleccionM6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM7")
                                    a.Name = "TexSeleccionM6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM7")
                                    a.Name = "imagenSeleccionM6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM7")
                                    a.Name = "EliminarSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM7")
                                    a.Name = "buttonSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM7")
                                    a.Name = "CheckBoxSeleccionM6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM8")
                        {
                            int indice = 63;
                            for (int i = 54; i < 62; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[63] = 180;
                            ArreglosGlobales.PosicionSeleM[64] = 62;
                            ArreglosGlobales.PosicionSeleM[65] = 57;
                            ArreglosGlobales.PosicionSeleM[66] = 95;
                            ArreglosGlobales.PosicionSeleM[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleM[69] = 135;
                            ArreglosGlobales.PosicionSeleM[70] = 143;
                            ArreglosGlobales.PosicionSeleM[71] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM7 = ContSecundarioSeleM.ContadorR_SeleM8;
                            ContSecundarioSeleM.ContadorR_SeleM8 = 2;
                            P.Name = "panelSeleccionM7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM8")
                                    a.Name = "lblSeleccionM7";

                                if (a is Label && a.Name == "labelSeleccionM8")
                                    a.Name = "labelSeleccionM7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM8")
                                    a.Name = "TexboxSeleccionM7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM8")
                                    a.Name = "TexSeleccionM7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM8")
                                    a.Name = "imagenSeleccionM7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM8")
                                    a.Name = "EliminarSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM8")
                                    a.Name = "buttonSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM8")
                                    a.Name = "CheckBoxSeleccionM7";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            int indice = 72;
                            for (int i = 63; i < 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[72] = 180;
                            ArreglosGlobales.PosicionSeleM[73] = 62;
                            ArreglosGlobales.PosicionSeleM[74] = 57;
                            ArreglosGlobales.PosicionSeleM[75] = 95;
                            ArreglosGlobales.PosicionSeleM[76] = 146;
                            ArreglosGlobales.PosicionSeleM[77] = 155;
                            ArreglosGlobales.PosicionSeleM[78] = 135;
                            ArreglosGlobales.PosicionSeleM[79] = 143;
                            ArreglosGlobales.PosicionSeleM[80] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM8 = ContSecundarioSeleM.ContadorR_SeleM9;
                            ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                            P.Name = "panelSeleccionM8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM9")
                                    a.Name = "lblSeleccionM8";

                                if (a is Label && a.Name == "labelSeleccionM9")
                                    a.Name = "labelSeleccionM8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                    a.Name = "TexboxSeleccionM8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM9")
                                    a.Name = "TexSeleccionM8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM9")
                                    a.Name = "imagenSeleccionM8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                                    a.Name = "EliminarSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM9")
                                    a.Name = "buttonSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM9")
                                    a.Name = "CheckBoxSeleccionM8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM2")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM2")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[9] = 180;
                    ArreglosGlobales.PosicionSeleM[10] = 62;
                    ArreglosGlobales.PosicionSeleM[11] = 57;
                    ArreglosGlobales.PosicionSeleM[12] = 95;
                    ArreglosGlobales.PosicionSeleM[13] = 146;
                    ArreglosGlobales.PosicionSeleM[14] = 155;
                    ArreglosGlobales.PosicionSeleM[15] = 135;
                    ArreglosGlobales.PosicionSeleM[16] = 143;
                    ArreglosGlobales.PosicionSeleM[17] = 152;
                    ContSecundarioSeleM.ContadorR_SeleM2 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM3")
                        {
                            P.Name = "panelSeleccionM2";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM3")
                                    a.Name = "lblSeleccionM2";

                                if (a is Label && a.Name == "labelSeleccionM3")
                                    a.Name = "labelSeleccionM2";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM3")
                                    a.Name = "TexboxSeleccionM2";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM3")
                                    a.Name = "TexSeleccionM2";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM3")
                                    a.Name = "imagenSeleccionM2";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM3")
                                    a.Name = "EliminarSeleccionM2";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM3")
                                    a.Name = "buttonSeleccionM2";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM3")
                                    a.Name = "CheckBoxSeleccionM2";
                            }
                            int indice = 18;
                            for (int i = 9; i < 17; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM2 = ContSecundarioSeleM.ContadorR_SeleM3;
                            ContSecundarioSeleM.ContadorR_SeleM3 = 2;
                            ArreglosGlobales.PosicionSeleM[18] = 180;
                            ArreglosGlobales.PosicionSeleM[19] = 62;
                            ArreglosGlobales.PosicionSeleM[20] = 57;
                            ArreglosGlobales.PosicionSeleM[21] = 95;
                            ArreglosGlobales.PosicionSeleM[22] = 146;
                            ArreglosGlobales.PosicionSeleM[23] = 155;
                            ArreglosGlobales.PosicionSeleM[24] = 135;
                            ArreglosGlobales.PosicionSeleM[25] = 143;
                            ArreglosGlobales.PosicionSeleM[26] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM4")
                        {

                            P.Name = "panelSeleccionM3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM4")
                                    a.Name = "lblSeleccionM3";

                                if (a is Label && a.Name == "labelSeleccionM4")
                                    a.Name = "labelSeleccionM3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM4")
                                    a.Name = "TexboxSeleccionM3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM4")
                                    a.Name = "TexSeleccionM3";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM4")
                                    a.Name = "imagenSeleccionM3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM4")
                                    a.Name = "EliminarSeleccionM3";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM4")
                                    a.Name = "buttonSeleccionM3";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM4")
                                    a.Name = "CheckBoxSeleccionM3";
                            }
                            int indice = 27;
                            for (int i = 18; i < 26; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM3 = ContSecundarioSeleM.ContadorR_SeleM4;
                            ContSecundarioSeleM.ContadorR_SeleM4 = 2;
                            ArreglosGlobales.PosicionSeleM[27] = 180;
                            ArreglosGlobales.PosicionSeleM[28] = 62;
                            ArreglosGlobales.PosicionSeleM[29] = 57;
                            ArreglosGlobales.PosicionSeleM[30] = 95;
                            ArreglosGlobales.PosicionSeleM[31] = 146;
                            ArreglosGlobales.PosicionSeleM[32] = 155;
                            ArreglosGlobales.PosicionSeleM[33] = 135;
                            ArreglosGlobales.PosicionSeleM[34] = 143;
                            ArreglosGlobales.PosicionSeleM[35] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM5")
                        {
                            int indice = 36;
                            for (int i = 27; i < 35; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM4 = ContSecundarioSeleM.ContadorR_SeleM5;
                            ContSecundarioSeleM.ContadorR_SeleM5 = 2;
                            ArreglosGlobales.PosicionSeleM[37] = 180;
                            ArreglosGlobales.PosicionSeleM[37] = 62;
                            ArreglosGlobales.PosicionSeleM[38] = 57;
                            ArreglosGlobales.PosicionSeleM[39] = 95;
                            ArreglosGlobales.PosicionSeleM[40] = 146;
                            ArreglosGlobales.PosicionSeleM[41] = 155;
                            ArreglosGlobales.PosicionSeleM[42] = 135;
                            ArreglosGlobales.PosicionSeleM[43] = 143;
                            ArreglosGlobales.PosicionSeleM[44] = 152;
                            P.Name = "panelSeleccionM4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM5")
                                    a.Name = "lblSeleccionM4";

                                if (a is Label && a.Name == "labelSeleccionM5")
                                    a.Name = "labelSeleccionM4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM5")
                                    a.Name = "TexboxSeleccionM4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM5")
                                    a.Name = "TexSeleccionM4";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM5")
                                    a.Name = "imagenSeleccionM4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM5")
                                    a.Name = "EliminarSeleccionM4";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM5")
                                    a.Name = "buttonSeleccionM4";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM5")
                                    a.Name = "CheckBoxSeleccionM4";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM6")
                        {
                            int indice = 45;
                            for (int i = 36; i < 44; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM5 = ContSecundarioSeleM.ContadorR_SeleM6;
                            ContSecundarioSeleM.ContadorR_SeleM6 = 2;
                            ArreglosGlobales.PosicionSeleM[45] = 180;
                            ArreglosGlobales.PosicionSeleM[46] = 62;
                            ArreglosGlobales.PosicionSeleM[47] = 57;
                            ArreglosGlobales.PosicionSeleM[48] = 95;
                            ArreglosGlobales.PosicionSeleM[49] = 146;
                            ArreglosGlobales.PosicionSeleM[50] = 155;
                            ArreglosGlobales.PosicionSeleM[51] = 135;
                            ArreglosGlobales.PosicionSeleM[52] = 143;
                            ArreglosGlobales.PosicionSeleM[53] = 152;
                            P.Name = "panelSeleccionM5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM6")
                                    a.Name = "lblSeleccionM5";

                                if (a is Label && a.Name == "labelSeleccionM6")
                                    a.Name = "labelSeleccionM5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM6")
                                    a.Name = "TexboxSeleccionM5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM6")
                                    a.Name = "TexSeleccionM5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM6")
                                    a.Name = "imagenSeleccionM5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM6")
                                    a.Name = "EliminarSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM6")
                                    a.Name = "buttonSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM6")
                                    a.Name = "CheckBoxSeleccionM5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM7")
                        {
                            int indice = 54;
                            for (int i = 45; i < 53; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[54] = 180;
                            ArreglosGlobales.PosicionSeleM[55] = 62;
                            ArreglosGlobales.PosicionSeleM[56] = 57;
                            ArreglosGlobales.PosicionSeleM[57] = 95;
                            ArreglosGlobales.PosicionSeleM[58] = 146;
                            ArreglosGlobales.PosicionSeleM[59] = 155;
                            ArreglosGlobales.PosicionSeleM[60] = 135;
                            ArreglosGlobales.PosicionSeleM[61] = 143;
                            ArreglosGlobales.PosicionSeleM[62] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM6 = ContSecundarioSeleM.ContadorR_SeleM7;
                            ContSecundarioSeleM.ContadorR_SeleM7 = 2;
                            P.Name = "panelSeleccionM6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM7")
                                    a.Name = "lblSeleccionM6";

                                if (a is Label && a.Name == "labelSeleccionM7")
                                    a.Name = "labelSeleccionM6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM7")
                                    a.Name = "TexboxSeleccionM6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM7")
                                    a.Name = "TexSeleccionM6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM7")
                                    a.Name = "imagenSeleccionM6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM7")
                                    a.Name = "EliminarSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM7")
                                    a.Name = "buttonSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM7")
                                    a.Name = "CheckBoxSeleccionM6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM8")
                        {
                            int indice = 63;
                            for (int i = 54; i < 62; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[63] = 180;
                            ArreglosGlobales.PosicionSeleM[64] = 62;
                            ArreglosGlobales.PosicionSeleM[65] = 57;
                            ArreglosGlobales.PosicionSeleM[66] = 95;
                            ArreglosGlobales.PosicionSeleM[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleM[69] = 135;
                            ArreglosGlobales.PosicionSeleM[70] = 143;
                            ArreglosGlobales.PosicionSeleM[71] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM7 = ContSecundarioSeleM.ContadorR_SeleM8;
                            ContSecundarioSeleM.ContadorR_SeleM8 = 2;
                            P.Name = "panelSeleccionM7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM8")
                                    a.Name = "lblSeleccionM7";

                                if (a is Label && a.Name == "labelSeleccionM8")
                                    a.Name = "labelSeleccionM7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM8")
                                    a.Name = "TexboxSeleccionM7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM8")
                                    a.Name = "TexSeleccionM7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM8")
                                    a.Name = "imagenSeleccionM7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM8")
                                    a.Name = "EliminarSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM8")
                                    a.Name = "buttonSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM8")
                                    a.Name = "CheckBoxSeleccionM7";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            int indice = 72;
                            for (int i = 63; i < 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[72] = 180;
                            ArreglosGlobales.PosicionSeleM[73] = 62;
                            ArreglosGlobales.PosicionSeleM[74] = 57;
                            ArreglosGlobales.PosicionSeleM[75] = 95;
                            ArreglosGlobales.PosicionSeleM[76] = 146;
                            ArreglosGlobales.PosicionSeleM[77] = 155;
                            ArreglosGlobales.PosicionSeleM[78] = 135;
                            ArreglosGlobales.PosicionSeleM[79] = 143;
                            ArreglosGlobales.PosicionSeleM[80] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM8 = ContSecundarioSeleM.ContadorR_SeleM9;
                            ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                            P.Name = "panelSeleccionM8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM9")
                                    a.Name = "lblSeleccionM8";

                                if (a is Label && a.Name == "labelSeleccionM9")
                                    a.Name = "labelSeleccionM8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                    a.Name = "TexboxSeleccionM8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM9")
                                    a.Name = "TexSeleccionM8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM9")
                                    a.Name = "imagenSeleccionM8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                                    a.Name = "EliminarSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM9")
                                    a.Name = "buttonSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM9")
                                    a.Name = "CheckBoxSeleccionM8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM3")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM3")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[18] = 180;
                    ArreglosGlobales.PosicionSeleM[19] = 62;
                    ArreglosGlobales.PosicionSeleM[20] = 57;
                    ArreglosGlobales.PosicionSeleM[21] = 95;
                    ArreglosGlobales.PosicionSeleM[22] = 146;
                    ArreglosGlobales.PosicionSeleM[23] = 155;
                    ArreglosGlobales.PosicionSeleM[24] = 135;
                    ArreglosGlobales.PosicionSeleM[25] = 143;
                    ArreglosGlobales.PosicionSeleM[26] = 152;
                    ContSecundarioSeleM.ContadorR_SeleM3 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM4")
                        {

                            P.Name = "panelSeleccionM3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM4")
                                    a.Name = "lblSeleccionM3";

                                if (a is Label && a.Name == "labelSeleccionM4")
                                    a.Name = "labelSeleccionM3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM4")
                                    a.Name = "TexboxSeleccionM3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM4")
                                    a.Name = "TexSeleccionM3";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM4")
                                    a.Name = "imagenSeleccionM3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM4")
                                    a.Name = "EliminarSeleccionM3";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM4")
                                    a.Name = "buttonSeleccionM3";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM4")
                                    a.Name = "CheckBoxSeleccionM3";
                            }
                            int indice = 27;
                            for (int i = 18; i < 26; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM3 = ContSecundarioSeleM.ContadorR_SeleM4;
                            ContSecundarioSeleM.ContadorR_SeleM4 = 2;
                            ArreglosGlobales.PosicionSeleM[27] = 180;
                            ArreglosGlobales.PosicionSeleM[28] = 62;
                            ArreglosGlobales.PosicionSeleM[29] = 57;
                            ArreglosGlobales.PosicionSeleM[30] = 95;
                            ArreglosGlobales.PosicionSeleM[31] = 146;
                            ArreglosGlobales.PosicionSeleM[32] = 155;
                            ArreglosGlobales.PosicionSeleM[33] = 135;
                            ArreglosGlobales.PosicionSeleM[34] = 143;
                            ArreglosGlobales.PosicionSeleM[35] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM5")
                        {
                            int indice = 36;
                            for (int i = 27; i < 35; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM4 = ContSecundarioSeleM.ContadorR_SeleM5;
                            ContSecundarioSeleM.ContadorR_SeleM5 = 2;
                            ArreglosGlobales.PosicionSeleM[37] = 180;
                            ArreglosGlobales.PosicionSeleM[37] = 62;
                            ArreglosGlobales.PosicionSeleM[38] = 57;
                            ArreglosGlobales.PosicionSeleM[39] = 95;
                            ArreglosGlobales.PosicionSeleM[40] = 146;
                            ArreglosGlobales.PosicionSeleM[41] = 155;
                            ArreglosGlobales.PosicionSeleM[42] = 135;
                            ArreglosGlobales.PosicionSeleM[43] = 143;
                            ArreglosGlobales.PosicionSeleM[44] = 152;
                            P.Name = "panelSeleccionM4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM5")
                                    a.Name = "lblSeleccionM4";

                                if (a is Label && a.Name == "labelSeleccionM5")
                                    a.Name = "labelSeleccionM4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM5")
                                    a.Name = "TexboxSeleccionM4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM5")
                                    a.Name = "TexSeleccionM4";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM5")
                                    a.Name = "imagenSeleccionM4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM5")
                                    a.Name = "EliminarSeleccionM4";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM5")
                                    a.Name = "buttonSeleccionM4";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM5")
                                    a.Name = "CheckBoxSeleccionM4";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM6")
                        {
                            int indice = 45;
                            for (int i = 36; i < 44; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM5 = ContSecundarioSeleM.ContadorR_SeleM6;
                            ContSecundarioSeleM.ContadorR_SeleM6 = 2;
                            ArreglosGlobales.PosicionSeleM[45] = 180;
                            ArreglosGlobales.PosicionSeleM[46] = 62;
                            ArreglosGlobales.PosicionSeleM[47] = 57;
                            ArreglosGlobales.PosicionSeleM[48] = 95;
                            ArreglosGlobales.PosicionSeleM[49] = 146;
                            ArreglosGlobales.PosicionSeleM[50] = 155;
                            ArreglosGlobales.PosicionSeleM[51] = 135;
                            ArreglosGlobales.PosicionSeleM[52] = 143;
                            ArreglosGlobales.PosicionSeleM[53] = 152;
                            P.Name = "panelSeleccionM5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM6")
                                    a.Name = "lblSeleccionM5";

                                if (a is Label && a.Name == "labelSeleccionM6")
                                    a.Name = "labelSeleccionM5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM6")
                                    a.Name = "TexboxSeleccionM5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM6")
                                    a.Name = "TexSeleccionM5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM6")
                                    a.Name = "imagenSeleccionM5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM6")
                                    a.Name = "EliminarSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM6")
                                    a.Name = "buttonSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM6")
                                    a.Name = "CheckBoxSeleccionM5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM7")
                        {
                            int indice = 54;
                            for (int i = 45; i < 53; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[54] = 180;
                            ArreglosGlobales.PosicionSeleM[55] = 62;
                            ArreglosGlobales.PosicionSeleM[56] = 57;
                            ArreglosGlobales.PosicionSeleM[57] = 95;
                            ArreglosGlobales.PosicionSeleM[58] = 146;
                            ArreglosGlobales.PosicionSeleM[59] = 155;
                            ArreglosGlobales.PosicionSeleM[60] = 135;
                            ArreglosGlobales.PosicionSeleM[61] = 143;
                            ArreglosGlobales.PosicionSeleM[62] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM6 = ContSecundarioSeleM.ContadorR_SeleM7;
                            ContSecundarioSeleM.ContadorR_SeleM7 = 2;
                            P.Name = "panelSeleccionM6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM7")
                                    a.Name = "lblSeleccionM6";

                                if (a is Label && a.Name == "labelSeleccionM7")
                                    a.Name = "labelSeleccionM6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM7")
                                    a.Name = "TexboxSeleccionM6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM7")
                                    a.Name = "TexSeleccionM6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM7")
                                    a.Name = "imagenSeleccionM6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM7")
                                    a.Name = "EliminarSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM7")
                                    a.Name = "buttonSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM7")
                                    a.Name = "CheckBoxSeleccionM6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM8")
                        {
                            int indice = 63;
                            for (int i = 54; i < 62; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[63] = 180;
                            ArreglosGlobales.PosicionSeleM[64] = 62;
                            ArreglosGlobales.PosicionSeleM[65] = 57;
                            ArreglosGlobales.PosicionSeleM[66] = 95;
                            ArreglosGlobales.PosicionSeleM[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleM[69] = 135;
                            ArreglosGlobales.PosicionSeleM[70] = 143;
                            ArreglosGlobales.PosicionSeleM[71] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM7 = ContSecundarioSeleM.ContadorR_SeleM8;
                            ContSecundarioSeleM.ContadorR_SeleM8 = 2;
                            P.Name = "panelSeleccionM7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM8")
                                    a.Name = "lblSeleccionM7";

                                if (a is Label && a.Name == "labelSeleccionM8")
                                    a.Name = "labelSeleccionM7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM8")
                                    a.Name = "TexboxSeleccionM7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM8")
                                    a.Name = "TexSeleccionM7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM8")
                                    a.Name = "imagenSeleccionM7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM8")
                                    a.Name = "EliminarSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM8")
                                    a.Name = "buttonSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM8")
                                    a.Name = "CheckBoxSeleccionM7";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            int indice = 72;
                            for (int i = 63; i < 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[72] = 180;
                            ArreglosGlobales.PosicionSeleM[73] = 62;
                            ArreglosGlobales.PosicionSeleM[74] = 57;
                            ArreglosGlobales.PosicionSeleM[75] = 95;
                            ArreglosGlobales.PosicionSeleM[76] = 146;
                            ArreglosGlobales.PosicionSeleM[77] = 155;
                            ArreglosGlobales.PosicionSeleM[78] = 135;
                            ArreglosGlobales.PosicionSeleM[79] = 143;
                            ArreglosGlobales.PosicionSeleM[80] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM8 = ContSecundarioSeleM.ContadorR_SeleM9;
                            ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                            P.Name = "panelSeleccionM8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM9")
                                    a.Name = "lblSeleccionM8";

                                if (a is Label && a.Name == "labelSeleccionM9")
                                    a.Name = "labelSeleccionM8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                    a.Name = "TexboxSeleccionM8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM9")
                                    a.Name = "TexSeleccionM8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM9")
                                    a.Name = "imagenSeleccionM8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                                    a.Name = "EliminarSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM9")
                                    a.Name = "buttonSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM9")
                                    a.Name = "CheckBoxSeleccionM8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM4")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM4")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[27] = 180;
                    ArreglosGlobales.PosicionSeleM[28] = 62;
                    ArreglosGlobales.PosicionSeleM[29] = 57;
                    ArreglosGlobales.PosicionSeleM[30] = 95;
                    ArreglosGlobales.PosicionSeleM[31] = 146;
                    ArreglosGlobales.PosicionSeleM[32] = 155;
                    ArreglosGlobales.PosicionSeleM[33] = 135;
                    ArreglosGlobales.PosicionSeleM[34] = 143;
                    ArreglosGlobales.PosicionSeleM[35] = 152;
                    ContSecundarioSeleM.ContadorR_SeleM4 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM5")
                        {
                            int indice = 36;
                            for (int i = 27; i < 35; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM4 = ContSecundarioSeleM.ContadorR_SeleM5;
                            ContSecundarioSeleM.ContadorR_SeleM5 = 2;
                            ArreglosGlobales.PosicionSeleM[37] = 180;
                            ArreglosGlobales.PosicionSeleM[37] = 62;
                            ArreglosGlobales.PosicionSeleM[38] = 57;
                            ArreglosGlobales.PosicionSeleM[39] = 95;
                            ArreglosGlobales.PosicionSeleM[40] = 146;
                            ArreglosGlobales.PosicionSeleM[41] = 155;
                            ArreglosGlobales.PosicionSeleM[42] = 135;
                            ArreglosGlobales.PosicionSeleM[43] = 143;
                            ArreglosGlobales.PosicionSeleM[44] = 152;
                            P.Name = "panelSeleccionM4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM5")
                                    a.Name = "lblSeleccionM4";

                                if (a is Label && a.Name == "labelSeleccionM5")
                                    a.Name = "labelSeleccionM4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM5")
                                    a.Name = "TexboxSeleccionM4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM5")
                                    a.Name = "TexSeleccionM4";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM5")
                                    a.Name = "imagenSeleccionM4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM5")
                                    a.Name = "EliminarSeleccionM4";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM5")
                                    a.Name = "buttonSeleccionM4";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM5")
                                    a.Name = "CheckBoxSeleccionM4";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM6")
                        {
                            int indice = 45;
                            for (int i = 36; i < 44; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM5 = ContSecundarioSeleM.ContadorR_SeleM6;
                            ContSecundarioSeleM.ContadorR_SeleM6 = 2;
                            ArreglosGlobales.PosicionSeleM[45] = 180;
                            ArreglosGlobales.PosicionSeleM[46] = 62;
                            ArreglosGlobales.PosicionSeleM[47] = 57;
                            ArreglosGlobales.PosicionSeleM[48] = 95;
                            ArreglosGlobales.PosicionSeleM[49] = 146;
                            ArreglosGlobales.PosicionSeleM[50] = 155;
                            ArreglosGlobales.PosicionSeleM[51] = 135;
                            ArreglosGlobales.PosicionSeleM[52] = 143;
                            ArreglosGlobales.PosicionSeleM[53] = 152;
                            P.Name = "panelSeleccionM5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM6")
                                    a.Name = "lblSeleccionM5";

                                if (a is Label && a.Name == "labelSeleccionM6")
                                    a.Name = "labelSeleccionM5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM6")
                                    a.Name = "TexboxSeleccionM5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM6")
                                    a.Name = "TexSeleccionM5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM6")
                                    a.Name = "imagenSeleccionM5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM6")
                                    a.Name = "EliminarSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM6")
                                    a.Name = "buttonSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM6")
                                    a.Name = "CheckBoxSeleccionM5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM7")
                        {
                            int indice = 54;
                            for (int i = 45; i < 53; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[54] = 180;
                            ArreglosGlobales.PosicionSeleM[55] = 62;
                            ArreglosGlobales.PosicionSeleM[56] = 57;
                            ArreglosGlobales.PosicionSeleM[57] = 95;
                            ArreglosGlobales.PosicionSeleM[58] = 146;
                            ArreglosGlobales.PosicionSeleM[59] = 155;
                            ArreglosGlobales.PosicionSeleM[60] = 135;
                            ArreglosGlobales.PosicionSeleM[61] = 143;
                            ArreglosGlobales.PosicionSeleM[62] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM6 = ContSecundarioSeleM.ContadorR_SeleM7;
                            ContSecundarioSeleM.ContadorR_SeleM7 = 2;
                            P.Name = "panelSeleccionM6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM7")
                                    a.Name = "lblSeleccionM6";

                                if (a is Label && a.Name == "labelSeleccionM7")
                                    a.Name = "labelSeleccionM6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM7")
                                    a.Name = "TexboxSeleccionM6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM7")
                                    a.Name = "TexSeleccionM6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM7")
                                    a.Name = "imagenSeleccionM6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM7")
                                    a.Name = "EliminarSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM7")
                                    a.Name = "buttonSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM7")
                                    a.Name = "CheckBoxSeleccionM6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM8")
                        {
                            int indice = 63;
                            for (int i = 54; i < 62; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[63] = 180;
                            ArreglosGlobales.PosicionSeleM[64] = 62;
                            ArreglosGlobales.PosicionSeleM[65] = 57;
                            ArreglosGlobales.PosicionSeleM[66] = 95;
                            ArreglosGlobales.PosicionSeleM[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleM[69] = 135;
                            ArreglosGlobales.PosicionSeleM[70] = 143;
                            ArreglosGlobales.PosicionSeleM[71] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM7 = ContSecundarioSeleM.ContadorR_SeleM8;
                            ContSecundarioSeleM.ContadorR_SeleM8 = 2;
                            P.Name = "panelSeleccionM7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM8")
                                    a.Name = "lblSeleccionM7";

                                if (a is Label && a.Name == "labelSeleccionM8")
                                    a.Name = "labelSeleccionM7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM8")
                                    a.Name = "TexboxSeleccionM7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM8")
                                    a.Name = "TexSeleccionM7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM8")
                                    a.Name = "imagenSeleccionM7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM8")
                                    a.Name = "EliminarSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM8")
                                    a.Name = "buttonSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM8")
                                    a.Name = "CheckBoxSeleccionM7";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            int indice = 72;
                            for (int i = 63; i < 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[72] = 180;
                            ArreglosGlobales.PosicionSeleM[73] = 62;
                            ArreglosGlobales.PosicionSeleM[74] = 57;
                            ArreglosGlobales.PosicionSeleM[75] = 95;
                            ArreglosGlobales.PosicionSeleM[76] = 146;
                            ArreglosGlobales.PosicionSeleM[77] = 155;
                            ArreglosGlobales.PosicionSeleM[78] = 135;
                            ArreglosGlobales.PosicionSeleM[79] = 143;
                            ArreglosGlobales.PosicionSeleM[80] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM8 = ContSecundarioSeleM.ContadorR_SeleM9;
                            ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                            P.Name = "panelSeleccionM8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM9")
                                    a.Name = "lblSeleccionM8";

                                if (a is Label && a.Name == "labelSeleccionM9")
                                    a.Name = "labelSeleccionM8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                    a.Name = "TexboxSeleccionM8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM9")
                                    a.Name = "TexSeleccionM8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM9")
                                    a.Name = "imagenSeleccionM8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                                    a.Name = "EliminarSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM9")
                                    a.Name = "buttonSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM9")
                                    a.Name = "CheckBoxSeleccionM8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM5")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM5")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[36] = 180;
                    ArreglosGlobales.PosicionSeleM[37] = 62;
                    ArreglosGlobales.PosicionSeleM[38] = 57;
                    ArreglosGlobales.PosicionSeleM[39] = 95;
                    ArreglosGlobales.PosicionSeleM[40] = 146;
                    ArreglosGlobales.PosicionSeleM[41] = 155;
                    ArreglosGlobales.PosicionSeleM[42] = 135;
                    ArreglosGlobales.PosicionSeleM[43] = 143;
                    ArreglosGlobales.PosicionSeleM[44] = 152;
                    ContSecundarioSeleM.ContadorR_SeleM5 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM6")
                        {
                            int indice = 45;
                            for (int i = 36; i < 44; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ContSecundarioSeleM.ContadorR_SeleM5 = ContSecundarioSeleM.ContadorR_SeleM6;
                            ContSecundarioSeleM.ContadorR_SeleM6 = 2;
                            ArreglosGlobales.PosicionSeleM[45] = 180;
                            ArreglosGlobales.PosicionSeleM[46] = 62;
                            ArreglosGlobales.PosicionSeleM[47] = 57;
                            ArreglosGlobales.PosicionSeleM[48] = 95;
                            ArreglosGlobales.PosicionSeleM[49] = 146;
                            ArreglosGlobales.PosicionSeleM[50] = 155;
                            ArreglosGlobales.PosicionSeleM[51] = 135;
                            ArreglosGlobales.PosicionSeleM[52] = 143;
                            ArreglosGlobales.PosicionSeleM[53] = 152;
                            P.Name = "panelSeleccionM5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM6")
                                    a.Name = "lblSeleccionM5";

                                if (a is Label && a.Name == "labelSeleccionM6")
                                    a.Name = "labelSeleccionM5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM6")
                                    a.Name = "TexboxSeleccionM5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM6")
                                    a.Name = "TexSeleccionM5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM6")
                                    a.Name = "imagenSeleccionM5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM6")
                                    a.Name = "EliminarSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM6")
                                    a.Name = "buttonSeleccionM5";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM6")
                                    a.Name = "CheckBoxSeleccionM5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM7")
                        {
                            int indice = 54;
                            for (int i = 45; i < 53; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[54] = 180;
                            ArreglosGlobales.PosicionSeleM[55] = 62;
                            ArreglosGlobales.PosicionSeleM[56] = 57;
                            ArreglosGlobales.PosicionSeleM[57] = 95;
                            ArreglosGlobales.PosicionSeleM[58] = 146;
                            ArreglosGlobales.PosicionSeleM[59] = 155;
                            ArreglosGlobales.PosicionSeleM[60] = 135;
                            ArreglosGlobales.PosicionSeleM[61] = 143;
                            ArreglosGlobales.PosicionSeleM[62] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM6 = ContSecundarioSeleM.ContadorR_SeleM7;
                            ContSecundarioSeleM.ContadorR_SeleM7 = 2;
                            P.Name = "panelSeleccionM6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM7")
                                    a.Name = "lblSeleccionM6";

                                if (a is Label && a.Name == "labelSeleccionM7")
                                    a.Name = "labelSeleccionM6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM7")
                                    a.Name = "TexboxSeleccionM6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM7")
                                    a.Name = "TexSeleccionM6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM7")
                                    a.Name = "imagenSeleccionM6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM7")
                                    a.Name = "EliminarSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM7")
                                    a.Name = "buttonSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM7")
                                    a.Name = "CheckBoxSeleccionM6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM8")
                        {
                            int indice = 63;
                            for (int i = 54; i < 62; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[63] = 180;
                            ArreglosGlobales.PosicionSeleM[64] = 62;
                            ArreglosGlobales.PosicionSeleM[65] = 57;
                            ArreglosGlobales.PosicionSeleM[66] = 95;
                            ArreglosGlobales.PosicionSeleM[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleM[69] = 135;
                            ArreglosGlobales.PosicionSeleM[70] = 143;
                            ArreglosGlobales.PosicionSeleM[71] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM7 = ContSecundarioSeleM.ContadorR_SeleM8;
                            ContSecundarioSeleM.ContadorR_SeleM8 = 2;
                            P.Name = "panelSeleccionM7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM8")
                                    a.Name = "lblSeleccionM7";

                                if (a is Label && a.Name == "labelSeleccionM8")
                                    a.Name = "labelSeleccionM7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM8")
                                    a.Name = "TexboxSeleccionM7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM8")
                                    a.Name = "TexSeleccionM7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM8")
                                    a.Name = "imagenSeleccionM7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM8")
                                    a.Name = "EliminarSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM8")
                                    a.Name = "buttonSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM8")
                                    a.Name = "CheckBoxSeleccionM7";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            int indice = 72;
                            for (int i = 63; i < 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[72] = 180;
                            ArreglosGlobales.PosicionSeleM[73] = 62;
                            ArreglosGlobales.PosicionSeleM[74] = 57;
                            ArreglosGlobales.PosicionSeleM[75] = 95;
                            ArreglosGlobales.PosicionSeleM[76] = 146;
                            ArreglosGlobales.PosicionSeleM[77] = 155;
                            ArreglosGlobales.PosicionSeleM[78] = 135;
                            ArreglosGlobales.PosicionSeleM[79] = 143;
                            ArreglosGlobales.PosicionSeleM[80] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM8 = ContSecundarioSeleM.ContadorR_SeleM9;
                            ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                            P.Name = "panelSeleccionM8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM9")
                                    a.Name = "lblSeleccionM8";

                                if (a is Label && a.Name == "labelSeleccionM9")
                                    a.Name = "labelSeleccionM8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                    a.Name = "TexboxSeleccionM8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM9")
                                    a.Name = "TexSeleccionM8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM9")
                                    a.Name = "imagenSeleccionM8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                                    a.Name = "EliminarSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM9")
                                    a.Name = "buttonSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM9")
                                    a.Name = "CheckBoxSeleccionM8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM6")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM6")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[45] = 180;
                    ArreglosGlobales.PosicionSeleM[46] = 62;
                    ArreglosGlobales.PosicionSeleM[47] = 57;
                    ArreglosGlobales.PosicionSeleM[48] = 95;
                    ArreglosGlobales.PosicionSeleM[49] = 146;
                    ArreglosGlobales.PosicionSeleM[50] = 155;
                    ArreglosGlobales.PosicionSeleM[51] = 135;
                    ArreglosGlobales.PosicionSeleM[52] = 143;
                    ArreglosGlobales.PosicionSeleM[53] = 152;
                    ContSecundarioSeleM.ContadorR_SeleM6 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM7")
                        {
                            int indice = 54;
                            for (int i = 45; i < 53; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[54] = 180;
                            ArreglosGlobales.PosicionSeleM[55] = 62;
                            ArreglosGlobales.PosicionSeleM[56] = 57;
                            ArreglosGlobales.PosicionSeleM[57] = 95;
                            ArreglosGlobales.PosicionSeleM[58] = 146;
                            ArreglosGlobales.PosicionSeleM[59] = 155;
                            ArreglosGlobales.PosicionSeleM[60] = 135;
                            ArreglosGlobales.PosicionSeleM[61] = 143;
                            ArreglosGlobales.PosicionSeleM[62] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM6 = ContSecundarioSeleM.ContadorR_SeleM7;
                            ContSecundarioSeleM.ContadorR_SeleM7 = 2;
                            P.Name = "panelSeleccionM6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM7")
                                    a.Name = "lblSeleccionM6";

                                if (a is Label && a.Name == "labelSeleccionM7")
                                    a.Name = "labelSeleccionM6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM7")
                                    a.Name = "TexboxSeleccionM6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM7")
                                    a.Name = "TexSeleccionM6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM7")
                                    a.Name = "imagenSeleccionM6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM7")
                                    a.Name = "EliminarSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM7")
                                    a.Name = "buttonSeleccionM6";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM7")
                                    a.Name = "CheckBoxSeleccionM6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM8")
                        {
                            int indice = 63;
                            for (int i = 54; i < 62; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[63] = 180;
                            ArreglosGlobales.PosicionSeleM[64] = 62;
                            ArreglosGlobales.PosicionSeleM[65] = 57;
                            ArreglosGlobales.PosicionSeleM[66] = 95;
                            ArreglosGlobales.PosicionSeleM[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleM[69] = 135;
                            ArreglosGlobales.PosicionSeleM[70] = 143;
                            ArreglosGlobales.PosicionSeleM[71] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM7 = ContSecundarioSeleM.ContadorR_SeleM8;
                            ContSecundarioSeleM.ContadorR_SeleM8 = 2;
                            P.Name = "panelSeleccionM7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM8")
                                    a.Name = "lblSeleccionM7";

                                if (a is Label && a.Name == "labelSeleccionM8")
                                    a.Name = "labelSeleccionM7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM8")
                                    a.Name = "TexboxSeleccionM7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM8")
                                    a.Name = "TexSeleccionM7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM8")
                                    a.Name = "imagenSeleccionM7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM8")
                                    a.Name = "EliminarSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM8")
                                    a.Name = "buttonSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM8")
                                    a.Name = "CheckBoxSeleccionM7";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            int indice = 72;
                            for (int i = 63; i < 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[72] = 180;
                            ArreglosGlobales.PosicionSeleM[73] = 62;
                            ArreglosGlobales.PosicionSeleM[74] = 57;
                            ArreglosGlobales.PosicionSeleM[75] = 95;
                            ArreglosGlobales.PosicionSeleM[76] = 146;
                            ArreglosGlobales.PosicionSeleM[77] = 155;
                            ArreglosGlobales.PosicionSeleM[78] = 135;
                            ArreglosGlobales.PosicionSeleM[79] = 143;
                            ArreglosGlobales.PosicionSeleM[80] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM8 = ContSecundarioSeleM.ContadorR_SeleM9;
                            ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                            P.Name = "panelSeleccionM8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM9")
                                    a.Name = "lblSeleccionM8";

                                if (a is Label && a.Name == "labelSeleccionM9")
                                    a.Name = "labelSeleccionM8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                    a.Name = "TexboxSeleccionM8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM9")
                                    a.Name = "TexSeleccionM8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM9")
                                    a.Name = "imagenSeleccionM8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                                    a.Name = "EliminarSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM9")
                                    a.Name = "buttonSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM9")
                                    a.Name = "CheckBoxSeleccionM8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM7")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM7")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[54] = 180;
                    ArreglosGlobales.PosicionSeleM[55] = 62;
                    ArreglosGlobales.PosicionSeleM[56] = 57;
                    ArreglosGlobales.PosicionSeleM[57] = 95;
                    ArreglosGlobales.PosicionSeleM[58] = 146;
                    ArreglosGlobales.PosicionSeleM[59] = 155;
                    ArreglosGlobales.PosicionSeleM[60] = 135;
                    ArreglosGlobales.PosicionSeleM[61] = 143;
                    ArreglosGlobales.PosicionSeleM[62] = 152;
                    ContSecundarioSeleM.ContadorR_SeleM7 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM8")
                        {
                            int indice = 63;
                            for (int i = 54; i < 62; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[63] = 180;
                            ArreglosGlobales.PosicionSeleM[64] = 62;
                            ArreglosGlobales.PosicionSeleM[65] = 57;
                            ArreglosGlobales.PosicionSeleM[66] = 95;
                            ArreglosGlobales.PosicionSeleM[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleM[69] = 135;
                            ArreglosGlobales.PosicionSeleM[70] = 143;
                            ArreglosGlobales.PosicionSeleM[71] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM7 = ContSecundarioSeleM.ContadorR_SeleM8;
                            ContSecundarioSeleM.ContadorR_SeleM8 = 2;
                            P.Name = "panelSeleccionM7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM8")
                                    a.Name = "lblSeleccionM7";

                                if (a is Label && a.Name == "labelSeleccionM8")
                                    a.Name = "labelSeleccionM7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM8")
                                    a.Name = "TexboxSeleccionM7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM8")
                                    a.Name = "TexSeleccionM7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM8")
                                    a.Name = "imagenSeleccionM7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM8")
                                    a.Name = "EliminarSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM8")
                                    a.Name = "buttonSeleccionM7";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM8")
                                    a.Name = "CheckBoxSeleccionM7";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            int indice = 72;
                            for (int i = 63; i < 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[72] = 180;
                            ArreglosGlobales.PosicionSeleM[73] = 62;
                            ArreglosGlobales.PosicionSeleM[74] = 57;
                            ArreglosGlobales.PosicionSeleM[75] = 95;
                            ArreglosGlobales.PosicionSeleM[76] = 146;
                            ArreglosGlobales.PosicionSeleM[77] = 155;
                            ArreglosGlobales.PosicionSeleM[78] = 135;
                            ArreglosGlobales.PosicionSeleM[79] = 143;
                            ArreglosGlobales.PosicionSeleM[80] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM8 = ContSecundarioSeleM.ContadorR_SeleM9;
                            ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                            P.Name = "panelSeleccionM8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM9")
                                    a.Name = "lblSeleccionM8";

                                if (a is Label && a.Name == "labelSeleccionM9")
                                    a.Name = "labelSeleccionM8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                    a.Name = "TexboxSeleccionM8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM9")
                                    a.Name = "TexSeleccionM8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM9")
                                    a.Name = "imagenSeleccionM8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                                    a.Name = "EliminarSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM9")
                                    a.Name = "buttonSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM9")
                                    a.Name = "CheckBoxSeleccionM8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM8")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM8")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[63] = 180;
                    ArreglosGlobales.PosicionSeleM[64] = 62;
                    ArreglosGlobales.PosicionSeleM[65] = 57;
                    ArreglosGlobales.PosicionSeleM[66] = 95;
                    ArreglosGlobales.PosicionSeleM[67] = 146;
                    ArreglosGlobales.PosicionSeleM[68] = 155;
                    ArreglosGlobales.PosicionSeleM[69] = 135;
                    ArreglosGlobales.PosicionSeleM[70] = 143;
                    ArreglosGlobales.PosicionSeleM[71] = 152;
                    ContSecundarioSeleM.ContadorR_SeleM8 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            int indice = 72;
                            for (int i = 63; i < 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] = ArreglosGlobales.PosicionSeleM[indice];
                                indice++;
                            }
                            ArreglosGlobales.PosicionSeleM[72] = 180;
                            ArreglosGlobales.PosicionSeleM[73] = 62;
                            ArreglosGlobales.PosicionSeleM[74] = 57;
                            ArreglosGlobales.PosicionSeleM[75] = 95;
                            ArreglosGlobales.PosicionSeleM[76] = 146;
                            ArreglosGlobales.PosicionSeleM[77] = 155;
                            ArreglosGlobales.PosicionSeleM[78] = 135;
                            ArreglosGlobales.PosicionSeleM[79] = 143;
                            ArreglosGlobales.PosicionSeleM[80] = 152;
                            ContSecundarioSeleM.ContadorR_SeleM8 = ContSecundarioSeleM.ContadorR_SeleM9;
                            ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                            P.Name = "panelSeleccionM8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM9")
                                    a.Name = "lblSeleccionM8";

                                if (a is Label && a.Name == "labelSeleccionM9")
                                    a.Name = "labelSeleccionM8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                    a.Name = "TexboxSeleccionM8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM9")
                                    a.Name = "TexSeleccionM8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM9")
                                    a.Name = "imagenSeleccionM8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                                    a.Name = "EliminarSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM9")
                                    a.Name = "buttonSeleccionM8";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM9")
                                    a.Name = "CheckBoxSeleccionM8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM9")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM9")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    ArreglosGlobales.PosicionSeleM[72] = 180;
                    ArreglosGlobales.PosicionSeleM[73] = 62;
                    ArreglosGlobales.PosicionSeleM[74] = 57;
                    ArreglosGlobales.PosicionSeleM[75] = 95;
                    ArreglosGlobales.PosicionSeleM[76] = 146;
                    ArreglosGlobales.PosicionSeleM[77] = 155;
                    ArreglosGlobales.PosicionSeleM[78] = 135;
                    ArreglosGlobales.PosicionSeleM[79] = 143;
                    ArreglosGlobales.PosicionSeleM[80] = 152;
                    ContSecundarioSeleM.ContadorR_SeleM9 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            P.Name = "panelSeleccionM9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionM10")
                                    a.Name = "lblSeleccionM9";

                                if (a is Label && a.Name == "labelSeleccionM10")
                                    a.Name = "labelSeleccionM9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                    a.Name = "TexboxSeleccionM9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionM10")
                                    a.Name = "TexSeleccionM9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionM10")
                                    a.Name = "imagenSeleccionM9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                                    a.Name = "EliminarSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionM10")
                                    a.Name = "buttonSeleccionM9";
                            }
                            foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                            {
                                if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM10")
                                    a.Name = "CheckBoxSeleccionM9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleM--;
                }

            }
            else if (EliminarSeleM.Name == "EliminarSeleccionM10")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionM10")
                        {
                            foreach (var a in P.Controls.OfType<PanelRedondeado>())
                            {
                                if (a is PanelRedondeado && a.Name == "panelLateral1")
                                    P.Controls.Remove(a);

                            }
                            panelhijo.Controls.Remove(P);
                            P.Dispose();
                        }
                    }
                    frmConfirmation.FormConfirmation("Se ha eliminado la pregunta correctamente");
                    Obtener_Contadores.Total_SeleM--;
                }

            }
        }

        public void AgregarCampo(RJButton ButtonSeleM, PanelRedondeado tempSeleM, PanelRedondeado panelLateral)
        {
            if (ButtonSeleM.Name == "buttonSeleccionM1")
            {
                ContSecundarioSeleM.ContadorR_SeleM++;
                for(int i=0; i<=8; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }

                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[0];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[1]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[2]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[1]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[3]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM1")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[4]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM1")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[4]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[6]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[7]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[8]);
                    }
                    else if (a is Label && a.Name == "labelSeleccionM1")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[5]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[8]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM2")
            {
                ContSecundarioSeleM.ContadorR_SeleM2++;
                for (int i = 9; i <= 17; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
         
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[9];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM2.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[10]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM2.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[11]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM2.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM2.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[10]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[12]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM2")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[13]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM2")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[13]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[15]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[16]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[17]);
                    }
                    else if (a is Label && a.Name == "labelSeleccionM2")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[14]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[17]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM3")
            {
                ContSecundarioSeleM.ContadorR_SeleM3++;
                for (int i = 18; i <= 26; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
               
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[18];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM3.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[19]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM3.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[20]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM3.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM3.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[19]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[21]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM3")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[22]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM3")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[22]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[24]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[25]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[26]);
                    }
                    else if (a is Label && a.Name == "labelSeleccionM3")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[23]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[26]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM4")
            {
                ContSecundarioSeleM.ContadorR_SeleM4++;
                for (int i = 27; i <= 35; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
                
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[27];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM4.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[28]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM4.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[29]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM4.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM4.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[28]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[30]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM4")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[31]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM4")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[31]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[33]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[34]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[35]);
                    }
                    if (a is Label && a.Name == "labelSeleccionM4")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[32]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[35]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM5")
            {
                ContSecundarioSeleM.ContadorR_SeleM5++;
                for (int i = 36; i <= 44; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
                
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[36];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM5.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[37]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM5.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[38]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM5.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM5.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[37]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[39]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM5")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[40]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM5")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[40]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[42]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[43]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[44]);
                    }
                    if (a is Label && a.Name == "labelSeleccionM5")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[41]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[44]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM6")
            {
                ContSecundarioSeleM.ContadorR_SeleM6++;
                for (int i = 45; i <= 53; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
              
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[45];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM6.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[46]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM6.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[47]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM6.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM6.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[46]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[48]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM6")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[49]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM6")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[49]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[51]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[52]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[53]);
                    }
                    if (a is Label && a.Name == "labelSeleccionM6")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[50]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[53]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM7")
            {
                ContSecundarioSeleM.ContadorR_SeleM7++;
                for (int i = 54; i <= 62; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
               
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[54];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM7.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[55]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM7.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[56]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM7.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM7.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[55]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[57]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM7")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[58]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM7")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[58]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[60]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[61]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[62]);
                    }
                    if (a is Label && a.Name == "labelSeleccionM7")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[59]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[62]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM8")
            {
                ContSecundarioSeleM.ContadorR_SeleM8++;
                for (int i = 63; i <= 71; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
                
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[63];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM8.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[64]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM8.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[65]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM8.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM8.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[64]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[66]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM8")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[67]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM8")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[67]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[69]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[70]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[71]);
                    }
                    if (a is Label && a.Name == "labelSeleccionM8")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[68]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[71]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM9")
            {
                ContSecundarioSeleM.ContadorR_SeleM9++;
                for (int i = 72; i <= 80; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
                
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[72];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM9.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[73]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM9.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[74]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM9.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM9.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[73]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[75]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM9")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[76]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM9")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[76]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[78]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[79]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[80]);
                    }
                    if (a is Label && a.Name == "labelSeleccionM9")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[77]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[80]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM10")
            {
                ContSecundarioSeleM.ContadorR_SeleM10++;
                for (int i = 81; i <= 89; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
                
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[81];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM10.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[82]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM10.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[83]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM10.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM10.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[82]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                Eliminar_opccion = EliminarOpccionSeleccionM;
                Eliminar_opccion.Click += EliminarOpccionSeleM_Click;
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[84]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM10")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[85]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM10")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[85]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[87]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[88]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[89]);
                    }
                    if (a is Label && a.Name == "labelSeleccionM10")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[86]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 47)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[89]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
            else if (ButtonSeleM.Name == "buttonSeleccionM11") 
            {
                ContSecundarioSeleM.ContadorR_SeleM11++;
                for (int i = 90; i <= 98; i++)
                {
                    ArreglosGlobales.PosicionSeleM[i] += 50;
                }
                
                tempSeleM.Height = ArreglosGlobales.PosicionSeleM[90];
                tempSeleM.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                BunifuCheckbox checkBoxSeleccionM = new BunifuCheckbox
                {
                    Name = Nombre_checkbox + ContSecundarioSeleM.ContadorR_SeleM11.ToString(),
                    CheckedOnColor = Colores.NormalColor,
                    Location = new Point(27, ArreglosGlobales.PosicionSeleM[91]),
                    Checked = false
                };
                tempSeleM.Controls.Add(checkBoxSeleccionM);

                BunifuMaterialTextbox TexboxOpcciónSeleccionM = new BunifuMaterialTextbox
                {
                    Name = Nombre_respuesta + ContSecundarioSeleM.ContadorR_SeleM11.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = Colores.NormalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 12),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleM[92]),
                    Width = 620,
                    Height = 43,
                    Text = "Opcción" + ContSecundarioSeleM.ContadorR_SeleM10.ToString(),
                    Enabled = false
                };
                BunifuImageButton EliminarOpccionSeleccionM = new BunifuImageButton
                {
                    Name = Nombre_eliminaropccion + ContSecundarioSeleM.ContadorR_SeleM11.ToString(),
                    BackColor = Color.White,
                    Location = new Point(688, ArreglosGlobales.PosicionSeleM[91]),
                    Size = new Size(30, 30),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleM.Controls.Add(EliminarOpccionSeleccionM);
                tempSeleM.Controls.Add(TexboxOpcciónSeleccionM);
                ButtonSeleM.Location = new Point(60, ArreglosGlobales.PosicionSeleM[93]);
                foreach (var a in tempSeleM.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionM11")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[94]);
                }
                foreach (var a in tempSeleM.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionM11")
                        a.Location = new Point(488, ArreglosGlobales.PosicionSeleM[94]);
                }
                foreach (var a in tempSeleM.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 700)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleM[96]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(538, ArreglosGlobales.PosicionSeleM[97]);
                    }
                }
                foreach (var a in tempSeleM.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(550, ArreglosGlobales.PosicionSeleM[98]);
                    }
                    if (a is Label && a.Name == "labelSeleccionM11")
                        a.Location = new Point(58, ArreglosGlobales.PosicionSeleM[95]);
                }
                foreach (var a in tempSeleM.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(666, ArreglosGlobales.PosicionSeleM[98]);
                    }
                }
                MessageBox.Show(ButtonSeleM.Name);
                

            }
        }

        public override void ActivarPregunta(PanelRedondeado tempcontenedor, Panel panelhijo, PanelRedondeado panelLateral)
        {
            Contenedor = tempcontenedor;
            panelLateral.Width = 7;
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Name = "panelLateral1";
            panelLateral.BorderRadius = 0;
            panelLateral.BackColor = Color.FromArgb(27, 102, 218);
            if (tempcontenedor.Name == "panelSeleccionM1")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM1")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM1")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM2")
            {

                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM2")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM2")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM3")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM3")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM3")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM4")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM4")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM4")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM5")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM5")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM5")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM6")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM6")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM6")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM7")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {

                    if (P is PanelRedondeado && P.Name != "panelSeleccionM7")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM7")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM8")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM8")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM8")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM9")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM9")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM9")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
            else if (tempcontenedor.Name == "panelSeleccionM10")
            {
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionM10")
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
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = false;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionM10")
                                a.Focus();
                        }
                        foreach (var a in P.Controls.OfType<BunifuImageButton>())
                        {

                            if (a is BunifuImageButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJButton>())
                        {

                            if (a is RJButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJToggleButton>())
                        {

                            if (a is RJToggleButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<RJRadioButton>())
                        {
                            if (a is RJRadioButton)
                                a.Enabled = true;
                        }
                        foreach (var a in P.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox)
                                a.Enabled = true;
                        }
                    }
                }
                if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempcontenedor.Controls.Add(panelLateral);
                }
            }
        }

        private void EliminarOpccionSeleM_Click(object sender, EventArgs e)
        {
            Eliminar_opccion = sender as BunifuImageButton;
            EliminarOpcSeleM.Pregunta(Contenedor, Eliminar_opccion);
        }
    }
}
