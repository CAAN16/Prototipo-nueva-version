using Bunifu.Framework.UI;
using CapaPresentacion.Globales;
using Controles_personalizados;
using RJCodeAdvance.RJControls;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Controles_Dinamicos
{
    public class Pregunta_TipoNombre : Preguntas
    {
        #region Atributos Primarios
        private BunifuMaterialTextbox tex2;
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

        
        protected BunifuMaterialTextbox Tex2 { get => tex2; set => tex2 = value; }
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
        private string apellidos;
        private string text_apellidos;
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


        protected string Apellidos { get => apellidos; set => apellidos = value; }
        protected string Text_apellidos { get => text_apellidos; set => text_apellidos = value; }
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


        public Pregunta_TipoNombre(string nombre_contenedor, string nombre_contador, int contador_pregunta, string nombre_pregunta, 
        string text_pregunta, string nombre_respuesta, string text_respuesta,string apellidos,string text_apellidos,
        string nombre_imagen, Image image, string nombre_tipo, 
        string text_tipo, string nombre_eliminar) : base(nombre_contenedor, nombre_contador, contador_pregunta, nombre_pregunta, 
        text_pregunta, nombre_respuesta, text_respuesta, nombre_imagen, image, nombre_tipo, text_tipo, nombre_eliminar)
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
            Apellidos = apellidos;
            Text_apellidos = text_apellidos;
        }

        public override void InicializarCampos()
        {
            Contenedor = new PanelRedondeado
            {
                Height = 267,
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

            Tex2 = new BunifuMaterialTextbox
            {
                Name = Apellidos + Contador_pregunta.ToString(),
                LineIdleColor = Color.White,
                LineFocusedColor = Color.FromArgb(26, 152, 34),
                LineMouseHoverColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 12),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(60, 132),
                Width = 665,
                Height = 43,
                Text = Text_apellidos,
                Enabled = false
            };

            Imagen = new PictureBox
            {
                Name = Nombre_imagen + Contador_pregunta.ToString(),
                Location = new Point(17, 220),
                Size = new Size(35, 35),
                Image = Image1,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Tipo = new Label
            {
                Name = Nombre_tipo + Contador_pregunta.ToString(),
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                Location = new Point(58, 228),
                Width = 200,
                Text = Text_tipo
            };

            Eliminar = new BunifuImageButton
            {
                Name = Nombre_eliminar + Contador_pregunta.ToString(),
                BackColor = Color.White,
                Image = Properties.Resources.trash_512px,
                Location = new Point(488, 220),
                Size = new Size(35, 35),
                SizeMode = PictureBoxSizeMode.Zoom,
                Zoom = 10,
                Enabled = false
            };

            Linea1 = new PanelRedondeado
            {
                BackColor = Color.LightGray,
                Location = new Point(538, 218),
                Size = new Size(2, 40)
            };
            Linea2 = new PanelRedondeado
            {
                BackColor = Color.LightGray,
                Location = new Point(15, 208),
                Size = new Size(700, 2)
            };
            Obligatoria = new Label
            {
                BackColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                Location = new Point(550, 227),
                Size = new Size(111, 24),
                Text = "Obligatoria"
            };
            ToggleButton = new RJToggleButton
            {
                BackColor = Color.White,
                Location = new Point(666, 227),
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
            Contenedor.Controls.Add(Imagen);
            Contenedor.Controls.Add(Tipo);
            Contenedor.Controls.Add(Eliminar);
            Contenedor.Controls.Add(linea1);
            Contenedor.Controls.Add(linea2);
            Contenedor.Controls.Add(Obligatoria);
            Contenedor.Controls.Add(ToggleButton);
            Contenedor.Controls.Add(Tex2);
            return Contenedor;
        }

        public override BunifuImageButton BotonEliminar()
        {
            return Eliminar;
        }

        public override void EliminarPregunta(BunifuImageButton EliminarNombreC, Panel panelhijo)
        {
            if (EliminarNombreC.Name == "EliminarNombreC1")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC1")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC2")
                        {
                            P.Name = "panelNombreC1";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl2")
                                    a.Name = "lbl1";

                                if (a is Label && a.Name == "label2")
                                    a.Name = "label1";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox2")
                                    a.Name = "Texbox1";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex2")
                                    a.Name = "Tex1";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex22")
                                    a.Name = "Tex21";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen2")
                                    a.Name = "imagen1";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC2")
                                    a.Name = "EliminarNombreC1";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC3")
                        {
                            P.Name = "panelNombreC2";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl3")
                                    a.Name = "lbl2";

                                if (a is Label && a.Name == "label3")
                                    a.Name = "label2";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox3")
                                    a.Name = "Texbox2";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex3")
                                    a.Name = "Tex2";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex23")
                                    a.Name = "Tex22";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen3")
                                    a.Name = "imagen2";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC3")
                                    a.Name = "EliminarNombreC2";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC4")
                        {
                            P.Name = "panelNombreC3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl4")
                                    a.Name = "lbl3";

                                if (a is Label && a.Name == "label4")
                                    a.Name = "label3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox4")
                                    a.Name = "Texbox3";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex4")
                                    a.Name = "Tex3";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex24")
                                    a.Name = "Tex23";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen4")
                                    a.Name = "imagen3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC4")
                                    a.Name = "EliminarNombreC3";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC5")
                        {
                            P.Name = "panelNombreC4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl5")
                                    a.Name = "lbl4";

                                if (a is Label && a.Name == "label5")
                                    a.Name = "label4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox5")
                                    a.Name = "Texbox4";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex5")
                                    a.Name = "Tex4";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex25")
                                    a.Name = "Tex24";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen5")
                                    a.Name = "imagen4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC5")
                                    a.Name = "EliminarNombreC4";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC6")
                        {
                            P.Name = "panelNombreC5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl6")
                                    a.Name = "lbl5";

                                if (a is Label && a.Name == "label6")
                                    a.Name = "label5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox6")
                                    a.Name = "Texbox5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex6")
                                    a.Name = "Tex5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex26")
                                    a.Name = "Tex25";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen6")
                                    a.Name = "imagen5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC6")
                                    a.Name = "EliminarNombreC5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC7")
                        {
                            P.Name = "panelNombreC6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl7")
                                    a.Name = "lbl6";

                                if (a is Label && a.Name == "label7")
                                    a.Name = "label6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox7")
                                    a.Name = "Texbox6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex7")
                                    a.Name = "Tex6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex27")
                                    a.Name = "Tex26";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen7")
                                    a.Name = "imagen6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC7")
                                    a.Name = "EliminarNombreC6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC8")
                        {
                            P.Name = "panelNombreC7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl8")
                                    a.Name = "lbl7";

                                if (a is Label && a.Name == "label8")
                                    a.Name = "label7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox8")
                                    a.Name = "Texbox7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex8")
                                    a.Name = "Tex7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex28")
                                    a.Name = "Tex27";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen8")
                                    a.Name = "imagen7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC8")
                                    a.Name = "EliminarNombreC7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC9")
                        {
                            P.Name = "panelNombreC8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl9")
                                    a.Name = "lbl8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "label8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox9")
                                    a.Name = "Texbox8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex9")
                                    a.Name = "Tex8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex29")
                                    a.Name = "Tex28";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen9")
                                    a.Name = "imagen8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC9")
                                    a.Name = "EliminarNombreC8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC2")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC2")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC3")
                        {
                            P.Name = "panelNombreC2";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl3")
                                    a.Name = "lbl2";

                                if (a is Label && a.Name == "label3")
                                    a.Name = "label2";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox3")
                                    a.Name = "Texbox2";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex3")
                                    a.Name = "Tex2";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex23")
                                    a.Name = "Tex22";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen3")
                                    a.Name = "imagen2";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC3")
                                    a.Name = "EliminarNombreC2";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC4")
                        {
                            P.Name = "panelNombreC3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl4")
                                    a.Name = "lbl3";

                                if (a is Label && a.Name == "label4")
                                    a.Name = "label3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox4")
                                    a.Name = "Texbox3";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex4")
                                    a.Name = "Tex3";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex24")
                                    a.Name = "Tex23";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen4")
                                    a.Name = "imagen3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC4")
                                    a.Name = "EliminarNombreC3";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC5")
                        {
                            P.Name = "panelNombreC4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl5")
                                    a.Name = "lbl4";

                                if (a is Label && a.Name == "label5")
                                    a.Name = "label4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox5")
                                    a.Name = "Texbox4";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex5")
                                    a.Name = "Tex4";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex25")
                                    a.Name = "Tex24";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen5")
                                    a.Name = "imagen4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC5")
                                    a.Name = "EliminarNombreC4";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC6")
                        {
                            P.Name = "panelNombreC5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl6")
                                    a.Name = "lbl5";

                                if (a is Label && a.Name == "label6")
                                    a.Name = "label5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox6")
                                    a.Name = "Texbox5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex6")
                                    a.Name = "Tex5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex26")
                                    a.Name = "Tex25";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen6")
                                    a.Name = "imagen5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC6")
                                    a.Name = "EliminarNombreC5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC7")
                        {
                            P.Name = "panelNombreC6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl7")
                                    a.Name = "lbl6";

                                if (a is Label && a.Name == "label7")
                                    a.Name = "label6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox7")
                                    a.Name = "Texbox6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex7")
                                    a.Name = "Tex6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex27")
                                    a.Name = "Tex26";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen7")
                                    a.Name = "imagen6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC7")
                                    a.Name = "EliminarNombreC6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC8")
                        {
                            P.Name = "panelNombreC7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl8")
                                    a.Name = "lbl7";

                                if (a is Label && a.Name == "label8")
                                    a.Name = "label7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox8")
                                    a.Name = "Texbox7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex8")
                                    a.Name = "Tex7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex28")
                                    a.Name = "Tex27";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen8")
                                    a.Name = "imagen7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC8")
                                    a.Name = "EliminarNombreC7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC9")
                        {
                            P.Name = "panelNombreC8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl9")
                                    a.Name = "lbl8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "label8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox9")
                                    a.Name = "Texbox8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex9")
                                    a.Name = "Tex8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex29")
                                    a.Name = "Tex28";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen9")
                                    a.Name = "imagen8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC9")
                                    a.Name = "EliminarNombreC8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC3")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC3")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC4")
                        {
                            P.Name = "panelNombreC3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl4")
                                    a.Name = "lbl3";

                                if (a is Label && a.Name == "label4")
                                    a.Name = "label3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox4")
                                    a.Name = "Texbox3";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex4")
                                    a.Name = "Tex3";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex24")
                                    a.Name = "Tex23";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen4")
                                    a.Name = "imagen3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC4")
                                    a.Name = "EliminarNombreC3";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC5")
                        {
                            P.Name = "panelNombreC4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl5")
                                    a.Name = "lbl4";

                                if (a is Label && a.Name == "label5")
                                    a.Name = "label4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox5")
                                    a.Name = "Texbox4";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex5")
                                    a.Name = "Tex4";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex25")
                                    a.Name = "Tex24";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen5")
                                    a.Name = "imagen4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC5")
                                    a.Name = "EliminarNombreC4";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC6")
                        {
                            P.Name = "panelNombreC5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl6")
                                    a.Name = "lbl5";

                                if (a is Label && a.Name == "label6")
                                    a.Name = "label5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox6")
                                    a.Name = "Texbox5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex6")
                                    a.Name = "Tex5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex26")
                                    a.Name = "Tex25";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen6")
                                    a.Name = "imagen5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC6")
                                    a.Name = "EliminarNombreC5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC7")
                        {
                            P.Name = "panelNombreC6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl7")
                                    a.Name = "lbl6";

                                if (a is Label && a.Name == "label7")
                                    a.Name = "label6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox7")
                                    a.Name = "Texbox6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex7")
                                    a.Name = "Tex6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex27")
                                    a.Name = "Tex26";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen7")
                                    a.Name = "imagen6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC7")
                                    a.Name = "EliminarNombreC6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC8")
                        {
                            P.Name = "panelNombreC7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl8")
                                    a.Name = "lbl7";

                                if (a is Label && a.Name == "label8")
                                    a.Name = "label7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox8")
                                    a.Name = "Texbox7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex8")
                                    a.Name = "Tex7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex28")
                                    a.Name = "Tex27";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen8")
                                    a.Name = "imagen7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC8")
                                    a.Name = "EliminarNombreC7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC9")
                        {
                            P.Name = "panelNombreC8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl9")
                                    a.Name = "lbl8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "label8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox9")
                                    a.Name = "Texbox8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex9")
                                    a.Name = "Tex8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex29")
                                    a.Name = "Tex28";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen9")
                                    a.Name = "imagen8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC9")
                                    a.Name = "EliminarNombreC8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC4")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC4")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC5")
                        {
                            P.Name = "panelNombreC4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl5")
                                    a.Name = "lbl4";

                                if (a is Label && a.Name == "label5")
                                    a.Name = "label4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox5")
                                    a.Name = "Texbox4";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex5")
                                    a.Name = "Tex4";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex25")
                                    a.Name = "Tex24";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen5")
                                    a.Name = "imagen4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC5")
                                    a.Name = "EliminarNombreC4";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC6")
                        {
                            P.Name = "panelNombreC5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl6")
                                    a.Name = "lbl5";

                                if (a is Label && a.Name == "label6")
                                    a.Name = "label5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox6")
                                    a.Name = "Texbox5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex6")
                                    a.Name = "Tex5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex26")
                                    a.Name = "Tex25";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen6")
                                    a.Name = "imagen5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC6")
                                    a.Name = "EliminarNombreC5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC7")
                        {
                            P.Name = "panelNombreC6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl7")
                                    a.Name = "lbl6";

                                if (a is Label && a.Name == "label7")
                                    a.Name = "label6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox7")
                                    a.Name = "Texbox6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex7")
                                    a.Name = "Tex6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex27")
                                    a.Name = "Tex26";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen7")
                                    a.Name = "imagen6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC7")
                                    a.Name = "EliminarNombreC6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC8")
                        {
                            P.Name = "panelNombreC7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl8")
                                    a.Name = "lbl7";

                                if (a is Label && a.Name == "label8")
                                    a.Name = "label7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox8")
                                    a.Name = "Texbox7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex8")
                                    a.Name = "Tex7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex28")
                                    a.Name = "Tex27";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen8")
                                    a.Name = "imagen7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC8")
                                    a.Name = "EliminarNombreC7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC9")
                        {
                            P.Name = "panelNombreC8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl9")
                                    a.Name = "lbl8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "label8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox9")
                                    a.Name = "Texbox8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex9")
                                    a.Name = "Tex8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex29")
                                    a.Name = "Tex28";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen9")
                                    a.Name = "imagen8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC9")
                                    a.Name = "EliminarNombreC8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC5")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC5")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC6")
                        {
                            P.Name = "panelNombreC5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl6")
                                    a.Name = "lbl5";

                                if (a is Label && a.Name == "label6")
                                    a.Name = "label5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox6")
                                    a.Name = "Texbox5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex6")
                                    a.Name = "Tex5";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex26")
                                    a.Name = "Tex25";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen6")
                                    a.Name = "imagen5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC6")
                                    a.Name = "EliminarNombreC5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC7")
                        {
                            P.Name = "panelNombreC6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl7")
                                    a.Name = "lbl6";

                                if (a is Label && a.Name == "label7")
                                    a.Name = "label6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox7")
                                    a.Name = "Texbox6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex7")
                                    a.Name = "Tex6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex27")
                                    a.Name = "Tex26";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen7")
                                    a.Name = "imagen6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC7")
                                    a.Name = "EliminarNombreC6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC8")
                        {
                            P.Name = "panelNombreC7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl8")
                                    a.Name = "lbl7";

                                if (a is Label && a.Name == "label8")
                                    a.Name = "label7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox8")
                                    a.Name = "Texbox7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex8")
                                    a.Name = "Tex7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex28")
                                    a.Name = "Tex27";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen8")
                                    a.Name = "imagen7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC8")
                                    a.Name = "EliminarNombreC7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC9")
                        {
                            P.Name = "panelNombreC8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl9")
                                    a.Name = "lbl8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "label8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox9")
                                    a.Name = "Texbox8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex9")
                                    a.Name = "Tex8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex29")
                                    a.Name = "Tex28";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen9")
                                    a.Name = "imagen8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC9")
                                    a.Name = "EliminarNombreC8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC6")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC6")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC7")
                        {
                            P.Name = "panelNombreC6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl7")
                                    a.Name = "lbl6";

                                if (a is Label && a.Name == "label7")
                                    a.Name = "label6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox7")
                                    a.Name = "Texbox6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex7")
                                    a.Name = "Tex6";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex27")
                                    a.Name = "Tex26";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen7")
                                    a.Name = "imagen6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC7")
                                    a.Name = "EliminarNombreC6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC8")
                        {
                            P.Name = "panelNombreC7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl8")
                                    a.Name = "lbl7";

                                if (a is Label && a.Name == "label8")
                                    a.Name = "label7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox8")
                                    a.Name = "Texbox7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex8")
                                    a.Name = "Tex7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex28")
                                    a.Name = "Tex27";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen8")
                                    a.Name = "imagen7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC8")
                                    a.Name = "EliminarNombreC7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC9")
                        {
                            P.Name = "panelNombreC8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl9")
                                    a.Name = "lbl8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "label8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox9")
                                    a.Name = "Texbox8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex9")
                                    a.Name = "Tex8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex29")
                                    a.Name = "Tex28";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen9")
                                    a.Name = "imagen8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC9")
                                    a.Name = "EliminarNombreC8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC7")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC7")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC8")
                        {
                            P.Name = "panelNombreC7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl8")
                                    a.Name = "lbl7";

                                if (a is Label && a.Name == "label8")
                                    a.Name = "label7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox8")
                                    a.Name = "Texbox7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex8")
                                    a.Name = "Tex7";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex28")
                                    a.Name = "Tex27";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen8")
                                    a.Name = "imagen7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC8")
                                    a.Name = "EliminarNombreC7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC9")
                        {
                            P.Name = "panelNombreC8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl9")
                                    a.Name = "lbl8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "label8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox9")
                                    a.Name = "Texbox8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex9")
                                    a.Name = "Tex8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex29")
                                    a.Name = "Tex28";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen9")
                                    a.Name = "imagen8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC9")
                                    a.Name = "EliminarNombreC8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC8")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC8")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC9")
                        {
                            P.Name = "panelNombreC8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl9")
                                    a.Name = "lbl8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "label8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox9")
                                    a.Name = "Texbox8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex9")
                                    a.Name = "Tex8";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex29")
                                    a.Name = "Tex28";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen9")
                                    a.Name = "imagen8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC9")
                                    a.Name = "EliminarNombreC8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC9")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC9")
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
                        if (P is PanelRedondeado && P.Name == "panelNombreC10")
                        {
                            P.Name = "panelNombreC9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lbl10")
                                    a.Name = "lbl9";

                                if (a is Label && a.Name == "label10")
                                    a.Name = "label9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "Texbox10")
                                    a.Name = "Texbox9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex10")
                                    a.Name = "Tex9";

                                if (a is BunifuMaterialTextbox && a.Name == "Tex210")
                                    a.Name = "Tex29";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagen10")
                                    a.Name = "imagen9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarNombreC10")
                                    a.Name = "EliminarNombreC9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_NombreC--;
                }

            }
            else if (EliminarNombreC.Name == "EliminarNombreC10")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelNombreC10")
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
                    Obtener_Contadores.Total_NombreC--;
                }

            }
        }






    }
}
