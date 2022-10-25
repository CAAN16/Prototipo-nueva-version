using Bunifu.Framework.UI;
using CapaPresentacion.Globales;
using Controles_personalizados;
using RJCodeAdvance.RJControls;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class Preguntas
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
        #endregion


        public Preguntas(string nombre_contenedor, string nombre_contador, int contador_pregunta, string nombre_pregunta,
        string text_pregunta, string nombre_respuesta, string text_respuesta, string nombre_imagen, Image image, string nombre_tipo,
        string text_tipo, string nombre_eliminar)
        {
            Nombre_contenedor = nombre_contenedor;
            Nombre_contador = nombre_contador;
            Contador_pregunta = contador_pregunta;
            Nombre_pregunta = nombre_pregunta;
            Text_pregunta = text_pregunta;
            Nombre_respuesta = nombre_respuesta;
            Text_respuesta = text_respuesta;
            Nombre_imagen = nombre_imagen;
            Image1 = image;
            Nombre_tipo = nombre_tipo;
            Text_tipo = text_tipo;
            Nombre_eliminar = nombre_eliminar;
        }

        public virtual void InicializarCampos()
        {
            Contenedor = new PanelRedondeado
            {
                Height = 205,
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
                Name = Nombre_respuesta + Contador_pregunta.ToString(),
                LineIdleColor = Color.White,
                LineFocusedColor = Color.FromArgb(26, 152, 34),
                LineMouseHoverColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 12),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(60, 75),
                Width = 665,
                Height = 43,
                Text = Text_respuesta,
                Enabled = false
            };
            Imagen = new PictureBox
            {
                Name = Nombre_imagen + Contador_pregunta.ToString(),
                Location = new Point(17, 162),
                Size = new Size(35, 35),
                Image = Image1,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Tipo = new Label
            {
                Name = Nombre_tipo + Contador_pregunta.ToString(),
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                Location = new Point(58, 170),
                Width = 200,
                Text = Text_tipo
            };
            Eliminar = new BunifuImageButton
            {
                Name = Nombre_eliminar + Contador_pregunta.ToString(),
                BackColor = Color.White,
                Image = Properties.Resources.trash_512px,
                Location = new Point(488, 162),
                Size = new Size(35, 35),
                SizeMode = PictureBoxSizeMode.Zoom,
                Zoom = 10,
                Enabled = false
            };
            Linea1 = new PanelRedondeado
            {
                BackColor = Color.LightGray,
                Location = new Point(538, 160),
                Size = new Size(2, 40)
            };
            Linea2 = new PanelRedondeado
            {
                BackColor = Color.LightGray,
                Location = new Point(15, 150),
                Size = new Size(700, 2)
            };
            Obligatoria = new Label
            {
                BackColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                Location = new Point(550, 169),
                Size = new Size(111, 24),
                Text = "Obligatoria"
            };
            ToggleButton = new RJToggleButton
            {
                BackColor = Color.White,
                Location = new Point(666, 169),
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

        public virtual PanelRedondeado AgregarPregunta(Panel panelhijo)
        {
            panelhijo.Controls.Add(Contenedor);
            Contenedor.BringToFront();
            Contenedor.Controls.Add(Contador);
            Contenedor.Controls.Add(Pregunta);
            Contenedor.Controls.Add(Respuesta);
            Contenedor.Controls.Add(Imagen);
            Contenedor.Controls.Add(Tipo);
            Contenedor.Controls.Add(Eliminar);
            Contenedor.Controls.Add(linea1);
            Contenedor.Controls.Add(linea2);
            Contenedor.Controls.Add(Obligatoria);
            Contenedor.Controls.Add(ToggleButton);

            return Contenedor;

        }

        public virtual void ActivarPregunta(PanelRedondeado tempcontenedor, Panel panelhijo, PanelRedondeado panelLateral)
        {
            panelLateral.Width = 7;
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Name = "panelLateral1";
            panelLateral.BorderRadius = 0;
            panelLateral.BackColor = Color.FromArgb(27, 102, 218);

            if (Text_tipo == "Nombre Completo")
            {
                if (tempcontenedor.Name == "panelNombreC1")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC1")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex1" && a.Name != "Tex21")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelNombreC2")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC2")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex2" && a.Name != "Tex22")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }

                }
                else if (tempcontenedor.Name == "panelNombreC3")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC3")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex3" && a.Name != "Tex23")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }

                }
                else if (tempcontenedor.Name == "panelNombreC4")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC4")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex4" && a.Name != "Tex24")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }

                }
                else if (tempcontenedor.Name == "panelNombreC5")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC5")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex5" && a.Name != "Tex25")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }


                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }

                }
                else if (tempcontenedor.Name == "panelNombreC6")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC6")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex6" && a.Name != "Tex26")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }

                }
                else if (tempcontenedor.Name == "panelNombreC7")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC7")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex7" && a.Name != "Tex27")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }

                }
                else if (tempcontenedor.Name == "panelNombreC8")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC8")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex8" && a.Name != "Tex28")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }

                }
                else if (tempcontenedor.Name == "panelNombreC9")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC9")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex9" && a.Name != "Tex29")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }

                }
                else if (tempcontenedor.Name == "panelNombreC10")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelNombreC10")
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
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "Tex10" && a.Name != "Tex10")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
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
            else if (Text_tipo == "Telefono")
            {
                if (tempcontenedor.Name == "panelTel1")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel1")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel1")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel2")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel2")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel2")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel3")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel3")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel3")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel4")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel4")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel4")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel5")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel5")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel5")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel6")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel6")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel6")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel7")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel7")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel7")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel8")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel8")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel8")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel9")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel9")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel9")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTel10")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTel10")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTel10")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
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
            else if (Text_tipo == "Mail")
            {
                if (tempcontenedor.Name == "panelMail1")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail1")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail1")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail2")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail2")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail2")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail3")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail3")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail3")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail4")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail4")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail4")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail5")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail5")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail5")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail6")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail6")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail6")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail7")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail7")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail7")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail8")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail8")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail8")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail9")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail9")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail9")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelMail10")
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelMail10")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexMail10")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
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
            else if (Text_tipo == "Texto Corto")
            {
                if (tempcontenedor.Name == "panelTextC1")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC1")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC1")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC2")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC2")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC2")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC3")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC3")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC3")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC4")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC4")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC4")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC5")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC5")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC5")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC6")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC6")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC6")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC7")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC7")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC7")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC8")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC8")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC8")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC9")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC9")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC9")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextC10")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextC10")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextC10")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
            }
            else if (Text_tipo == "Texto Largo")
            {
                if (tempcontenedor.Name == "panelTextL1")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL1")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL1")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL2")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL2")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL2")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL3")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL3")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL3")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL4")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL4")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL4")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL5")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL5")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL5")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL6")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL6")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL6")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL7")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL7")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL7")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL8")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL8")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL8")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL9")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL9")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL9")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = true;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
                else if (tempcontenedor.Name == "panelTextL10")
                {
                    MessageBox.Show(tempcontenedor.Name);
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name != "panelTextL10")
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
                        }
                        else
                        {
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {

                                if (a is BunifuMaterialTextbox && a.Name != "TexTextL10")
                                {
                                    a.Enabled = true;
                                    a.Focus();
                                }
                            }
                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {

                                if (a is BunifuImageButton)
                                    a.Enabled = true;
                            }
                            foreach (var a in P.Controls.OfType<RJToggleButton>())
                            {

                                if (a is RJToggleButton)
                                    a.Enabled = false;
                            }
                        }
                    }
                    if (!tempcontenedor.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                    {
                        tempcontenedor.Controls.Add(panelLateral);
                    }
                }
            }
        }

        public virtual BunifuImageButton BotonEliminar()
        {
            return Eliminar;
        }

        public virtual void EliminarPregunta(BunifuImageButton Eliminar, Panel panelhijo)
        {
            if (Text_tipo == "Telefono")
            {
                if (Eliminar.Name == "EliminarTel1")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel1")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel2")
                            {
                                P.Name = "panelTel1";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel2")
                                        a.Name = "lblTel1";

                                    if (a is Label && a.Name == "labelTel2")
                                        a.Name = "labelTel1";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel2")
                                        a.Name = "TexboxTel1";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel2")
                                        a.Name = "TexTel1";

                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel2")
                                        a.Name = "imagenTel1";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel2")
                                        a.Name = "EliminarTel1";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel3")
                            {
                                P.Name = "panelTel2";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel3")
                                        a.Name = "lblTel2";

                                    if (a is Label && a.Name == "labelTel3")
                                        a.Name = "labelTel2";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel3")
                                        a.Name = "TexboxTel2";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel3")
                                        a.Name = "TexTel2";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel3")
                                        a.Name = "imagenTel2";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel3")
                                        a.Name = "EliminarTel2";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel4")
                            {
                                P.Name = "panelTel3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel4")
                                        a.Name = "lblTel3";

                                    if (a is Label && a.Name == "labelMail4")
                                        a.Name = "labelTel3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel4")
                                        a.Name = "TexboxTel3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel4")
                                        a.Name = "TexTel3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel4")
                                        a.Name = "imagenTel3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel4")
                                        a.Name = "EliminarTel3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel5")
                            {
                                P.Name = "panelTel4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel5")
                                        a.Name = "lblTel4";

                                    if (a is Label && a.Name == "labelTel5")
                                        a.Name = "labelTel4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel5")
                                        a.Name = "TexboxTel4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel5")
                                        a.Name = "TexTel4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel5")
                                        a.Name = "imagenTel4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel5")
                                        a.Name = "EliminarTel4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel6")
                            {
                                P.Name = "panelTel5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel6")
                                        a.Name = "lblTel5";

                                    if (a is Label && a.Name == "labelTel6")
                                        a.Name = "labelTel5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel6")
                                        a.Name = "TexboxTel5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel6")
                                        a.Name = "TexTel5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel6")
                                        a.Name = "imagenTel5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel6")
                                        a.Name = "EliminarTel5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel7")
                            {
                                P.Name = "panelTel6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel7")
                                        a.Name = "lblTel6";

                                    if (a is Label && a.Name == "labelTel7")
                                        a.Name = "labelTel6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel7")
                                        a.Name = "TexboxTel6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel7")
                                        a.Name = "TexTel6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel7")
                                        a.Name = "imagenTel6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel7")
                                        a.Name = "EliminarTel6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel8")
                            {
                                P.Name = "panelTel7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel8")
                                        a.Name = "lblTel7";

                                    if (a is Label && a.Name == "labelTel8")
                                        a.Name = "labelTel7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel8")
                                        a.Name = "TexboxTel7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel8")
                                        a.Name = "TexTel7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel8")
                                        a.Name = "imagenTel7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel8")
                                        a.Name = "EliminarTel7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel9")
                            {
                                P.Name = "panelTel8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel9")
                                        a.Name = "lblTel8";

                                    if (a is Label && a.Name == "lTel9")
                                        a.Name = "labelTel8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel9")
                                        a.Name = "TexboxTel8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel9")
                                        a.Name = "TexTel8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel9")
                                        a.Name = "imagenTel8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel9")
                                        a.Name = "EliminarTel8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel2")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel2")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel3")
                            {
                                P.Name = "panelTel2";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel3")
                                        a.Name = "lblTel2";

                                    if (a is Label && a.Name == "labelTel3")
                                        a.Name = "labelTel2";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel3")
                                        a.Name = "TexboxTel2";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel3")
                                        a.Name = "TexTel2";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel3")
                                        a.Name = "imagenTel2";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel3")
                                        a.Name = "EliminarTel2";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel4")
                            {
                                P.Name = "panelTel3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel4")
                                        a.Name = "lblTel3";

                                    if (a is Label && a.Name == "labelMail4")
                                        a.Name = "labelTel3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel4")
                                        a.Name = "TexboxTel3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel4")
                                        a.Name = "TexTel3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel4")
                                        a.Name = "imagenTel3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel4")
                                        a.Name = "EliminarTel3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel5")
                            {
                                P.Name = "panelTel4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel5")
                                        a.Name = "lblTel4";

                                    if (a is Label && a.Name == "labelTel5")
                                        a.Name = "labelTel4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel5")
                                        a.Name = "TexboxTel4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel5")
                                        a.Name = "TexTel4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel5")
                                        a.Name = "imagenTel4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel5")
                                        a.Name = "EliminarTel4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel6")
                            {
                                P.Name = "panelTel5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel6")
                                        a.Name = "lblTel5";

                                    if (a is Label && a.Name == "labelTel6")
                                        a.Name = "labelTel5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel6")
                                        a.Name = "TexboxTel5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel6")
                                        a.Name = "TexTel5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel6")
                                        a.Name = "imagenTel5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel6")
                                        a.Name = "EliminarTel5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel7")
                            {
                                P.Name = "panelTel6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel7")
                                        a.Name = "lblTel6";

                                    if (a is Label && a.Name == "labelTel7")
                                        a.Name = "labelTel6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel7")
                                        a.Name = "TexboxTel6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel7")
                                        a.Name = "TexTel6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel7")
                                        a.Name = "imagenTel6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel7")
                                        a.Name = "EliminarTel6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel8")
                            {
                                P.Name = "panelTel7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel8")
                                        a.Name = "lblTel7";

                                    if (a is Label && a.Name == "labelTel8")
                                        a.Name = "labelTel7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel8")
                                        a.Name = "TexboxTel7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel8")
                                        a.Name = "TexTel7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel8")
                                        a.Name = "imagenTel7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel8")
                                        a.Name = "EliminarTel7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel9")
                            {
                                P.Name = "panelTel8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel9")
                                        a.Name = "lblTel8";

                                    if (a is Label && a.Name == "lTel9")
                                        a.Name = "labelTel8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel9")
                                        a.Name = "TexboxTel8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel9")
                                        a.Name = "TexTel8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel9")
                                        a.Name = "imagenTel8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel9")
                                        a.Name = "EliminarTel8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel3")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel3")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel4")
                            {
                                P.Name = "panelTel3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel4")
                                        a.Name = "lblTel3";

                                    if (a is Label && a.Name == "labelMail4")
                                        a.Name = "labelTel3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel4")
                                        a.Name = "TexboxTel3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel4")
                                        a.Name = "TexTel3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel4")
                                        a.Name = "imagenTel3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel4")
                                        a.Name = "EliminarTel3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel5")
                            {
                                P.Name = "panelTel4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel5")
                                        a.Name = "lblTel4";

                                    if (a is Label && a.Name == "labelTel5")
                                        a.Name = "labelTel4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel5")
                                        a.Name = "TexboxTel4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel5")
                                        a.Name = "TexTel4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel5")
                                        a.Name = "imagenTel4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel5")
                                        a.Name = "EliminarTel4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel6")
                            {
                                P.Name = "panelTel5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel6")
                                        a.Name = "lblTel5";

                                    if (a is Label && a.Name == "labelTel6")
                                        a.Name = "labelTel5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel6")
                                        a.Name = "TexboxTel5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel6")
                                        a.Name = "TexTel5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel6")
                                        a.Name = "imagenTel5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel6")
                                        a.Name = "EliminarTel5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel7")
                            {
                                P.Name = "panelTel6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel7")
                                        a.Name = "lblTel6";

                                    if (a is Label && a.Name == "labelTel7")
                                        a.Name = "labelTel6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel7")
                                        a.Name = "TexboxTel6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel7")
                                        a.Name = "TexTel6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel7")
                                        a.Name = "imagenTel6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel7")
                                        a.Name = "EliminarTel6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel8")
                            {
                                P.Name = "panelTel7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel8")
                                        a.Name = "lblTel7";

                                    if (a is Label && a.Name == "labelTel8")
                                        a.Name = "labelTel7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel8")
                                        a.Name = "TexboxTel7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel8")
                                        a.Name = "TexTel7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel8")
                                        a.Name = "imagenTel7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel8")
                                        a.Name = "EliminarTel7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel9")
                            {
                                P.Name = "panelTel8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel9")
                                        a.Name = "lblTel8";

                                    if (a is Label && a.Name == "lTel9")
                                        a.Name = "labelTel8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel9")
                                        a.Name = "TexboxTel8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel9")
                                        a.Name = "TexTel8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel9")
                                        a.Name = "imagenTel8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel9")
                                        a.Name = "EliminarTel8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel4")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel4")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel5")
                            {
                                P.Name = "panelTel4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel5")
                                        a.Name = "lblTel4";

                                    if (a is Label && a.Name == "labelTel5")
                                        a.Name = "labelTel4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel5")
                                        a.Name = "TexboxTel4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel5")
                                        a.Name = "TexTel4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel5")
                                        a.Name = "imagenTel4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel5")
                                        a.Name = "EliminarTel4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel6")
                            {
                                P.Name = "panelTel5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel6")
                                        a.Name = "lblTel5";

                                    if (a is Label && a.Name == "labelTel6")
                                        a.Name = "labelTel5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel6")
                                        a.Name = "TexboxTel5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel6")
                                        a.Name = "TexTel5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel6")
                                        a.Name = "imagenTel5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel6")
                                        a.Name = "EliminarTel5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel7")
                            {
                                P.Name = "panelTel6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel7")
                                        a.Name = "lblTel6";

                                    if (a is Label && a.Name == "labelTel7")
                                        a.Name = "labelTel6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel7")
                                        a.Name = "TexboxTel6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel7")
                                        a.Name = "TexTel6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel7")
                                        a.Name = "imagenTel6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel7")
                                        a.Name = "EliminarTel6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel8")
                            {
                                P.Name = "panelTel7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel8")
                                        a.Name = "lblTel7";

                                    if (a is Label && a.Name == "labelTel8")
                                        a.Name = "labelTel7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel8")
                                        a.Name = "TexboxTel7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel8")
                                        a.Name = "TexTel7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel8")
                                        a.Name = "imagenTel7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel8")
                                        a.Name = "EliminarTel7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel9")
                            {
                                P.Name = "panelTel8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel9")
                                        a.Name = "lblTel8";

                                    if (a is Label && a.Name == "lTel9")
                                        a.Name = "labelTel8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel9")
                                        a.Name = "TexboxTel8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel9")
                                        a.Name = "TexTel8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel9")
                                        a.Name = "imagenTel8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel9")
                                        a.Name = "EliminarTel8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel5")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel5")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel6")
                            {
                                P.Name = "panelTel5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel6")
                                        a.Name = "lblTel5";

                                    if (a is Label && a.Name == "labelTel6")
                                        a.Name = "labelTel5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel6")
                                        a.Name = "TexboxTel5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel6")
                                        a.Name = "TexTel5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel6")
                                        a.Name = "imagenTel5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel6")
                                        a.Name = "EliminarTel5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel7")
                            {
                                P.Name = "panelTel6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel7")
                                        a.Name = "lblTel6";

                                    if (a is Label && a.Name == "labelTel7")
                                        a.Name = "labelTel6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel7")
                                        a.Name = "TexboxTel6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel7")
                                        a.Name = "TexTel6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel7")
                                        a.Name = "imagenTel6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel7")
                                        a.Name = "EliminarTel6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel8")
                            {
                                P.Name = "panelTel7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel8")
                                        a.Name = "lblTel7";

                                    if (a is Label && a.Name == "labelTel8")
                                        a.Name = "labelTel7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel8")
                                        a.Name = "TexboxTel7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel8")
                                        a.Name = "TexTel7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel8")
                                        a.Name = "imagenTel7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel8")
                                        a.Name = "EliminarTel7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel9")
                            {
                                P.Name = "panelTel8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel9")
                                        a.Name = "lblTel8";

                                    if (a is Label && a.Name == "lTel9")
                                        a.Name = "labelTel8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel9")
                                        a.Name = "TexboxTel8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel9")
                                        a.Name = "TexTel8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel9")
                                        a.Name = "imagenTel8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel9")
                                        a.Name = "EliminarTel8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel6")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel6")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel7")
                            {
                                P.Name = "panelTel6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel7")
                                        a.Name = "lblTel6";

                                    if (a is Label && a.Name == "labelTel7")
                                        a.Name = "labelTel6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel7")
                                        a.Name = "TexboxTel6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel7")
                                        a.Name = "TexTel6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel7")
                                        a.Name = "imagenTel6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel7")
                                        a.Name = "EliminarTel6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel8")
                            {
                                P.Name = "panelTel7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel8")
                                        a.Name = "lblTel7";

                                    if (a is Label && a.Name == "labelTel8")
                                        a.Name = "labelTel7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel8")
                                        a.Name = "TexboxTel7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel8")
                                        a.Name = "TexTel7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel8")
                                        a.Name = "imagenTel7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel8")
                                        a.Name = "EliminarTel7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel9")
                            {
                                P.Name = "panelTel8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel9")
                                        a.Name = "lblTel8";

                                    if (a is Label && a.Name == "lTel9")
                                        a.Name = "labelTel8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel9")
                                        a.Name = "TexboxTel8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel9")
                                        a.Name = "TexTel8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel9")
                                        a.Name = "imagenTel8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel9")
                                        a.Name = "EliminarTel8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel7")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel7")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel8")
                            {
                                P.Name = "panelTel7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel8")
                                        a.Name = "lblTel7";

                                    if (a is Label && a.Name == "labelTel8")
                                        a.Name = "labelTel7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel8")
                                        a.Name = "TexboxTel7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel8")
                                        a.Name = "TexTel7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel8")
                                        a.Name = "imagenTel7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel8")
                                        a.Name = "EliminarTel7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel9")
                            {
                                P.Name = "panelTel8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel9")
                                        a.Name = "lblTel8";

                                    if (a is Label && a.Name == "lTel9")
                                        a.Name = "labelTel8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel9")
                                        a.Name = "TexboxTel8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel9")
                                        a.Name = "TexTel8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel9")
                                        a.Name = "imagenTel8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel9")
                                        a.Name = "EliminarTel8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel8")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel8")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel9")
                            {
                                P.Name = "panelTel8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel9")
                                        a.Name = "lblTel8";

                                    if (a is Label && a.Name == "lTel9")
                                        a.Name = "labelTel8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel9")
                                        a.Name = "TexboxTel8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel9")
                                        a.Name = "TexTel8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel9")
                                        a.Name = "imagenTel8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel9")
                                        a.Name = "EliminarTel8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel9")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel9")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel10")
                            {
                                P.Name = "panelTel9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTel10")
                                        a.Name = "lblTel9";

                                    if (a is Label && a.Name == "labelTel10")
                                        a.Name = "labelTel9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTel10")
                                        a.Name = "TexboxTel9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTel10")
                                        a.Name = "TexTel9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTel10")
                                        a.Name = "imagenTel9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTel10")
                                        a.Name = "EliminarTel9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTel10")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTel10")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {

                        }
                        Contador_pregunta--;
                    }

                }
            }
            else if (Text_tipo == "Texto Corto")
            {
                if (Eliminar.Name == "EliminarTextC1")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC1")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC2")
                            {
                                P.Name = "panelTextC1";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC2")
                                        a.Name = "lblTextC1";

                                    if (a is Label && a.Name == "labelTextC2")
                                        a.Name = "labelTextC1";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC2")
                                        a.Name = "TexboxTextC1";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC2")
                                        a.Name = "TexTextC1";

                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC2")
                                        a.Name = "imagenTextC1";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC2")
                                        a.Name = "EliminarTextC1";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC3")
                            {
                                P.Name = "panelTextC2";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC3")
                                        a.Name = "lblTextC2";

                                    if (a is Label && a.Name == "labelTextC3")
                                        a.Name = "labelTextC2";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC3")
                                        a.Name = "TexboxTextC2";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC3")
                                        a.Name = "TexTextC2";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC3")
                                        a.Name = "imagenTextC2";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC3")
                                        a.Name = "EliminarTextC2";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC4")
                            {
                                P.Name = "panelTextC3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC4")
                                        a.Name = "lblTextC3";

                                    if (a is Label && a.Name == "labelMaixtC4")
                                        a.Name = "labelTextC3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC4")
                                        a.Name = "TexboxTextC3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC4")
                                        a.Name = "TexTextC3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC4")
                                        a.Name = "imagenTextC3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC4")
                                        a.Name = "EliminarTextC3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC5")
                            {
                                P.Name = "panelTextC4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC5")
                                        a.Name = "lblTextC4";

                                    if (a is Label && a.Name == "labelTextC5")
                                        a.Name = "labelTextC4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC5")
                                        a.Name = "TexboxTextC4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC5")
                                        a.Name = "TexTextC4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC5")
                                        a.Name = "imagenTextC4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC5")
                                        a.Name = "EliminarTextC4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC6")
                            {
                                P.Name = "panelTextC5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC6")
                                        a.Name = "lblTextC5";

                                    if (a is Label && a.Name == "labelTextC6")
                                        a.Name = "labelTextC5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC6")
                                        a.Name = "TexboxTextC5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC6")
                                        a.Name = "TexTextC5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC6")
                                        a.Name = "imagenTextC5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC6")
                                        a.Name = "EliminarTextC5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextC6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC7")
                                        a.Name = "lblTextC6";

                                    if (a is Label && a.Name == "labelTextC7")
                                        a.Name = "labelTextC6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC7")
                                        a.Name = "TexboxTextC6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC7")
                                        a.Name = "TexTextC6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC7")
                                        a.Name = "imagenTextC6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC7")
                                        a.Name = "EliminarTextC6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC8")
                            {
                                P.Name = "panelTextC7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC8")
                                        a.Name = "lblTextC7";

                                    if (a is Label && a.Name == "labelTextC8")
                                        a.Name = "labelTextC7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC8")
                                        a.Name = "TexboxTextC7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC8")
                                        a.Name = "TexTextC7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC8")
                                        a.Name = "imagenTextC7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC8")
                                        a.Name = "EliminarTextC7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC9")
                            {
                                P.Name = "panelTextC8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC9")
                                        a.Name = "lblTextC8";

                                    if (a is Label && a.Name == "lTextC9")
                                        a.Name = "labelTextC8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC9")
                                        a.Name = "TexboxTextC8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC9")
                                        a.Name = "TexTextC8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC9")
                                        a.Name = "imagenTextC8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC9")
                                        a.Name = "EliminarTextC8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextC2")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC2")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC3")
                            {
                                P.Name = "panelTextC2";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC3")
                                        a.Name = "lblTextC2";

                                    if (a is Label && a.Name == "labelTextC3")
                                        a.Name = "labelTextC2";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC3")
                                        a.Name = "TexboxTextC2";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC3")
                                        a.Name = "TexTextC2";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC3")
                                        a.Name = "imagenTextC2";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC3")
                                        a.Name = "EliminarTextC2";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC4")
                            {
                                P.Name = "panelTextC3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC4")
                                        a.Name = "lblTextC3";

                                    if (a is Label && a.Name == "labelMaixtC4")
                                        a.Name = "labelTextC3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC4")
                                        a.Name = "TexboxTextC3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC4")
                                        a.Name = "TexTextC3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC4")
                                        a.Name = "imagenTextC3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC4")
                                        a.Name = "EliminarTextC3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC5")
                            {
                                P.Name = "panelTextC4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC5")
                                        a.Name = "lblTextC4";

                                    if (a is Label && a.Name == "labelTextC5")
                                        a.Name = "labelTextC4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC5")
                                        a.Name = "TexboxTextC4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC5")
                                        a.Name = "TexTextC4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC5")
                                        a.Name = "imagenTextC4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC5")
                                        a.Name = "EliminarTextC4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC6")
                            {
                                P.Name = "panelTextC5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC6")
                                        a.Name = "lblTextC5";

                                    if (a is Label && a.Name == "labelTextC6")
                                        a.Name = "labelTextC5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC6")
                                        a.Name = "TexboxTextC5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC6")
                                        a.Name = "TexTextC5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC6")
                                        a.Name = "imagenTextC5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC6")
                                        a.Name = "EliminarTextC5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextC6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC7")
                                        a.Name = "lblTextC6";

                                    if (a is Label && a.Name == "labelTextC7")
                                        a.Name = "labelTextC6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC7")
                                        a.Name = "TexboxTextC6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC7")
                                        a.Name = "TexTextC6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC7")
                                        a.Name = "imagenTextC6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC7")
                                        a.Name = "EliminarTextC6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC8")
                            {
                                P.Name = "panelTextC7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC8")
                                        a.Name = "lblTextC7";

                                    if (a is Label && a.Name == "labelTextC8")
                                        a.Name = "labelTextC7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC8")
                                        a.Name = "TexboxTextC7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC8")
                                        a.Name = "TexTextC7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC8")
                                        a.Name = "imagenTextC7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC8")
                                        a.Name = "EliminarTextC7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC9")
                            {
                                P.Name = "panelTextC8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC9")
                                        a.Name = "lblTextC8";

                                    if (a is Label && a.Name == "lTextC9")
                                        a.Name = "labelTextC8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC9")
                                        a.Name = "TexboxTextC8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC9")
                                        a.Name = "TexTextC8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC9")
                                        a.Name = "imagenTextC8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC9")
                                        a.Name = "EliminarTextC8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }
                }
                else if (Eliminar.Name == "EliminarTextC3")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC3")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC4")
                            {
                                P.Name = "panelTextC3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC4")
                                        a.Name = "lblTextC3";

                                    if (a is Label && a.Name == "labelMaixtC4")
                                        a.Name = "labelTextC3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC4")
                                        a.Name = "TexboxTextC3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC4")
                                        a.Name = "TexTextC3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC4")
                                        a.Name = "imagenTextC3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC4")
                                        a.Name = "EliminarTextC3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC5")
                            {
                                P.Name = "panelTextC4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC5")
                                        a.Name = "lblTextC4";

                                    if (a is Label && a.Name == "labelTextC5")
                                        a.Name = "labelTextC4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC5")
                                        a.Name = "TexboxTextC4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC5")
                                        a.Name = "TexTextC4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC5")
                                        a.Name = "imagenTextC4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC5")
                                        a.Name = "EliminarTextC4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC6")
                            {
                                P.Name = "panelTextC5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC6")
                                        a.Name = "lblTextC5";

                                    if (a is Label && a.Name == "labelTextC6")
                                        a.Name = "labelTextC5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC6")
                                        a.Name = "TexboxTextC5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC6")
                                        a.Name = "TexTextC5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC6")
                                        a.Name = "imagenTextC5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC6")
                                        a.Name = "EliminarTextC5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextC6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC7")
                                        a.Name = "lblTextC6";

                                    if (a is Label && a.Name == "labelTextC7")
                                        a.Name = "labelTextC6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC7")
                                        a.Name = "TexboxTextC6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC7")
                                        a.Name = "TexTextC6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC7")
                                        a.Name = "imagenTextC6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC7")
                                        a.Name = "EliminarTextC6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC8")
                            {
                                P.Name = "panelTextC7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC8")
                                        a.Name = "lblTextC7";

                                    if (a is Label && a.Name == "labelTextC8")
                                        a.Name = "labelTextC7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC8")
                                        a.Name = "TexboxTextC7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC8")
                                        a.Name = "TexTextC7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC8")
                                        a.Name = "imagenTextC7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC8")
                                        a.Name = "EliminarTextC7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC9")
                            {
                                P.Name = "panelTextC8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC9")
                                        a.Name = "lblTextC8";

                                    if (a is Label && a.Name == "lTextC9")
                                        a.Name = "labelTextC8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC9")
                                        a.Name = "TexboxTextC8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC9")
                                        a.Name = "TexTextC8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC9")
                                        a.Name = "imagenTextC8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC9")
                                        a.Name = "EliminarTextC8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }
                }
                else if (Eliminar.Name == "EliminarTextC4")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC4")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC5")
                            {
                                P.Name = "panelTextC4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC5")
                                        a.Name = "lblTextC4";

                                    if (a is Label && a.Name == "labelTextC5")
                                        a.Name = "labelTextC4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC5")
                                        a.Name = "TexboxTextC4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC5")
                                        a.Name = "TexTextC4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC5")
                                        a.Name = "imagenTextC4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC5")
                                        a.Name = "EliminarTextC4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC6")
                            {
                                P.Name = "panelTextC5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC6")
                                        a.Name = "lblTextC5";

                                    if (a is Label && a.Name == "labelTextC6")
                                        a.Name = "labelTextC5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC6")
                                        a.Name = "TexboxTextC5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC6")
                                        a.Name = "TexTextC5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC6")
                                        a.Name = "imagenTextC5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC6")
                                        a.Name = "EliminarTextC5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextC6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC7")
                                        a.Name = "lblTextC6";

                                    if (a is Label && a.Name == "labelTextC7")
                                        a.Name = "labelTextC6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC7")
                                        a.Name = "TexboxTextC6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC7")
                                        a.Name = "TexTextC6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC7")
                                        a.Name = "imagenTextC6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC7")
                                        a.Name = "EliminarTextC6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC8")
                            {
                                P.Name = "panelTextC7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC8")
                                        a.Name = "lblTextC7";

                                    if (a is Label && a.Name == "labelTextC8")
                                        a.Name = "labelTextC7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC8")
                                        a.Name = "TexboxTextC7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC8")
                                        a.Name = "TexTextC7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC8")
                                        a.Name = "imagenTextC7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC8")
                                        a.Name = "EliminarTextC7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC9")
                            {
                                P.Name = "panelTextC8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC9")
                                        a.Name = "lblTextC8";

                                    if (a is Label && a.Name == "lTextC9")
                                        a.Name = "labelTextC8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC9")
                                        a.Name = "TexboxTextC8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC9")
                                        a.Name = "TexTextC8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC9")
                                        a.Name = "imagenTextC8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC9")
                                        a.Name = "EliminarTextC8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }
                }
                else if (Eliminar.Name == "EliminarTextC5")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC5")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC6")
                            {
                                P.Name = "panelTextC5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC6")
                                        a.Name = "lblTextC5";

                                    if (a is Label && a.Name == "labelTextC6")
                                        a.Name = "labelTextC5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC6")
                                        a.Name = "TexboxTextC5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC6")
                                        a.Name = "TexTextC5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC6")
                                        a.Name = "imagenTextC5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC6")
                                        a.Name = "EliminarTextC5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextC6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC7")
                                        a.Name = "lblTextC6";

                                    if (a is Label && a.Name == "labelTextC7")
                                        a.Name = "labelTextC6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC7")
                                        a.Name = "TexboxTextC6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC7")
                                        a.Name = "TexTextC6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC7")
                                        a.Name = "imagenTextC6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC7")
                                        a.Name = "EliminarTextC6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC8")
                            {
                                P.Name = "panelTextC7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC8")
                                        a.Name = "lblTextC7";

                                    if (a is Label && a.Name == "labelTextC8")
                                        a.Name = "labelTextC7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC8")
                                        a.Name = "TexboxTextC7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC8")
                                        a.Name = "TexTextC7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC8")
                                        a.Name = "imagenTextC7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC8")
                                        a.Name = "EliminarTextC7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC9")
                            {
                                P.Name = "panelTextC8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC9")
                                        a.Name = "lblTextC8";

                                    if (a is Label && a.Name == "lTextC9")
                                        a.Name = "labelTextC8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC9")
                                        a.Name = "TexboxTextC8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC9")
                                        a.Name = "TexTextC8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC9")
                                        a.Name = "imagenTextC8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC9")
                                        a.Name = "EliminarTextC8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }
                }
                else if (Eliminar.Name == "EliminarTextC6")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC6")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextC6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC7")
                                        a.Name = "lblTextC6";

                                    if (a is Label && a.Name == "labelTextC7")
                                        a.Name = "labelTextC6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC7")
                                        a.Name = "TexboxTextC6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC7")
                                        a.Name = "TexTextC6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC7")
                                        a.Name = "imagenTextC6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC7")
                                        a.Name = "EliminarTextC6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC8")
                            {
                                P.Name = "panelTextC7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC8")
                                        a.Name = "lblTextC7";

                                    if (a is Label && a.Name == "labelTextC8")
                                        a.Name = "labelTextC7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC8")
                                        a.Name = "TexboxTextC7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC8")
                                        a.Name = "TexTextC7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC8")
                                        a.Name = "imagenTextC7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC8")
                                        a.Name = "EliminarTextC7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC9")
                            {
                                P.Name = "panelTextC8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC9")
                                        a.Name = "lblTextC8";

                                    if (a is Label && a.Name == "lTextC9")
                                        a.Name = "labelTextC8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC9")
                                        a.Name = "TexboxTextC8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC9")
                                        a.Name = "TexTextC8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC9")
                                        a.Name = "imagenTextC8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC9")
                                        a.Name = "EliminarTextC8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }
                }
                else if (Eliminar.Name == "EliminarTextC7")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC7")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC8")
                            {
                                P.Name = "panelTextC7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC8")
                                        a.Name = "lblTextC7";

                                    if (a is Label && a.Name == "labelTextC8")
                                        a.Name = "labelTextC7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC8")
                                        a.Name = "TexboxTextC7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC8")
                                        a.Name = "TexTextC7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC8")
                                        a.Name = "imagenTextC7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC8")
                                        a.Name = "EliminarTextC7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC9")
                            {
                                P.Name = "panelTextC8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC9")
                                        a.Name = "lblTextC8";

                                    if (a is Label && a.Name == "lTextC9")
                                        a.Name = "labelTextC8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC9")
                                        a.Name = "TexboxTextC8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC9")
                                        a.Name = "TexTextC8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC9")
                                        a.Name = "imagenTextC8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC9")
                                        a.Name = "EliminarTextC8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }
                }
                else if (Eliminar.Name == "EliminarTextC8")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC8")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC9")
                            {
                                P.Name = "panelTextC8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC9")
                                        a.Name = "lblTextC8";

                                    if (a is Label && a.Name == "lTextC9")
                                        a.Name = "labelTextC8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC9")
                                        a.Name = "TexboxTextC8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC9")
                                        a.Name = "TexTextC8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC9")
                                        a.Name = "imagenTextC8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC9")
                                        a.Name = "EliminarTextC8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }
                }
                else if (Eliminar.Name == "EliminarTextC9")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC9")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC10")
                            {
                                P.Name = "panelTextC9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextC10")
                                        a.Name = "lblTextC9";

                                    if (a is Label && a.Name == "labelTextC10")
                                        a.Name = "labelTextC9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextC10")
                                        a.Name = "TexboxTextC9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextC10")
                                        a.Name = "TexTextC9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextC10")
                                        a.Name = "imagenTextC9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextC10")
                                        a.Name = "EliminarTextC9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }
                }
                else if (Eliminar.Name == "EliminarTextC10")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC10")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {

                        }
                        Contador_pregunta--;
                    }
                }
            }
            else if (Text_tipo == "Texto Largo")
            {
                if (Eliminar.Name == "EliminarTextL1")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL1")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL2")
                            {
                                P.Name = "panelTextL1";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL2")
                                        a.Name = "lblTextL1";

                                    if (a is Label && a.Name == "labelTextL2")
                                        a.Name = "labelTextL1";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL2")
                                        a.Name = "TexboxTextL1";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL2")
                                        a.Name = "TexTextL1";

                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL2")
                                        a.Name = "imagenTextL1";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL2")
                                        a.Name = "EliminarTextL1";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL3")
                            {
                                P.Name = "panelTextL2";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL3")
                                        a.Name = "lblTextL2";

                                    if (a is Label && a.Name == "labelTextL3")
                                        a.Name = "labelTextL2";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL3")
                                        a.Name = "TexboxTextL2";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL3")
                                        a.Name = "TexTextL2";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL3")
                                        a.Name = "imagenTextL2";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL3")
                                        a.Name = "EliminarTextL2";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL4")
                            {
                                P.Name = "panelTextL3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL4")
                                        a.Name = "lblTextL3";

                                    if (a is Label && a.Name == "labelMaixtL4")
                                        a.Name = "labelTextL3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL4")
                                        a.Name = "TexboxTextL3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL4")
                                        a.Name = "TexTextL3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL4")
                                        a.Name = "imagenTextL3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL4")
                                        a.Name = "EliminarTextL3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL5")
                            {
                                P.Name = "panelTextC4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL5")
                                        a.Name = "lblTextL4";

                                    if (a is Label && a.Name == "labelTextL5")
                                        a.Name = "labelTextL4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL5")
                                        a.Name = "TexboxTextL4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL5")
                                        a.Name = "TexTextL4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL5")
                                        a.Name = "imagenTextL4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL5")
                                        a.Name = "EliminarTextL4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL6")
                            {
                                P.Name = "panelTextL5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL6")
                                        a.Name = "lblTextL5";

                                    if (a is Label && a.Name == "labelTextL6")
                                        a.Name = "labelTextL5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL6")
                                        a.Name = "TexboxTextL5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL6")
                                        a.Name = "TexTextL5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL6")
                                        a.Name = "imagenTextL5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL6")
                                        a.Name = "EliminarTextL5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextL6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL7")
                                        a.Name = "lblTextL6";

                                    if (a is Label && a.Name == "labelTextL7")
                                        a.Name = "labelTextL6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL7")
                                        a.Name = "TexboxTextL6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL7")
                                        a.Name = "TexTextL6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL7")
                                        a.Name = "imagenTextL6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL7")
                                        a.Name = "EliminarTextL6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL8")
                            {
                                P.Name = "panelTextL7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL8")
                                        a.Name = "lblTextL7";

                                    if (a is Label && a.Name == "labelTextL8")
                                        a.Name = "labelTextL7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL8")
                                        a.Name = "TexboxTextL7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL8")
                                        a.Name = "TexTextL7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL8")
                                        a.Name = "imagenTextL7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL8")
                                        a.Name = "EliminarTextL7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL9")
                            {
                                P.Name = "panelTextL8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL9")
                                        a.Name = "lblTextL8";

                                    if (a is Label && a.Name == "lTextL9")
                                        a.Name = "labelTextL8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL9")
                                        a.Name = "TexboxTextL8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL9")
                                        a.Name = "TexTextL8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL9")
                                        a.Name = "imagenTextL8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL9")
                                        a.Name = "EliminarTextL8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL2")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL2")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {

                            if (P is PanelRedondeado && P.Name == "panelTextL3")
                            {
                                P.Name = "panelTextL2";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL3")
                                        a.Name = "lblTextL2";

                                    if (a is Label && a.Name == "labelTextL3")
                                        a.Name = "labelTextL2";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL3")
                                        a.Name = "TexboxTextL2";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL3")
                                        a.Name = "TexTextL2";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL3")
                                        a.Name = "imagenTextL2";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL3")
                                        a.Name = "EliminarTextL2";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL4")
                            {
                                P.Name = "panelTextL3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL4")
                                        a.Name = "lblTextL3";

                                    if (a is Label && a.Name == "labelMaixtL4")
                                        a.Name = "labelTextL3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL4")
                                        a.Name = "TexboxTextL3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL4")
                                        a.Name = "TexTextL3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL4")
                                        a.Name = "imagenTextL3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL4")
                                        a.Name = "EliminarTextL3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL5")
                            {
                                P.Name = "panelTextC4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL5")
                                        a.Name = "lblTextL4";

                                    if (a is Label && a.Name == "labelTextL5")
                                        a.Name = "labelTextL4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL5")
                                        a.Name = "TexboxTextL4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL5")
                                        a.Name = "TexTextL4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL5")
                                        a.Name = "imagenTextL4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL5")
                                        a.Name = "EliminarTextL4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL6")
                            {
                                P.Name = "panelTextL5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL6")
                                        a.Name = "lblTextL5";

                                    if (a is Label && a.Name == "labelTextL6")
                                        a.Name = "labelTextL5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL6")
                                        a.Name = "TexboxTextL5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL6")
                                        a.Name = "TexTextL5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL6")
                                        a.Name = "imagenTextL5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL6")
                                        a.Name = "EliminarTextL5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextL6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL7")
                                        a.Name = "lblTextL6";

                                    if (a is Label && a.Name == "labelTextL7")
                                        a.Name = "labelTextL6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL7")
                                        a.Name = "TexboxTextL6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL7")
                                        a.Name = "TexTextL6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL7")
                                        a.Name = "imagenTextL6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL7")
                                        a.Name = "EliminarTextL6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL8")
                            {
                                P.Name = "panelTextL7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL8")
                                        a.Name = "lblTextL7";

                                    if (a is Label && a.Name == "labelTextL8")
                                        a.Name = "labelTextL7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL8")
                                        a.Name = "TexboxTextL7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL8")
                                        a.Name = "TexTextL7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL8")
                                        a.Name = "imagenTextL7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL8")
                                        a.Name = "EliminarTextL7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL9")
                            {
                                P.Name = "panelTextL8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL9")
                                        a.Name = "lblTextL8";

                                    if (a is Label && a.Name == "lTextL9")
                                        a.Name = "labelTextL8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL9")
                                        a.Name = "TexboxTextL8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL9")
                                        a.Name = "TexTextL8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL9")
                                        a.Name = "imagenTextL8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL9")
                                        a.Name = "EliminarTextL8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL3")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL3")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL4")
                            {
                                P.Name = "panelTextL3";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL4")
                                        a.Name = "lblTextL3";

                                    if (a is Label && a.Name == "labelMaixtL4")
                                        a.Name = "labelTextL3";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL4")
                                        a.Name = "TexboxTextL3";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL4")
                                        a.Name = "TexTextL3";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL4")
                                        a.Name = "imagenTextL3";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL4")
                                        a.Name = "EliminarTextL3";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL5")
                            {
                                P.Name = "panelTextC4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL5")
                                        a.Name = "lblTextL4";

                                    if (a is Label && a.Name == "labelTextL5")
                                        a.Name = "labelTextL4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL5")
                                        a.Name = "TexboxTextL4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL5")
                                        a.Name = "TexTextL4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL5")
                                        a.Name = "imagenTextL4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL5")
                                        a.Name = "EliminarTextL4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL6")
                            {
                                P.Name = "panelTextL5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL6")
                                        a.Name = "lblTextL5";

                                    if (a is Label && a.Name == "labelTextL6")
                                        a.Name = "labelTextL5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL6")
                                        a.Name = "TexboxTextL5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL6")
                                        a.Name = "TexTextL5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL6")
                                        a.Name = "imagenTextL5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL6")
                                        a.Name = "EliminarTextL5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextL6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL7")
                                        a.Name = "lblTextL6";

                                    if (a is Label && a.Name == "labelTextL7")
                                        a.Name = "labelTextL6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL7")
                                        a.Name = "TexboxTextL6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL7")
                                        a.Name = "TexTextL6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL7")
                                        a.Name = "imagenTextL6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL7")
                                        a.Name = "EliminarTextL6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL8")
                            {
                                P.Name = "panelTextL7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL8")
                                        a.Name = "lblTextL7";

                                    if (a is Label && a.Name == "labelTextL8")
                                        a.Name = "labelTextL7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL8")
                                        a.Name = "TexboxTextL7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL8")
                                        a.Name = "TexTextL7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL8")
                                        a.Name = "imagenTextL7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL8")
                                        a.Name = "EliminarTextL7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL9")
                            {
                                P.Name = "panelTextL8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL9")
                                        a.Name = "lblTextL8";

                                    if (a is Label && a.Name == "lTextL9")
                                        a.Name = "labelTextL8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL9")
                                        a.Name = "TexboxTextL8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL9")
                                        a.Name = "TexTextL8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL9")
                                        a.Name = "imagenTextL8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL9")
                                        a.Name = "EliminarTextL8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL4")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL4")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL5")
                            {
                                P.Name = "panelTextC4";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL5")
                                        a.Name = "lblTextL4";

                                    if (a is Label && a.Name == "labelTextL5")
                                        a.Name = "labelTextL4";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL5")
                                        a.Name = "TexboxTextL4";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL5")
                                        a.Name = "TexTextL4";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL5")
                                        a.Name = "imagenTextL4";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL5")
                                        a.Name = "EliminarTextL4";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL6")
                            {
                                P.Name = "panelTextL5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL6")
                                        a.Name = "lblTextL5";

                                    if (a is Label && a.Name == "labelTextL6")
                                        a.Name = "labelTextL5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL6")
                                        a.Name = "TexboxTextL5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL6")
                                        a.Name = "TexTextL5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL6")
                                        a.Name = "imagenTextL5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL6")
                                        a.Name = "EliminarTextL5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextL6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL7")
                                        a.Name = "lblTextL6";

                                    if (a is Label && a.Name == "labelTextL7")
                                        a.Name = "labelTextL6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL7")
                                        a.Name = "TexboxTextL6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL7")
                                        a.Name = "TexTextL6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL7")
                                        a.Name = "imagenTextL6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL7")
                                        a.Name = "EliminarTextL6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL8")
                            {
                                P.Name = "panelTextL7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL8")
                                        a.Name = "lblTextL7";

                                    if (a is Label && a.Name == "labelTextL8")
                                        a.Name = "labelTextL7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL8")
                                        a.Name = "TexboxTextL7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL8")
                                        a.Name = "TexTextL7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL8")
                                        a.Name = "imagenTextL7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL8")
                                        a.Name = "EliminarTextL7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL9")
                            {
                                P.Name = "panelTextL8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL9")
                                        a.Name = "lblTextL8";

                                    if (a is Label && a.Name == "lTextL9")
                                        a.Name = "labelTextL8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL9")
                                        a.Name = "TexboxTextL8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL9")
                                        a.Name = "TexTextL8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL9")
                                        a.Name = "imagenTextL8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL9")
                                        a.Name = "EliminarTextL8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL5")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL5")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL6")
                            {
                                P.Name = "panelTextL5";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL6")
                                        a.Name = "lblTextL5";

                                    if (a is Label && a.Name == "labelTextL6")
                                        a.Name = "labelTextL5";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL6")
                                        a.Name = "TexboxTextL5";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL6")
                                        a.Name = "TexTextL5";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL6")
                                        a.Name = "imagenTextL5";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL6")
                                        a.Name = "EliminarTextL5";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextL6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL7")
                                        a.Name = "lblTextL6";

                                    if (a is Label && a.Name == "labelTextL7")
                                        a.Name = "labelTextL6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL7")
                                        a.Name = "TexboxTextL6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL7")
                                        a.Name = "TexTextL6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL7")
                                        a.Name = "imagenTextL6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL7")
                                        a.Name = "EliminarTextL6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL8")
                            {
                                P.Name = "panelTextL7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL8")
                                        a.Name = "lblTextL7";

                                    if (a is Label && a.Name == "labelTextL8")
                                        a.Name = "labelTextL7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL8")
                                        a.Name = "TexboxTextL7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL8")
                                        a.Name = "TexTextL7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL8")
                                        a.Name = "imagenTextL7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL8")
                                        a.Name = "EliminarTextL7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL9")
                            {
                                P.Name = "panelTextL8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL9")
                                        a.Name = "lblTextL8";

                                    if (a is Label && a.Name == "lTextL9")
                                        a.Name = "labelTextL8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL9")
                                        a.Name = "TexboxTextL8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL9")
                                        a.Name = "TexTextL8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL9")
                                        a.Name = "imagenTextL8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL9")
                                        a.Name = "EliminarTextL8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL6")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL6")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextC7")
                            {
                                P.Name = "panelTextL6";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL7")
                                        a.Name = "lblTextL6";

                                    if (a is Label && a.Name == "labelTextL7")
                                        a.Name = "labelTextL6";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL7")
                                        a.Name = "TexboxTextL6";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL7")
                                        a.Name = "TexTextL6";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL7")
                                        a.Name = "imagenTextL6";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL7")
                                        a.Name = "EliminarTextL6";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL8")
                            {
                                P.Name = "panelTextL7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL8")
                                        a.Name = "lblTextL7";

                                    if (a is Label && a.Name == "labelTextL8")
                                        a.Name = "labelTextL7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL8")
                                        a.Name = "TexboxTextL7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL8")
                                        a.Name = "TexTextL7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL8")
                                        a.Name = "imagenTextL7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL8")
                                        a.Name = "EliminarTextL7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL9")
                            {
                                P.Name = "panelTextL8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL9")
                                        a.Name = "lblTextL8";

                                    if (a is Label && a.Name == "lTextL9")
                                        a.Name = "labelTextL8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL9")
                                        a.Name = "TexboxTextL8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL9")
                                        a.Name = "TexTextL8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL9")
                                        a.Name = "imagenTextL8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL9")
                                        a.Name = "EliminarTextL8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL7")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL7")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL8")
                            {
                                P.Name = "panelTextL7";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL8")
                                        a.Name = "lblTextL7";

                                    if (a is Label && a.Name == "labelTextL8")
                                        a.Name = "labelTextL7";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL8")
                                        a.Name = "TexboxTextL7";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL8")
                                        a.Name = "TexTextL7";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL8")
                                        a.Name = "imagenTextL7";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL8")
                                        a.Name = "EliminarTextL7";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL9")
                            {
                                P.Name = "panelTextL8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL9")
                                        a.Name = "lblTextL8";

                                    if (a is Label && a.Name == "lTextL9")
                                        a.Name = "labelTextL8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL9")
                                        a.Name = "TexboxTextL8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL9")
                                        a.Name = "TexTextL8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL9")
                                        a.Name = "imagenTextL8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL9")
                                        a.Name = "EliminarTextL8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL8")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL8")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL9")
                            {
                                P.Name = "panelTextL8";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL9")
                                        a.Name = "lblTextL8";

                                    if (a is Label && a.Name == "lTextL9")
                                        a.Name = "labelTextL8";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL9")
                                        a.Name = "TexboxTextL8";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL9")
                                        a.Name = "TexTextL8";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL9")
                                        a.Name = "imagenTextL8";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL9")
                                        a.Name = "EliminarTextL8";
                                }
                            }
                            else if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL9")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL9")
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
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL10")
                            {
                                P.Name = "panelTextL9";
                                foreach (var a in P.Controls.OfType<Label>())
                                {
                                    if (a is Label && a.Name == "lblTextL10")
                                        a.Name = "lblTextL9";

                                    if (a is Label && a.Name == "labelTextL10")
                                        a.Name = "labelTextL9";

                                }
                                foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                                {
                                    if (a is BunifuMaterialTextbox && a.Name == "TexboxTextL10")
                                        a.Name = "TexboxTextL9";

                                    if (a is BunifuMaterialTextbox && a.Name == "TexTextL10")
                                        a.Name = "TexTextL9";
                                }

                                foreach (var a in P.Controls.OfType<PictureBox>())
                                {
                                    if (a is PictureBox && a.Name == "imagenTextL10")
                                        a.Name = "imagenTextL9";
                                }

                                foreach (var a in P.Controls.OfType<BunifuImageButton>())
                                {
                                    if (a is BunifuImageButton && a.Name == "EliminarTextL10")
                                        a.Name = "EliminarTextL9";
                                }
                            }
                        }
                        Contador_pregunta--;
                    }

                }
                else if (Eliminar.Name == "EliminarTextL10")
                {
                    DialogResult result = new DialogResult();
                    Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                    result = message.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                        {
                            if (P is PanelRedondeado && P.Name == "panelTextL10")
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
                        Contador_pregunta--;
                    }

                }
            }
        }
    }
}
