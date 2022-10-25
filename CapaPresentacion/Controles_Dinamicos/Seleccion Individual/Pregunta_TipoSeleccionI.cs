using Bunifu.Framework.UI;
using CapaPresentacion.Globales;
using Controles_personalizados;
using RJCodeAdvance.RJControls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Controles_Dinamicos
{
    public class Pregunta_TipoSeleccionI
    {
        PanelRedondeado tempPanelPrincipal_SeleI;
        BunifuImageButton tempEliminarSeleI;
        RJButton tempButtonSeleI;
        BunifuImageButton tempEliminarOpcSeleI;
        AccionSecundaria_TipoSeleccionI EliminarOpcSeleI = new AccionSecundaria_TipoSeleccionI();

        public PanelRedondeado AgregarPregunta(Panel panelhijo, Color normalColor)
        {
            PanelRedondeado panelSeleccionI = new PanelRedondeado
            {
                Height = 180,
                Name = "panelSeleccionI" + Obtener_Contadores.Total_SeleI.ToString(),
                Dock = DockStyle.Top,
                BorderRadius = 24,
                Borderzise = 0
            };
            panelhijo.Controls.Add(panelSeleccionI);
            panelSeleccionI.BringToFront();

            Label lblSeleccionI = new Label
            {
                Name = "lblSeleccionI" + Obtener_Contadores.Total_SeleI.ToString(),
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                Size = new Size(28, 18),
                Location = new Point(10, 24),
                Text = Obtener_Contadores.Total_Preguntas.ToString()
            };
            panelSeleccionI.Controls.Add(lblSeleccionI);

            BunifuMaterialTextbox texboxSeleccionI = new BunifuMaterialTextbox
            {
                Name = "TexboxSeleccionI" + Obtener_Contadores.Total_SeleI.ToString(),
                LineIdleColor = Color.White,
                LineFocusedColor = normalColor,
                LineMouseHoverColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(40, 18),
                Width = 450,
                Text = "Escribe tu pregunta aquí"
            };
            panelSeleccionI.Controls.Add(texboxSeleccionI);

            RJRadioButton RadioSeleccionI = new RJRadioButton
            {
                Name = "Radio1",
                CheckedColor = normalColor,
                Location = new Point(39, 62),
                Size = new Size(21, 21),
                Enabled = false
            };
            panelSeleccionI.Controls.Add(RadioSeleccionI);

            BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
            {
                Name = "TexboxOpcciónSeleccionI1",
                LineIdleColor = Color.White,
                LineFocusedColor = normalColor,
                LineMouseHoverColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 10),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(60, 57),
                Width = 430,
                Text = "Opcción1"
            };
            panelSeleccionI.Controls.Add(TexboxOpcciónSeleccionI);

            RJButton buttonSeleccionI = new RJButton
            {
                Name = "buttonSeleccionI" + Obtener_Contadores.Total_SeleI.ToString(),
                BackColor = Color.White,
                BorderRadius = 6,
                BorderSize = 2,
                BorderColor = normalColor,
                ForeColor = Color.Black,
                Location = new Point(60, 95),
                Size = new Size(89, 25),
                Text = "Agregar campo"
            };
            //buttonSeleccionI.TextColor = Color.White;
            panelSeleccionI.Controls.Add(buttonSeleccionI);

            PictureBox imagenSeleccionI = new PictureBox
            {
                Name = "imagenSeleccionI" + Obtener_Contadores.Total_SeleI.ToString(),
                Location = new Point(17, 146),
                Size = new Size(26, 26),
                Image = Properties.Resources.check,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            panelSeleccionI.Controls.Add(imagenSeleccionI);

            Label labelSeleccionI = new Label
            {
                Name = "labelSeleccionI" + Obtener_Contadores.Total_SeleI.ToString(),
                Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                Location = new Point(55, 155),
                Size = new Size(122, 13),
                Text = "Selección Individual"
            };
            panelSeleccionI.Controls.Add(labelSeleccionI);


            BunifuImageButton EliminarSeleccionI = new BunifuImageButton
            {
                Name = "EliminarSeleccionI" + Obtener_Contadores.Total_SeleI.ToString(),
                BackColor = Color.White,
                Image = Properties.Resources.trash_512px,
                Location = new Point(340, 146),
                Size = new Size(26, 26),
                SizeMode = PictureBoxSizeMode.Zoom,
                Zoom = 10
            };
            panelSeleccionI.Controls.Add(EliminarSeleccionI);

            PanelRedondeado linea2 = new PanelRedondeado
            {
                BackColor = Color.LightGray,
                Location = new Point(15, 135),
                Size = new Size(500, 2)
            };
            panelSeleccionI.Controls.Add(linea2);

            PanelRedondeado linea = new PanelRedondeado
            {
                BackColor = Color.LightGray,
                Location = new Point(375, 143),
                Size = new Size(2, 30)
            };
            panelSeleccionI.Controls.Add(linea);

            Label Obligatoria = new Label
            {
                BackColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                Location = new Point(380, 152),
                Text = "Obligatoria",
                Size = new Size(78, 15)
            };
            panelSeleccionI.Controls.Add(Obligatoria);

            RJToggleButton ToggleButton = new RJToggleButton
            {
                BackColor = Color.White,
                Location = new Point(470, 152),
                OffBackColor = Color.Gray,
                OffToggleColor = Color.Gainsboro,
                OnBackColor = normalColor,
                OnToggleColor = Color.WhiteSmoke,
                MinimumSize = new Size(40, 19),
                Size = new Size(40, 19),
                Enabled = false
            };
            panelSeleccionI.Controls.Add(ToggleButton);

            Obtener_Contadores.Total_Preguntas++;
            Obtener_Contadores.Total_SeleI++;
            tempPanelPrincipal_SeleI = panelSeleccionI;
            tempEliminarSeleI = EliminarSeleccionI;
            tempButtonSeleI = buttonSeleccionI;
            return tempPanelPrincipal_SeleI;

        }

        public void ActivarPregunta(PanelRedondeado tempSeleI, Panel panelhijo, PanelRedondeado panelLateral)
        {
            panelLateral.Width = 7;
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Name = "panelLateral1";
            panelLateral.BorderRadius = 0;
            panelLateral.BackColor = Color.FromArgb(27, 102, 218);
            tempPanelPrincipal_SeleI = tempSeleI;
            if (tempSeleI.Name == "panelSeleccionI1")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI1")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI1")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI2")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI2")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI2")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI3")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI3")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI3")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI4")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI4")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI4")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI5")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI5")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI5")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI6")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI6")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI6")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI7")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI7")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI7")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI8")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI8")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI8")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI9")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI9")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI10")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI10")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
            else if (tempSeleI.Name == "panelSeleccionI11")
            {
                MessageBox.Show(tempSeleI.Name);
                foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                {
                    if (P is PanelRedondeado && P.Name != "panelSeleccionI11")
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

                            if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI11")
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
                if (!tempSeleI.Controls.OfType<PanelRedondeado>().Any(x => x.Name == "panelLateral1"))
                {
                    tempSeleI.Controls.Add(panelLateral);
                }
            }
        }

        public BunifuImageButton BotonEliminar()
        {
            return tempEliminarSeleI;
        }

        public BunifuImageButton BotonEliminarOpccion()
        {
            return tempEliminarOpcSeleI;
        }

        public RJButton BotonCampo()
        {
            return tempButtonSeleI;
        }

        public void EliminarPregunta(BunifuImageButton EliminarSeleI, Panel panelhijo)
        {
            if (EliminarSeleI.Name == "EliminarSeleccionI1")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI1")
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
                    ArreglosGlobales.PosicionSeleI[0] = 180;
                    ArreglosGlobales.PosicionSeleI[1] = 62;
                    ArreglosGlobales.PosicionSeleI[2] = 57;
                    ArreglosGlobales.PosicionSeleI[3] = 95;
                    ArreglosGlobales.PosicionSeleI[4] = 146;
                    ArreglosGlobales.PosicionSeleI[5] = 155;
                    ArreglosGlobales.PosicionSeleI[6] = 135;
                    ArreglosGlobales.PosicionSeleI[7] = 143;
                    ArreglosGlobales.PosicionSeleI[8] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI2")
                        {
                            P.Name = "panelSeleccionI1";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI2")
                                    a.Name = "lblSeleccionI1";

                                if (a is Label && a.Name == "labelSeleccionI2")
                                    a.Name = "labelSeleccionI1";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI2")
                                    a.Name = "TexboxSeleccionI1";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI2")
                                    a.Name = "TexSeleccionI1";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI2")
                                    a.Name = "imagenSeleccionI1";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI2")
                                    a.Name = "EliminarSeleccionI1";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI2")
                                    a.Name = "buttonSeleccionI1";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio2")
                                    a.Name = "Radio1";
                            }
                            ArreglosGlobales.PosicionSeleI[0] = ArreglosGlobales.PosicionSeleM[9];
                            ArreglosGlobales.PosicionSeleI[1] = ArreglosGlobales.PosicionSeleM[10];
                            ArreglosGlobales.PosicionSeleI[2] = ArreglosGlobales.PosicionSeleM[11];
                            ArreglosGlobales.PosicionSeleI[3] = ArreglosGlobales.PosicionSeleM[12];
                            ArreglosGlobales.PosicionSeleI[4] = ArreglosGlobales.PosicionSeleM[13];
                            ArreglosGlobales.PosicionSeleI[5] = ArreglosGlobales.PosicionSeleM[14];
                            ArreglosGlobales.PosicionSeleI[6] = ArreglosGlobales.PosicionSeleM[15];
                            ArreglosGlobales.PosicionSeleI[7] = ArreglosGlobales.PosicionSeleM[16];
                            ArreglosGlobales.PosicionSeleI[8] = ArreglosGlobales.PosicionSeleM[17];
                            ContSecundarioSeleI.ContadorR_SeleI = ContSecundarioSeleI.ContadorR_SeleI2;
                            ContSecundarioSeleI.ContadorR_SeleI2 = 2;
                            ArreglosGlobales.PosicionSeleI[9] = 180;
                            ArreglosGlobales.PosicionSeleI[10] = 62;
                            ArreglosGlobales.PosicionSeleI[11] = 57;
                            ArreglosGlobales.PosicionSeleI[12] = 95;
                            ArreglosGlobales.PosicionSeleI[13] = 146;
                            ArreglosGlobales.PosicionSeleI[14] = 155;
                            ArreglosGlobales.PosicionSeleI[15] = 135;
                            ArreglosGlobales.PosicionSeleI[16] = 143;
                            ArreglosGlobales.PosicionSeleI[17] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI3")
                        {
                            P.Name = "panelSeleccionI2";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI3")
                                    a.Name = "lblSeleccionI2";

                                if (a is Label && a.Name == "labelSeleccionI3")
                                    a.Name = "labelSeleccionI2";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI3")
                                    a.Name = "TexboxSeleccionI2";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI3")
                                    a.Name = "TexSeleccionI2";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI3")
                                    a.Name = "imagenSeleccionI2";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI3")
                                    a.Name = "EliminarSeleccionI2";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI3")
                                    a.Name = "buttonSeleccionI2";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio3")
                                    a.Name = "Radio2";
                            }

                            ArreglosGlobales.PosicionSeleI[9] = ArreglosGlobales.PosicionSeleI[18];
                            ArreglosGlobales.PosicionSeleI[10] = ArreglosGlobales.PosicionSeleI[19];
                            ArreglosGlobales.PosicionSeleI[11] = ArreglosGlobales.PosicionSeleI[20];
                            ArreglosGlobales.PosicionSeleI[12] = ArreglosGlobales.PosicionSeleI[21];
                            ArreglosGlobales.PosicionSeleI[13] = ArreglosGlobales.PosicionSeleI[22];
                            ArreglosGlobales.PosicionSeleI[14] = ArreglosGlobales.PosicionSeleI[23];
                            ArreglosGlobales.PosicionSeleI[15] = ArreglosGlobales.PosicionSeleI[24];
                            ArreglosGlobales.PosicionSeleI[16] = ArreglosGlobales.PosicionSeleI[25];
                            ArreglosGlobales.PosicionSeleI[17] = ArreglosGlobales.PosicionSeleI[26];
                            ContSecundarioSeleI.ContadorR_SeleI2 = ContSecundarioSeleI.ContadorR_SeleI3;
                            ContSecundarioSeleI.ContadorR_SeleI3 = 2;
                            ArreglosGlobales.PosicionSeleI[18] = 180;
                            ArreglosGlobales.PosicionSeleI[19] = 62;
                            ArreglosGlobales.PosicionSeleI[20] = 57;
                            ArreglosGlobales.PosicionSeleI[21] = 95;
                            ArreglosGlobales.PosicionSeleI[22] = 146;
                            ArreglosGlobales.PosicionSeleI[23] = 155;
                            ArreglosGlobales.PosicionSeleI[24] = 135;
                            ArreglosGlobales.PosicionSeleI[25] = 143;
                            ArreglosGlobales.PosicionSeleI[26] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI4")
                        {

                            P.Name = "panelSeleccionI3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI4")
                                    a.Name = "lblSeleccionI3";

                                if (a is Label && a.Name == "labelSeleccionI4")
                                    a.Name = "labelSeleccionI3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI4")
                                    a.Name = "TexboxSeleccionI3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI4")
                                    a.Name = "TexSeleccionI3";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI4")
                                    a.Name = "imagenSeleccionI3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI4")
                                    a.Name = "EliminarSeleccionI3";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI4")
                                    a.Name = "buttonSeleccionI3";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio4")
                                    a.Name = "Radio3";
                            }
                            ArreglosGlobales.PosicionSeleI[18] = ArreglosGlobales.PosicionSeleI[27];
                            ArreglosGlobales.PosicionSeleI[19] = ArreglosGlobales.PosicionSeleI[28];
                            ArreglosGlobales.PosicionSeleI[20] = ArreglosGlobales.PosicionSeleI[29];
                            ArreglosGlobales.PosicionSeleI[21] = ArreglosGlobales.PosicionSeleI[30];
                            ArreglosGlobales.PosicionSeleI[22] = ArreglosGlobales.PosicionSeleI[31];
                            ArreglosGlobales.PosicionSeleI[23] = ArreglosGlobales.PosicionSeleI[32];
                            ArreglosGlobales.PosicionSeleI[24] = ArreglosGlobales.PosicionSeleI[33];
                            ArreglosGlobales.PosicionSeleI[25] = ArreglosGlobales.PosicionSeleI[34];
                            ArreglosGlobales.PosicionSeleI[26] = ArreglosGlobales.PosicionSeleI[35];
                            ContSecundarioSeleI.ContadorR_SeleI3 = ContSecundarioSeleI.ContadorR_SeleI4;
                            ContSecundarioSeleI.ContadorR_SeleI4 = 2;
                            ArreglosGlobales.PosicionSeleI[27] = 180;
                            ArreglosGlobales.PosicionSeleI[28] = 62;
                            ArreglosGlobales.PosicionSeleI[29] = 57;
                            ArreglosGlobales.PosicionSeleI[30] = 95;
                            ArreglosGlobales.PosicionSeleI[31] = 146;
                            ArreglosGlobales.PosicionSeleI[32] = 155;
                            ArreglosGlobales.PosicionSeleI[33] = 135;
                            ArreglosGlobales.PosicionSeleI[34] = 143;
                            ArreglosGlobales.PosicionSeleI[35] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI5")
                        {
                            ArreglosGlobales.PosicionSeleI[27] = ArreglosGlobales.PosicionSeleI[36];
                            ArreglosGlobales.PosicionSeleI[28] = ArreglosGlobales.PosicionSeleI[37];
                            ArreglosGlobales.PosicionSeleI[29] = ArreglosGlobales.PosicionSeleI[38];
                            ArreglosGlobales.PosicionSeleI[30] = ArreglosGlobales.PosicionSeleI[39];
                            ArreglosGlobales.PosicionSeleI[31] = ArreglosGlobales.PosicionSeleI[40];
                            ArreglosGlobales.PosicionSeleI[32] = ArreglosGlobales.PosicionSeleI[41];
                            ArreglosGlobales.PosicionSeleI[33] = ArreglosGlobales.PosicionSeleI[42];
                            ArreglosGlobales.PosicionSeleI[34] = ArreglosGlobales.PosicionSeleI[43];
                            ArreglosGlobales.PosicionSeleI[35] = ArreglosGlobales.PosicionSeleI[44];
                            ContSecundarioSeleI.ContadorR_SeleI4 = ContSecundarioSeleI.ContadorR_SeleI5;
                            ContSecundarioSeleI.ContadorR_SeleI5 = 2;
                            ArreglosGlobales.PosicionSeleI[37] = 180;
                            ArreglosGlobales.PosicionSeleI[37] = 62;
                            ArreglosGlobales.PosicionSeleI[38] = 57;
                            ArreglosGlobales.PosicionSeleI[39] = 95;
                            ArreglosGlobales.PosicionSeleI[40] = 146;
                            ArreglosGlobales.PosicionSeleI[41] = 155;
                            ArreglosGlobales.PosicionSeleI[42] = 135;
                            ArreglosGlobales.PosicionSeleI[43] = 143;
                            ArreglosGlobales.PosicionSeleI[44] = 152;
                            P.Name = "panelSeleccionI4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI5")
                                    a.Name = "lblSeleccionI4";

                                if (a is Label && a.Name == "labelSeleccionI5")
                                    a.Name = "labelSeleccionI4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI5")
                                    a.Name = "TexboxSeleccionI4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI5")
                                    a.Name = "TexSeleccionI4";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI5")
                                    a.Name = "imagenSeleccionI4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI5")
                                    a.Name = "EliminarSeleccionI4";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI5")
                                    a.Name = "buttonSeleccionI4";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio5")
                                    a.Name = "Radio4";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI6")
                        {
                            ArreglosGlobales.PosicionSeleI[36] = ArreglosGlobales.PosicionSeleI[45];
                            ArreglosGlobales.PosicionSeleI[37] = ArreglosGlobales.PosicionSeleI[46];
                            ArreglosGlobales.PosicionSeleI[38] = ArreglosGlobales.PosicionSeleI[47];
                            ArreglosGlobales.PosicionSeleI[39] = ArreglosGlobales.PosicionSeleI[48];
                            ArreglosGlobales.PosicionSeleI[40] = ArreglosGlobales.PosicionSeleI[49];
                            ArreglosGlobales.PosicionSeleI[41] = ArreglosGlobales.PosicionSeleI[50];
                            ArreglosGlobales.PosicionSeleI[42] = ArreglosGlobales.PosicionSeleI[51];
                            ArreglosGlobales.PosicionSeleI[43] = ArreglosGlobales.PosicionSeleI[52];
                            ArreglosGlobales.PosicionSeleI[44] = ArreglosGlobales.PosicionSeleI[53];
                            ContSecundarioSeleI.ContadorR_SeleI5 = ContSecundarioSeleI.ContadorR_SeleI6;
                            ContSecundarioSeleI.ContadorR_SeleI6 = 2;
                            ArreglosGlobales.PosicionSeleI[45] = 180;
                            ArreglosGlobales.PosicionSeleI[46] = 62;
                            ArreglosGlobales.PosicionSeleI[47] = 57;
                            ArreglosGlobales.PosicionSeleI[48] = 95;
                            ArreglosGlobales.PosicionSeleI[49] = 146;
                            ArreglosGlobales.PosicionSeleI[50] = 155;
                            ArreglosGlobales.PosicionSeleI[51] = 135;
                            ArreglosGlobales.PosicionSeleI[52] = 143;
                            ArreglosGlobales.PosicionSeleI[53] = 152;
                            P.Name = "panelSeleccionI5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI6")
                                    a.Name = "lblSeleccionI5";

                                if (a is Label && a.Name == "labelSeleccionI6")
                                    a.Name = "labelSeleccionI5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI6")
                                    a.Name = "TexboxSeleccionI5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI6")
                                    a.Name = "TexSeleccionI5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI6")
                                    a.Name = "imagenSeleccionI5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI6")
                                    a.Name = "EliminarSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI6")
                                    a.Name = "buttonSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio6")
                                    a.Name = "Radio5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI7")
                        {
                            ArreglosGlobales.PosicionSeleI[45] = ArreglosGlobales.PosicionSeleI[54];
                            ArreglosGlobales.PosicionSeleI[46] = ArreglosGlobales.PosicionSeleI[55];
                            ArreglosGlobales.PosicionSeleI[47] = ArreglosGlobales.PosicionSeleI[56];
                            ArreglosGlobales.PosicionSeleI[48] = ArreglosGlobales.PosicionSeleI[57];
                            ArreglosGlobales.PosicionSeleI[49] = ArreglosGlobales.PosicionSeleI[58];
                            ArreglosGlobales.PosicionSeleI[50] = ArreglosGlobales.PosicionSeleI[59];
                            ArreglosGlobales.PosicionSeleI[51] = ArreglosGlobales.PosicionSeleI[60];
                            ArreglosGlobales.PosicionSeleI[52] = ArreglosGlobales.PosicionSeleI[61];
                            ArreglosGlobales.PosicionSeleI[53] = ArreglosGlobales.PosicionSeleI[62];
                            ArreglosGlobales.PosicionSeleI[54] = 180;
                            ArreglosGlobales.PosicionSeleI[55] = 62;
                            ArreglosGlobales.PosicionSeleI[56] = 57;
                            ArreglosGlobales.PosicionSeleI[57] = 95;
                            ArreglosGlobales.PosicionSeleI[58] = 146;
                            ArreglosGlobales.PosicionSeleI[59] = 155;
                            ArreglosGlobales.PosicionSeleI[60] = 135;
                            ArreglosGlobales.PosicionSeleI[61] = 143;
                            ArreglosGlobales.PosicionSeleI[62] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI6 = ContSecundarioSeleI.ContadorR_SeleI7;
                            ContSecundarioSeleI.ContadorR_SeleI7 = 2;
                            P.Name = "panelSeleccionI6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI7")
                                    a.Name = "lblSeleccionI6";

                                if (a is Label && a.Name == "labelSeleccionI7")
                                    a.Name = "labelSeleccionI6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI7")
                                    a.Name = "TexboxSeleccionI6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI7")
                                    a.Name = "TexSeleccionI6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI7")
                                    a.Name = "imagenSeleccionI6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI7")
                                    a.Name = "EliminarSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI7")
                                    a.Name = "buttonSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio7")
                                    a.Name = "Radio6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI8")
                        {
                            ArreglosGlobales.PosicionSeleI[54] = ArreglosGlobales.PosicionSeleI[63];
                            ArreglosGlobales.PosicionSeleI[55] = ArreglosGlobales.PosicionSeleI[64];
                            ArreglosGlobales.PosicionSeleI[56] = ArreglosGlobales.PosicionSeleI[65];
                            ArreglosGlobales.PosicionSeleI[57] = ArreglosGlobales.PosicionSeleI[66];
                            ArreglosGlobales.PosicionSeleI[58] = ArreglosGlobales.PosicionSeleI[67];
                            ArreglosGlobales.PosicionSeleI[59] = ArreglosGlobales.PosicionSeleI[68];
                            ArreglosGlobales.PosicionSeleI[60] = ArreglosGlobales.PosicionSeleI[69];
                            ArreglosGlobales.PosicionSeleI[61] = ArreglosGlobales.PosicionSeleI[70];
                            ArreglosGlobales.PosicionSeleI[62] = ArreglosGlobales.PosicionSeleI[71];
                            ArreglosGlobales.PosicionSeleI[63] = 180;
                            ArreglosGlobales.PosicionSeleI[64] = 62;
                            ArreglosGlobales.PosicionSeleI[65] = 57;
                            ArreglosGlobales.PosicionSeleI[66] = 95;
                            ArreglosGlobales.PosicionSeleI[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleI[69] = 135;
                            ArreglosGlobales.PosicionSeleI[70] = 143;
                            ArreglosGlobales.PosicionSeleI[71] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI7 = ContSecundarioSeleI.ContadorR_SeleI8;
                            ContSecundarioSeleI.ContadorR_SeleI8 = 2;
                            P.Name = "panelSeleccionI7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI8")
                                    a.Name = "lblSeleccionI7";

                                if (a is Label && a.Name == "labelSeleccionI8")
                                    a.Name = "labelSeleccionI7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI8")
                                    a.Name = "TexboxSeleccionI7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI8")
                                    a.Name = "TexSeleccionI7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI8")
                                    a.Name = "imagenSeleccionI7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI8")
                                    a.Name = "EliminarSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI8")
                                    a.Name = "buttonSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio8")
                                    a.Name = "Radio17";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
                        {
                            ArreglosGlobales.PosicionSeleI[63] = ArreglosGlobales.PosicionSeleI[72];
                            ArreglosGlobales.PosicionSeleI[64] = ArreglosGlobales.PosicionSeleI[73];
                            ArreglosGlobales.PosicionSeleI[65] = ArreglosGlobales.PosicionSeleI[74];
                            ArreglosGlobales.PosicionSeleI[66] = ArreglosGlobales.PosicionSeleI[75];
                            ArreglosGlobales.PosicionSeleI[67] = ArreglosGlobales.PosicionSeleI[76];
                            ArreglosGlobales.PosicionSeleI[68] = ArreglosGlobales.PosicionSeleI[77];
                            ArreglosGlobales.PosicionSeleI[69] = ArreglosGlobales.PosicionSeleI[78];
                            ArreglosGlobales.PosicionSeleI[70] = ArreglosGlobales.PosicionSeleI[79];
                            ArreglosGlobales.PosicionSeleI[71] = ArreglosGlobales.PosicionSeleI[80];
                            ArreglosGlobales.PosicionSeleI[72] = 180;
                            ArreglosGlobales.PosicionSeleI[73] = 62;
                            ArreglosGlobales.PosicionSeleI[74] = 57;
                            ArreglosGlobales.PosicionSeleI[75] = 95;
                            ArreglosGlobales.PosicionSeleI[76] = 146;
                            ArreglosGlobales.PosicionSeleI[77] = 155;
                            ArreglosGlobales.PosicionSeleI[78] = 135;
                            ArreglosGlobales.PosicionSeleI[79] = 143;
                            ArreglosGlobales.PosicionSeleI[80] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI8 = ContSecundarioSeleI.ContadorR_SeleI9;
                            ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                            P.Name = "panelSeleccionI8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI9")
                                    a.Name = "lblSeleccionI8";

                                if (a is Label && a.Name == "labelSeleccionI9")
                                    a.Name = "labelSeleccionI8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
                                    a.Name = "TexboxSeleccionI8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI9")
                                    a.Name = "TexSeleccionI8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI9")
                                    a.Name = "imagenSeleccionI8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                                    a.Name = "EliminarSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI9")
                                    a.Name = "buttonSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio9")
                                    a.Name = "Radio8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI2")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI2")
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
                    ArreglosGlobales.PosicionSeleI[9] = 180;
                    ArreglosGlobales.PosicionSeleI[10] = 62;
                    ArreglosGlobales.PosicionSeleI[11] = 57;
                    ArreglosGlobales.PosicionSeleI[12] = 95;
                    ArreglosGlobales.PosicionSeleI[13] = 146;
                    ArreglosGlobales.PosicionSeleI[14] = 155;
                    ArreglosGlobales.PosicionSeleI[15] = 135;
                    ArreglosGlobales.PosicionSeleI[16] = 143;
                    ArreglosGlobales.PosicionSeleI[17] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI2 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI3")
                        {
                            P.Name = "panelSeleccionI2";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI3")
                                    a.Name = "lblSeleccionI2";

                                if (a is Label && a.Name == "labelSeleccionI3")
                                    a.Name = "labelSeleccionI2";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI3")
                                    a.Name = "TexboxSeleccionI2";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI3")
                                    a.Name = "TexSeleccionI2";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI3")
                                    a.Name = "imagenSeleccionI2";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI3")
                                    a.Name = "EliminarSeleccionI2";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI3")
                                    a.Name = "buttonSeleccionI2";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio3")
                                    a.Name = "Radio2";
                            }

                            ArreglosGlobales.PosicionSeleI[9] = ArreglosGlobales.PosicionSeleI[18];
                            ArreglosGlobales.PosicionSeleI[10] = ArreglosGlobales.PosicionSeleI[19];
                            ArreglosGlobales.PosicionSeleI[11] = ArreglosGlobales.PosicionSeleI[20];
                            ArreglosGlobales.PosicionSeleI[12] = ArreglosGlobales.PosicionSeleI[21];
                            ArreglosGlobales.PosicionSeleI[13] = ArreglosGlobales.PosicionSeleI[22];
                            ArreglosGlobales.PosicionSeleI[14] = ArreglosGlobales.PosicionSeleI[23];
                            ArreglosGlobales.PosicionSeleI[15] = ArreglosGlobales.PosicionSeleI[24];
                            ArreglosGlobales.PosicionSeleI[16] = ArreglosGlobales.PosicionSeleI[25];
                            ArreglosGlobales.PosicionSeleI[17] = ArreglosGlobales.PosicionSeleI[26];
                            ContSecundarioSeleI.ContadorR_SeleI2 = ContSecundarioSeleI.ContadorR_SeleI3;
                            ContSecundarioSeleI.ContadorR_SeleI3 = 2;
                            ArreglosGlobales.PosicionSeleI[18] = 180;
                            ArreglosGlobales.PosicionSeleI[19] = 62;
                            ArreglosGlobales.PosicionSeleI[20] = 57;
                            ArreglosGlobales.PosicionSeleI[21] = 95;
                            ArreglosGlobales.PosicionSeleI[22] = 146;
                            ArreglosGlobales.PosicionSeleI[23] = 155;
                            ArreglosGlobales.PosicionSeleI[24] = 135;
                            ArreglosGlobales.PosicionSeleI[25] = 143;
                            ArreglosGlobales.PosicionSeleI[26] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI4")
                        {

                            P.Name = "panelSeleccionI3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI4")
                                    a.Name = "lblSeleccionI3";

                                if (a is Label && a.Name == "labelSeleccionI4")
                                    a.Name = "labelSeleccionI3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI4")
                                    a.Name = "TexboxSeleccionI3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI4")
                                    a.Name = "TexSeleccionI3";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI4")
                                    a.Name = "imagenSeleccionI3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI4")
                                    a.Name = "EliminarSeleccionI3";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI4")
                                    a.Name = "buttonSeleccionI3";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio4")
                                    a.Name = "Radio3";
                            }
                            ArreglosGlobales.PosicionSeleI[18] = ArreglosGlobales.PosicionSeleI[27];
                            ArreglosGlobales.PosicionSeleI[19] = ArreglosGlobales.PosicionSeleI[28];
                            ArreglosGlobales.PosicionSeleI[20] = ArreglosGlobales.PosicionSeleI[29];
                            ArreglosGlobales.PosicionSeleI[21] = ArreglosGlobales.PosicionSeleI[30];
                            ArreglosGlobales.PosicionSeleI[22] = ArreglosGlobales.PosicionSeleI[31];
                            ArreglosGlobales.PosicionSeleI[23] = ArreglosGlobales.PosicionSeleI[32];
                            ArreglosGlobales.PosicionSeleI[24] = ArreglosGlobales.PosicionSeleI[33];
                            ArreglosGlobales.PosicionSeleI[25] = ArreglosGlobales.PosicionSeleI[34];
                            ArreglosGlobales.PosicionSeleI[26] = ArreglosGlobales.PosicionSeleI[35];
                            ContSecundarioSeleI.ContadorR_SeleI3 = ContSecundarioSeleI.ContadorR_SeleI4;
                            ContSecundarioSeleI.ContadorR_SeleI4 = 2;
                            ArreglosGlobales.PosicionSeleI[27] = 180;
                            ArreglosGlobales.PosicionSeleI[28] = 62;
                            ArreglosGlobales.PosicionSeleI[29] = 57;
                            ArreglosGlobales.PosicionSeleI[30] = 95;
                            ArreglosGlobales.PosicionSeleI[31] = 146;
                            ArreglosGlobales.PosicionSeleI[32] = 155;
                            ArreglosGlobales.PosicionSeleI[33] = 135;
                            ArreglosGlobales.PosicionSeleI[34] = 143;
                            ArreglosGlobales.PosicionSeleI[35] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI5")
                        {
                            ArreglosGlobales.PosicionSeleI[27] = ArreglosGlobales.PosicionSeleI[36];
                            ArreglosGlobales.PosicionSeleI[28] = ArreglosGlobales.PosicionSeleI[37];
                            ArreglosGlobales.PosicionSeleI[29] = ArreglosGlobales.PosicionSeleI[38];
                            ArreglosGlobales.PosicionSeleI[30] = ArreglosGlobales.PosicionSeleI[39];
                            ArreglosGlobales.PosicionSeleI[31] = ArreglosGlobales.PosicionSeleI[40];
                            ArreglosGlobales.PosicionSeleI[32] = ArreglosGlobales.PosicionSeleI[41];
                            ArreglosGlobales.PosicionSeleI[33] = ArreglosGlobales.PosicionSeleI[42];
                            ArreglosGlobales.PosicionSeleI[34] = ArreglosGlobales.PosicionSeleI[43];
                            ArreglosGlobales.PosicionSeleI[35] = ArreglosGlobales.PosicionSeleI[44];
                            ContSecundarioSeleI.ContadorR_SeleI4 = ContSecundarioSeleI.ContadorR_SeleI5;
                            ContSecundarioSeleI.ContadorR_SeleI5 = 2;
                            ArreglosGlobales.PosicionSeleI[37] = 180;
                            ArreglosGlobales.PosicionSeleI[37] = 62;
                            ArreglosGlobales.PosicionSeleI[38] = 57;
                            ArreglosGlobales.PosicionSeleI[39] = 95;
                            ArreglosGlobales.PosicionSeleI[40] = 146;
                            ArreglosGlobales.PosicionSeleI[41] = 155;
                            ArreglosGlobales.PosicionSeleI[42] = 135;
                            ArreglosGlobales.PosicionSeleI[43] = 143;
                            ArreglosGlobales.PosicionSeleI[44] = 152;
                            P.Name = "panelSeleccionI4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI5")
                                    a.Name = "lblSeleccionI4";

                                if (a is Label && a.Name == "labelSeleccionI5")
                                    a.Name = "labelSeleccionI4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI5")
                                    a.Name = "TexboxSeleccionI4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI5")
                                    a.Name = "TexSeleccionI4";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI5")
                                    a.Name = "imagenSeleccionI4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI5")
                                    a.Name = "EliminarSeleccionI4";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI5")
                                    a.Name = "buttonSeleccionI4";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio5")
                                    a.Name = "Radio4";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI6")
                        {
                            ArreglosGlobales.PosicionSeleI[36] = ArreglosGlobales.PosicionSeleI[45];
                            ArreglosGlobales.PosicionSeleI[37] = ArreglosGlobales.PosicionSeleI[46];
                            ArreglosGlobales.PosicionSeleI[38] = ArreglosGlobales.PosicionSeleI[47];
                            ArreglosGlobales.PosicionSeleI[39] = ArreglosGlobales.PosicionSeleI[48];
                            ArreglosGlobales.PosicionSeleI[40] = ArreglosGlobales.PosicionSeleI[49];
                            ArreglosGlobales.PosicionSeleI[41] = ArreglosGlobales.PosicionSeleI[50];
                            ArreglosGlobales.PosicionSeleI[42] = ArreglosGlobales.PosicionSeleI[51];
                            ArreglosGlobales.PosicionSeleI[43] = ArreglosGlobales.PosicionSeleI[52];
                            ArreglosGlobales.PosicionSeleI[44] = ArreglosGlobales.PosicionSeleI[53];
                            ContSecundarioSeleI.ContadorR_SeleI5 = ContSecundarioSeleI.ContadorR_SeleI6;
                            ContSecundarioSeleI.ContadorR_SeleI6 = 2;
                            ArreglosGlobales.PosicionSeleI[45] = 180;
                            ArreglosGlobales.PosicionSeleI[46] = 62;
                            ArreglosGlobales.PosicionSeleI[47] = 57;
                            ArreglosGlobales.PosicionSeleI[48] = 95;
                            ArreglosGlobales.PosicionSeleI[49] = 146;
                            ArreglosGlobales.PosicionSeleI[50] = 155;
                            ArreglosGlobales.PosicionSeleI[51] = 135;
                            ArreglosGlobales.PosicionSeleI[52] = 143;
                            ArreglosGlobales.PosicionSeleI[53] = 152;
                            P.Name = "panelSeleccionI5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI6")
                                    a.Name = "lblSeleccionI5";

                                if (a is Label && a.Name == "labelSeleccionI6")
                                    a.Name = "labelSeleccionI5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI6")
                                    a.Name = "TexboxSeleccionI5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI6")
                                    a.Name = "TexSeleccionI5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI6")
                                    a.Name = "imagenSeleccionI5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI6")
                                    a.Name = "EliminarSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI6")
                                    a.Name = "buttonSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio6")
                                    a.Name = "Radio5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI7")
                        {
                            ArreglosGlobales.PosicionSeleI[45] = ArreglosGlobales.PosicionSeleI[54];
                            ArreglosGlobales.PosicionSeleI[46] = ArreglosGlobales.PosicionSeleI[55];
                            ArreglosGlobales.PosicionSeleI[47] = ArreglosGlobales.PosicionSeleI[56];
                            ArreglosGlobales.PosicionSeleI[48] = ArreglosGlobales.PosicionSeleI[57];
                            ArreglosGlobales.PosicionSeleI[49] = ArreglosGlobales.PosicionSeleI[58];
                            ArreglosGlobales.PosicionSeleI[50] = ArreglosGlobales.PosicionSeleI[59];
                            ArreglosGlobales.PosicionSeleI[51] = ArreglosGlobales.PosicionSeleI[60];
                            ArreglosGlobales.PosicionSeleI[52] = ArreglosGlobales.PosicionSeleI[61];
                            ArreglosGlobales.PosicionSeleI[53] = ArreglosGlobales.PosicionSeleI[62];
                            ArreglosGlobales.PosicionSeleI[54] = 180;
                            ArreglosGlobales.PosicionSeleI[55] = 62;
                            ArreglosGlobales.PosicionSeleI[56] = 57;
                            ArreglosGlobales.PosicionSeleI[57] = 95;
                            ArreglosGlobales.PosicionSeleI[58] = 146;
                            ArreglosGlobales.PosicionSeleI[59] = 155;
                            ArreglosGlobales.PosicionSeleI[60] = 135;
                            ArreglosGlobales.PosicionSeleI[61] = 143;
                            ArreglosGlobales.PosicionSeleI[62] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI6 = ContSecundarioSeleI.ContadorR_SeleI7;
                            ContSecundarioSeleI.ContadorR_SeleI7 = 2;
                            P.Name = "panelSeleccionI6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI7")
                                    a.Name = "lblSeleccionI6";

                                if (a is Label && a.Name == "labelSeleccionI7")
                                    a.Name = "labelSeleccionI6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI7")
                                    a.Name = "TexboxSeleccionI6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI7")
                                    a.Name = "TexSeleccionI6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI7")
                                    a.Name = "imagenSeleccionI6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI7")
                                    a.Name = "EliminarSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI7")
                                    a.Name = "buttonSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio7")
                                    a.Name = "Radio6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI8")
                        {
                            ArreglosGlobales.PosicionSeleI[54] = ArreglosGlobales.PosicionSeleI[63];
                            ArreglosGlobales.PosicionSeleI[55] = ArreglosGlobales.PosicionSeleI[64];
                            ArreglosGlobales.PosicionSeleI[56] = ArreglosGlobales.PosicionSeleI[65];
                            ArreglosGlobales.PosicionSeleI[57] = ArreglosGlobales.PosicionSeleI[66];
                            ArreglosGlobales.PosicionSeleI[58] = ArreglosGlobales.PosicionSeleI[67];
                            ArreglosGlobales.PosicionSeleI[59] = ArreglosGlobales.PosicionSeleI[68];
                            ArreglosGlobales.PosicionSeleI[60] = ArreglosGlobales.PosicionSeleI[69];
                            ArreglosGlobales.PosicionSeleI[61] = ArreglosGlobales.PosicionSeleI[70];
                            ArreglosGlobales.PosicionSeleI[62] = ArreglosGlobales.PosicionSeleI[71];
                            ArreglosGlobales.PosicionSeleI[63] = 180;
                            ArreglosGlobales.PosicionSeleI[64] = 62;
                            ArreglosGlobales.PosicionSeleI[65] = 57;
                            ArreglosGlobales.PosicionSeleI[66] = 95;
                            ArreglosGlobales.PosicionSeleI[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleI[69] = 135;
                            ArreglosGlobales.PosicionSeleI[70] = 143;
                            ArreglosGlobales.PosicionSeleI[71] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI7 = ContSecundarioSeleI.ContadorR_SeleI8;
                            ContSecundarioSeleI.ContadorR_SeleI8 = 2;
                            P.Name = "panelSeleccionI7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI8")
                                    a.Name = "lblSeleccionI7";

                                if (a is Label && a.Name == "labelSeleccionI8")
                                    a.Name = "labelSeleccionI7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI8")
                                    a.Name = "TexboxSeleccionI7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI8")
                                    a.Name = "TexSeleccionI7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI8")
                                    a.Name = "imagenSeleccionI7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI8")
                                    a.Name = "EliminarSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI8")
                                    a.Name = "buttonSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio8")
                                    a.Name = "Radio17";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
                        {
                            ArreglosGlobales.PosicionSeleI[63] = ArreglosGlobales.PosicionSeleI[72];
                            ArreglosGlobales.PosicionSeleI[64] = ArreglosGlobales.PosicionSeleI[73];
                            ArreglosGlobales.PosicionSeleI[65] = ArreglosGlobales.PosicionSeleI[74];
                            ArreglosGlobales.PosicionSeleI[66] = ArreglosGlobales.PosicionSeleI[75];
                            ArreglosGlobales.PosicionSeleI[67] = ArreglosGlobales.PosicionSeleI[76];
                            ArreglosGlobales.PosicionSeleI[68] = ArreglosGlobales.PosicionSeleI[77];
                            ArreglosGlobales.PosicionSeleI[69] = ArreglosGlobales.PosicionSeleI[78];
                            ArreglosGlobales.PosicionSeleI[70] = ArreglosGlobales.PosicionSeleI[79];
                            ArreglosGlobales.PosicionSeleI[71] = ArreglosGlobales.PosicionSeleI[80];
                            ArreglosGlobales.PosicionSeleI[72] = 180;
                            ArreglosGlobales.PosicionSeleI[73] = 62;
                            ArreglosGlobales.PosicionSeleI[74] = 57;
                            ArreglosGlobales.PosicionSeleI[75] = 95;
                            ArreglosGlobales.PosicionSeleI[76] = 146;
                            ArreglosGlobales.PosicionSeleI[77] = 155;
                            ArreglosGlobales.PosicionSeleI[78] = 135;
                            ArreglosGlobales.PosicionSeleI[79] = 143;
                            ArreglosGlobales.PosicionSeleI[80] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI8 = ContSecundarioSeleI.ContadorR_SeleI9;
                            ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                            P.Name = "panelSeleccionI8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI9")
                                    a.Name = "lblSeleccionI8";

                                if (a is Label && a.Name == "labelSeleccionI9")
                                    a.Name = "labelSeleccionI8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
                                    a.Name = "TexboxSeleccionI8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI9")
                                    a.Name = "TexSeleccionI8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI9")
                                    a.Name = "imagenSeleccionI8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                                    a.Name = "EliminarSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI9")
                                    a.Name = "buttonSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio9")
                                    a.Name = "Radio8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI3")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI3")
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
                    ArreglosGlobales.PosicionSeleI[18] = 180;
                    ArreglosGlobales.PosicionSeleI[19] = 62;
                    ArreglosGlobales.PosicionSeleI[20] = 57;
                    ArreglosGlobales.PosicionSeleI[21] = 95;
                    ArreglosGlobales.PosicionSeleI[22] = 146;
                    ArreglosGlobales.PosicionSeleI[23] = 155;
                    ArreglosGlobales.PosicionSeleI[24] = 135;
                    ArreglosGlobales.PosicionSeleI[25] = 143;
                    ArreglosGlobales.PosicionSeleI[26] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI3 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI4")
                        {

                            P.Name = "panelSeleccionI3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI4")
                                    a.Name = "lblSeleccionI3";

                                if (a is Label && a.Name == "labelSeleccionI4")
                                    a.Name = "labelSeleccionI3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI4")
                                    a.Name = "TexboxSeleccionI3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI4")
                                    a.Name = "TexSeleccionI3";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI4")
                                    a.Name = "imagenSeleccionI3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI4")
                                    a.Name = "EliminarSeleccionI3";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI4")
                                    a.Name = "buttonSeleccionI3";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio4")
                                    a.Name = "Radio3";
                            }
                            ArreglosGlobales.PosicionSeleI[18] = ArreglosGlobales.PosicionSeleI[27];
                            ArreglosGlobales.PosicionSeleI[19] = ArreglosGlobales.PosicionSeleI[28];
                            ArreglosGlobales.PosicionSeleI[20] = ArreglosGlobales.PosicionSeleI[29];
                            ArreglosGlobales.PosicionSeleI[21] = ArreglosGlobales.PosicionSeleI[30];
                            ArreglosGlobales.PosicionSeleI[22] = ArreglosGlobales.PosicionSeleI[31];
                            ArreglosGlobales.PosicionSeleI[23] = ArreglosGlobales.PosicionSeleI[32];
                            ArreglosGlobales.PosicionSeleI[24] = ArreglosGlobales.PosicionSeleI[33];
                            ArreglosGlobales.PosicionSeleI[25] = ArreglosGlobales.PosicionSeleI[34];
                            ArreglosGlobales.PosicionSeleI[26] = ArreglosGlobales.PosicionSeleI[35];
                            ContSecundarioSeleI.ContadorR_SeleI3 = ContSecundarioSeleI.ContadorR_SeleI4;
                            ContSecundarioSeleI.ContadorR_SeleI4 = 2;
                            ArreglosGlobales.PosicionSeleI[27] = 180;
                            ArreglosGlobales.PosicionSeleI[28] = 62;
                            ArreglosGlobales.PosicionSeleI[29] = 57;
                            ArreglosGlobales.PosicionSeleI[30] = 95;
                            ArreglosGlobales.PosicionSeleI[31] = 146;
                            ArreglosGlobales.PosicionSeleI[32] = 155;
                            ArreglosGlobales.PosicionSeleI[33] = 135;
                            ArreglosGlobales.PosicionSeleI[34] = 143;
                            ArreglosGlobales.PosicionSeleI[35] = 152;
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI5")
                        {
                            ArreglosGlobales.PosicionSeleI[27] = ArreglosGlobales.PosicionSeleI[36];
                            ArreglosGlobales.PosicionSeleI[28] = ArreglosGlobales.PosicionSeleI[37];
                            ArreglosGlobales.PosicionSeleI[29] = ArreglosGlobales.PosicionSeleI[38];
                            ArreglosGlobales.PosicionSeleI[30] = ArreglosGlobales.PosicionSeleI[39];
                            ArreglosGlobales.PosicionSeleI[31] = ArreglosGlobales.PosicionSeleI[40];
                            ArreglosGlobales.PosicionSeleI[32] = ArreglosGlobales.PosicionSeleI[41];
                            ArreglosGlobales.PosicionSeleI[33] = ArreglosGlobales.PosicionSeleI[42];
                            ArreglosGlobales.PosicionSeleI[34] = ArreglosGlobales.PosicionSeleI[43];
                            ArreglosGlobales.PosicionSeleI[35] = ArreglosGlobales.PosicionSeleI[44];
                            ContSecundarioSeleI.ContadorR_SeleI4 = ContSecundarioSeleI.ContadorR_SeleI5;
                            ContSecundarioSeleI.ContadorR_SeleI5 = 2;
                            ArreglosGlobales.PosicionSeleI[37] = 180;
                            ArreglosGlobales.PosicionSeleI[37] = 62;
                            ArreglosGlobales.PosicionSeleI[38] = 57;
                            ArreglosGlobales.PosicionSeleI[39] = 95;
                            ArreglosGlobales.PosicionSeleI[40] = 146;
                            ArreglosGlobales.PosicionSeleI[41] = 155;
                            ArreglosGlobales.PosicionSeleI[42] = 135;
                            ArreglosGlobales.PosicionSeleI[43] = 143;
                            ArreglosGlobales.PosicionSeleI[44] = 152;
                            P.Name = "panelSeleccionI4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI5")
                                    a.Name = "lblSeleccionI4";

                                if (a is Label && a.Name == "labelSeleccionI5")
                                    a.Name = "labelSeleccionI4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI5")
                                    a.Name = "TexboxSeleccionI4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI5")
                                    a.Name = "TexSeleccionI4";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI5")
                                    a.Name = "imagenSeleccionI4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI5")
                                    a.Name = "EliminarSeleccionI4";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI5")
                                    a.Name = "buttonSeleccionI4";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio5")
                                    a.Name = "Radio4";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI6")
                        {
                            ArreglosGlobales.PosicionSeleI[36] = ArreglosGlobales.PosicionSeleI[45];
                            ArreglosGlobales.PosicionSeleI[37] = ArreglosGlobales.PosicionSeleI[46];
                            ArreglosGlobales.PosicionSeleI[38] = ArreglosGlobales.PosicionSeleI[47];
                            ArreglosGlobales.PosicionSeleI[39] = ArreglosGlobales.PosicionSeleI[48];
                            ArreglosGlobales.PosicionSeleI[40] = ArreglosGlobales.PosicionSeleI[49];
                            ArreglosGlobales.PosicionSeleI[41] = ArreglosGlobales.PosicionSeleI[50];
                            ArreglosGlobales.PosicionSeleI[42] = ArreglosGlobales.PosicionSeleI[51];
                            ArreglosGlobales.PosicionSeleI[43] = ArreglosGlobales.PosicionSeleI[52];
                            ArreglosGlobales.PosicionSeleI[44] = ArreglosGlobales.PosicionSeleI[53];
                            ContSecundarioSeleI.ContadorR_SeleI5 = ContSecundarioSeleI.ContadorR_SeleI6;
                            ContSecundarioSeleI.ContadorR_SeleI6 = 2;
                            ArreglosGlobales.PosicionSeleI[45] = 180;
                            ArreglosGlobales.PosicionSeleI[46] = 62;
                            ArreglosGlobales.PosicionSeleI[47] = 57;
                            ArreglosGlobales.PosicionSeleI[48] = 95;
                            ArreglosGlobales.PosicionSeleI[49] = 146;
                            ArreglosGlobales.PosicionSeleI[50] = 155;
                            ArreglosGlobales.PosicionSeleI[51] = 135;
                            ArreglosGlobales.PosicionSeleI[52] = 143;
                            ArreglosGlobales.PosicionSeleI[53] = 152;
                            P.Name = "panelSeleccionI5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI6")
                                    a.Name = "lblSeleccionI5";

                                if (a is Label && a.Name == "labelSeleccionI6")
                                    a.Name = "labelSeleccionI5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI6")
                                    a.Name = "TexboxSeleccionI5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI6")
                                    a.Name = "TexSeleccionI5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI6")
                                    a.Name = "imagenSeleccionI5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI6")
                                    a.Name = "EliminarSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI6")
                                    a.Name = "buttonSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio6")
                                    a.Name = "Radio5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI7")
                        {
                            ArreglosGlobales.PosicionSeleI[45] = ArreglosGlobales.PosicionSeleI[54];
                            ArreglosGlobales.PosicionSeleI[46] = ArreglosGlobales.PosicionSeleI[55];
                            ArreglosGlobales.PosicionSeleI[47] = ArreglosGlobales.PosicionSeleI[56];
                            ArreglosGlobales.PosicionSeleI[48] = ArreglosGlobales.PosicionSeleI[57];
                            ArreglosGlobales.PosicionSeleI[49] = ArreglosGlobales.PosicionSeleI[58];
                            ArreglosGlobales.PosicionSeleI[50] = ArreglosGlobales.PosicionSeleI[59];
                            ArreglosGlobales.PosicionSeleI[51] = ArreglosGlobales.PosicionSeleI[60];
                            ArreglosGlobales.PosicionSeleI[52] = ArreglosGlobales.PosicionSeleI[61];
                            ArreglosGlobales.PosicionSeleI[53] = ArreglosGlobales.PosicionSeleI[62];
                            ArreglosGlobales.PosicionSeleI[54] = 180;
                            ArreglosGlobales.PosicionSeleI[55] = 62;
                            ArreglosGlobales.PosicionSeleI[56] = 57;
                            ArreglosGlobales.PosicionSeleI[57] = 95;
                            ArreglosGlobales.PosicionSeleI[58] = 146;
                            ArreglosGlobales.PosicionSeleI[59] = 155;
                            ArreglosGlobales.PosicionSeleI[60] = 135;
                            ArreglosGlobales.PosicionSeleI[61] = 143;
                            ArreglosGlobales.PosicionSeleI[62] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI6 = ContSecundarioSeleI.ContadorR_SeleI7;
                            ContSecundarioSeleI.ContadorR_SeleI7 = 2;
                            P.Name = "panelSeleccionI6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI7")
                                    a.Name = "lblSeleccionI6";

                                if (a is Label && a.Name == "labelSeleccionI7")
                                    a.Name = "labelSeleccionI6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI7")
                                    a.Name = "TexboxSeleccionI6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI7")
                                    a.Name = "TexSeleccionI6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI7")
                                    a.Name = "imagenSeleccionI6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI7")
                                    a.Name = "EliminarSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI7")
                                    a.Name = "buttonSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio7")
                                    a.Name = "Radio6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI8")
                        {
                            ArreglosGlobales.PosicionSeleI[54] = ArreglosGlobales.PosicionSeleI[63];
                            ArreglosGlobales.PosicionSeleI[55] = ArreglosGlobales.PosicionSeleI[64];
                            ArreglosGlobales.PosicionSeleI[56] = ArreglosGlobales.PosicionSeleI[65];
                            ArreglosGlobales.PosicionSeleI[57] = ArreglosGlobales.PosicionSeleI[66];
                            ArreglosGlobales.PosicionSeleI[58] = ArreglosGlobales.PosicionSeleI[67];
                            ArreglosGlobales.PosicionSeleI[59] = ArreglosGlobales.PosicionSeleI[68];
                            ArreglosGlobales.PosicionSeleI[60] = ArreglosGlobales.PosicionSeleI[69];
                            ArreglosGlobales.PosicionSeleI[61] = ArreglosGlobales.PosicionSeleI[70];
                            ArreglosGlobales.PosicionSeleI[62] = ArreglosGlobales.PosicionSeleI[71];
                            ArreglosGlobales.PosicionSeleI[63] = 180;
                            ArreglosGlobales.PosicionSeleI[64] = 62;
                            ArreglosGlobales.PosicionSeleI[65] = 57;
                            ArreglosGlobales.PosicionSeleI[66] = 95;
                            ArreglosGlobales.PosicionSeleI[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleI[69] = 135;
                            ArreglosGlobales.PosicionSeleI[70] = 143;
                            ArreglosGlobales.PosicionSeleI[71] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI7 = ContSecundarioSeleI.ContadorR_SeleI8;
                            ContSecundarioSeleI.ContadorR_SeleI8 = 2;
                            P.Name = "panelSeleccionI7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI8")
                                    a.Name = "lblSeleccionI7";

                                if (a is Label && a.Name == "labelSeleccionI8")
                                    a.Name = "labelSeleccionI7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI8")
                                    a.Name = "TexboxSeleccionI7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI8")
                                    a.Name = "TexSeleccionI7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI8")
                                    a.Name = "imagenSeleccionI7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI8")
                                    a.Name = "EliminarSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI8")
                                    a.Name = "buttonSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio8")
                                    a.Name = "Radio17";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
                        {
                            ArreglosGlobales.PosicionSeleI[63] = ArreglosGlobales.PosicionSeleI[72];
                            ArreglosGlobales.PosicionSeleI[64] = ArreglosGlobales.PosicionSeleI[73];
                            ArreglosGlobales.PosicionSeleI[65] = ArreglosGlobales.PosicionSeleI[74];
                            ArreglosGlobales.PosicionSeleI[66] = ArreglosGlobales.PosicionSeleI[75];
                            ArreglosGlobales.PosicionSeleI[67] = ArreglosGlobales.PosicionSeleI[76];
                            ArreglosGlobales.PosicionSeleI[68] = ArreglosGlobales.PosicionSeleI[77];
                            ArreglosGlobales.PosicionSeleI[69] = ArreglosGlobales.PosicionSeleI[78];
                            ArreglosGlobales.PosicionSeleI[70] = ArreglosGlobales.PosicionSeleI[79];
                            ArreglosGlobales.PosicionSeleI[71] = ArreglosGlobales.PosicionSeleI[80];
                            ArreglosGlobales.PosicionSeleI[72] = 180;
                            ArreglosGlobales.PosicionSeleI[73] = 62;
                            ArreglosGlobales.PosicionSeleI[74] = 57;
                            ArreglosGlobales.PosicionSeleI[75] = 95;
                            ArreglosGlobales.PosicionSeleI[76] = 146;
                            ArreglosGlobales.PosicionSeleI[77] = 155;
                            ArreglosGlobales.PosicionSeleI[78] = 135;
                            ArreglosGlobales.PosicionSeleI[79] = 143;
                            ArreglosGlobales.PosicionSeleI[80] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI8 = ContSecundarioSeleI.ContadorR_SeleI9;
                            ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                            P.Name = "panelSeleccionI8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI9")
                                    a.Name = "lblSeleccionI8";

                                if (a is Label && a.Name == "labelSeleccionI9")
                                    a.Name = "labelSeleccionI8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
                                    a.Name = "TexboxSeleccionI8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI9")
                                    a.Name = "TexSeleccionI8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI9")
                                    a.Name = "imagenSeleccionI8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                                    a.Name = "EliminarSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI9")
                                    a.Name = "buttonSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio9")
                                    a.Name = "Radio8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI4")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI4")
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
                    ArreglosGlobales.PosicionSeleI[27] = 180;
                    ArreglosGlobales.PosicionSeleI[28] = 62;
                    ArreglosGlobales.PosicionSeleI[29] = 57;
                    ArreglosGlobales.PosicionSeleI[30] = 95;
                    ArreglosGlobales.PosicionSeleI[31] = 146;
                    ArreglosGlobales.PosicionSeleI[32] = 155;
                    ArreglosGlobales.PosicionSeleI[33] = 135;
                    ArreglosGlobales.PosicionSeleI[34] = 143;
                    ArreglosGlobales.PosicionSeleI[35] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI4 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI5")
                        {
                            ArreglosGlobales.PosicionSeleI[27] = ArreglosGlobales.PosicionSeleI[36];
                            ArreglosGlobales.PosicionSeleI[28] = ArreglosGlobales.PosicionSeleI[37];
                            ArreglosGlobales.PosicionSeleI[29] = ArreglosGlobales.PosicionSeleI[38];
                            ArreglosGlobales.PosicionSeleI[30] = ArreglosGlobales.PosicionSeleI[39];
                            ArreglosGlobales.PosicionSeleI[31] = ArreglosGlobales.PosicionSeleI[40];
                            ArreglosGlobales.PosicionSeleI[32] = ArreglosGlobales.PosicionSeleI[41];
                            ArreglosGlobales.PosicionSeleI[33] = ArreglosGlobales.PosicionSeleI[42];
                            ArreglosGlobales.PosicionSeleI[34] = ArreglosGlobales.PosicionSeleI[43];
                            ArreglosGlobales.PosicionSeleI[35] = ArreglosGlobales.PosicionSeleI[44];
                            ContSecundarioSeleI.ContadorR_SeleI4 = ContSecundarioSeleI.ContadorR_SeleI5;
                            ContSecundarioSeleI.ContadorR_SeleI5 = 2;
                            ArreglosGlobales.PosicionSeleI[37] = 180;
                            ArreglosGlobales.PosicionSeleI[37] = 62;
                            ArreglosGlobales.PosicionSeleI[38] = 57;
                            ArreglosGlobales.PosicionSeleI[39] = 95;
                            ArreglosGlobales.PosicionSeleI[40] = 146;
                            ArreglosGlobales.PosicionSeleI[41] = 155;
                            ArreglosGlobales.PosicionSeleI[42] = 135;
                            ArreglosGlobales.PosicionSeleI[43] = 143;
                            ArreglosGlobales.PosicionSeleI[44] = 152;
                            P.Name = "panelSeleccionI4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI5")
                                    a.Name = "lblSeleccionI4";

                                if (a is Label && a.Name == "labelSeleccionI5")
                                    a.Name = "labelSeleccionI4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI5")
                                    a.Name = "TexboxSeleccionI4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI5")
                                    a.Name = "TexSeleccionI4";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI5")
                                    a.Name = "imagenSeleccionI4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI5")
                                    a.Name = "EliminarSeleccionI4";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI5")
                                    a.Name = "buttonSeleccionI4";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio5")
                                    a.Name = "Radio4";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI6")
                        {
                            ArreglosGlobales.PosicionSeleI[36] = ArreglosGlobales.PosicionSeleI[45];
                            ArreglosGlobales.PosicionSeleI[37] = ArreglosGlobales.PosicionSeleI[46];
                            ArreglosGlobales.PosicionSeleI[38] = ArreglosGlobales.PosicionSeleI[47];
                            ArreglosGlobales.PosicionSeleI[39] = ArreglosGlobales.PosicionSeleI[48];
                            ArreglosGlobales.PosicionSeleI[40] = ArreglosGlobales.PosicionSeleI[49];
                            ArreglosGlobales.PosicionSeleI[41] = ArreglosGlobales.PosicionSeleI[50];
                            ArreglosGlobales.PosicionSeleI[42] = ArreglosGlobales.PosicionSeleI[51];
                            ArreglosGlobales.PosicionSeleI[43] = ArreglosGlobales.PosicionSeleI[52];
                            ArreglosGlobales.PosicionSeleI[44] = ArreglosGlobales.PosicionSeleI[53];
                            ContSecundarioSeleI.ContadorR_SeleI5 = ContSecundarioSeleI.ContadorR_SeleI6;
                            ContSecundarioSeleI.ContadorR_SeleI6 = 2;
                            ArreglosGlobales.PosicionSeleI[45] = 180;
                            ArreglosGlobales.PosicionSeleI[46] = 62;
                            ArreglosGlobales.PosicionSeleI[47] = 57;
                            ArreglosGlobales.PosicionSeleI[48] = 95;
                            ArreglosGlobales.PosicionSeleI[49] = 146;
                            ArreglosGlobales.PosicionSeleI[50] = 155;
                            ArreglosGlobales.PosicionSeleI[51] = 135;
                            ArreglosGlobales.PosicionSeleI[52] = 143;
                            ArreglosGlobales.PosicionSeleI[53] = 152;
                            P.Name = "panelSeleccionI5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI6")
                                    a.Name = "lblSeleccionI5";

                                if (a is Label && a.Name == "labelSeleccionI6")
                                    a.Name = "labelSeleccionI5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI6")
                                    a.Name = "TexboxSeleccionI5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI6")
                                    a.Name = "TexSeleccionI5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI6")
                                    a.Name = "imagenSeleccionI5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI6")
                                    a.Name = "EliminarSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI6")
                                    a.Name = "buttonSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio6")
                                    a.Name = "Radio5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI7")
                        {
                            ArreglosGlobales.PosicionSeleI[45] = ArreglosGlobales.PosicionSeleI[54];
                            ArreglosGlobales.PosicionSeleI[46] = ArreglosGlobales.PosicionSeleI[55];
                            ArreglosGlobales.PosicionSeleI[47] = ArreglosGlobales.PosicionSeleI[56];
                            ArreglosGlobales.PosicionSeleI[48] = ArreglosGlobales.PosicionSeleI[57];
                            ArreglosGlobales.PosicionSeleI[49] = ArreglosGlobales.PosicionSeleI[58];
                            ArreglosGlobales.PosicionSeleI[50] = ArreglosGlobales.PosicionSeleI[59];
                            ArreglosGlobales.PosicionSeleI[51] = ArreglosGlobales.PosicionSeleI[60];
                            ArreglosGlobales.PosicionSeleI[52] = ArreglosGlobales.PosicionSeleI[61];
                            ArreglosGlobales.PosicionSeleI[53] = ArreglosGlobales.PosicionSeleI[62];
                            ArreglosGlobales.PosicionSeleI[54] = 180;
                            ArreglosGlobales.PosicionSeleI[55] = 62;
                            ArreglosGlobales.PosicionSeleI[56] = 57;
                            ArreglosGlobales.PosicionSeleI[57] = 95;
                            ArreglosGlobales.PosicionSeleI[58] = 146;
                            ArreglosGlobales.PosicionSeleI[59] = 155;
                            ArreglosGlobales.PosicionSeleI[60] = 135;
                            ArreglosGlobales.PosicionSeleI[61] = 143;
                            ArreglosGlobales.PosicionSeleI[62] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI6 = ContSecundarioSeleI.ContadorR_SeleI7;
                            ContSecundarioSeleI.ContadorR_SeleI7 = 2;
                            P.Name = "panelSeleccionI6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI7")
                                    a.Name = "lblSeleccionI6";

                                if (a is Label && a.Name == "labelSeleccionI7")
                                    a.Name = "labelSeleccionI6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI7")
                                    a.Name = "TexboxSeleccionI6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI7")
                                    a.Name = "TexSeleccionI6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI7")
                                    a.Name = "imagenSeleccionI6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI7")
                                    a.Name = "EliminarSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI7")
                                    a.Name = "buttonSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio7")
                                    a.Name = "Radio6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI8")
                        {
                            ArreglosGlobales.PosicionSeleI[54] = ArreglosGlobales.PosicionSeleI[63];
                            ArreglosGlobales.PosicionSeleI[55] = ArreglosGlobales.PosicionSeleI[64];
                            ArreglosGlobales.PosicionSeleI[56] = ArreglosGlobales.PosicionSeleI[65];
                            ArreglosGlobales.PosicionSeleI[57] = ArreglosGlobales.PosicionSeleI[66];
                            ArreglosGlobales.PosicionSeleI[58] = ArreglosGlobales.PosicionSeleI[67];
                            ArreglosGlobales.PosicionSeleI[59] = ArreglosGlobales.PosicionSeleI[68];
                            ArreglosGlobales.PosicionSeleI[60] = ArreglosGlobales.PosicionSeleI[69];
                            ArreglosGlobales.PosicionSeleI[61] = ArreglosGlobales.PosicionSeleI[70];
                            ArreglosGlobales.PosicionSeleI[62] = ArreglosGlobales.PosicionSeleI[71];
                            ArreglosGlobales.PosicionSeleI[63] = 180;
                            ArreglosGlobales.PosicionSeleI[64] = 62;
                            ArreglosGlobales.PosicionSeleI[65] = 57;
                            ArreglosGlobales.PosicionSeleI[66] = 95;
                            ArreglosGlobales.PosicionSeleI[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleI[69] = 135;
                            ArreglosGlobales.PosicionSeleI[70] = 143;
                            ArreglosGlobales.PosicionSeleI[71] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI7 = ContSecundarioSeleI.ContadorR_SeleI8;
                            ContSecundarioSeleI.ContadorR_SeleI8 = 2;
                            P.Name = "panelSeleccionI7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI8")
                                    a.Name = "lblSeleccionI7";

                                if (a is Label && a.Name == "labelSeleccionI8")
                                    a.Name = "labelSeleccionI7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI8")
                                    a.Name = "TexboxSeleccionI7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI8")
                                    a.Name = "TexSeleccionI7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI8")
                                    a.Name = "imagenSeleccionI7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI8")
                                    a.Name = "EliminarSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI8")
                                    a.Name = "buttonSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio8")
                                    a.Name = "Radio17";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
                        {
                            ArreglosGlobales.PosicionSeleI[63] = ArreglosGlobales.PosicionSeleI[72];
                            ArreglosGlobales.PosicionSeleI[64] = ArreglosGlobales.PosicionSeleI[73];
                            ArreglosGlobales.PosicionSeleI[65] = ArreglosGlobales.PosicionSeleI[74];
                            ArreglosGlobales.PosicionSeleI[66] = ArreglosGlobales.PosicionSeleI[75];
                            ArreglosGlobales.PosicionSeleI[67] = ArreglosGlobales.PosicionSeleI[76];
                            ArreglosGlobales.PosicionSeleI[68] = ArreglosGlobales.PosicionSeleI[77];
                            ArreglosGlobales.PosicionSeleI[69] = ArreglosGlobales.PosicionSeleI[78];
                            ArreglosGlobales.PosicionSeleI[70] = ArreglosGlobales.PosicionSeleI[79];
                            ArreglosGlobales.PosicionSeleI[71] = ArreglosGlobales.PosicionSeleI[80];
                            ArreglosGlobales.PosicionSeleI[72] = 180;
                            ArreglosGlobales.PosicionSeleI[73] = 62;
                            ArreglosGlobales.PosicionSeleI[74] = 57;
                            ArreglosGlobales.PosicionSeleI[75] = 95;
                            ArreglosGlobales.PosicionSeleI[76] = 146;
                            ArreglosGlobales.PosicionSeleI[77] = 155;
                            ArreglosGlobales.PosicionSeleI[78] = 135;
                            ArreglosGlobales.PosicionSeleI[79] = 143;
                            ArreglosGlobales.PosicionSeleI[80] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI8 = ContSecundarioSeleI.ContadorR_SeleI9;
                            ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                            P.Name = "panelSeleccionI8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI9")
                                    a.Name = "lblSeleccionI8";

                                if (a is Label && a.Name == "labelSeleccionI9")
                                    a.Name = "labelSeleccionI8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
                                    a.Name = "TexboxSeleccionI8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI9")
                                    a.Name = "TexSeleccionI8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI9")
                                    a.Name = "imagenSeleccionI8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                                    a.Name = "EliminarSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI9")
                                    a.Name = "buttonSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio9")
                                    a.Name = "Radio8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI5")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI5")
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
                    ArreglosGlobales.PosicionSeleI[36] = 180;
                    ArreglosGlobales.PosicionSeleI[37] = 62;
                    ArreglosGlobales.PosicionSeleI[38] = 57;
                    ArreglosGlobales.PosicionSeleI[39] = 95;
                    ArreglosGlobales.PosicionSeleI[40] = 146;
                    ArreglosGlobales.PosicionSeleI[41] = 155;
                    ArreglosGlobales.PosicionSeleI[42] = 135;
                    ArreglosGlobales.PosicionSeleI[43] = 143;
                    ArreglosGlobales.PosicionSeleI[44] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI5 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI6")
                        {
                            ArreglosGlobales.PosicionSeleI[36] = ArreglosGlobales.PosicionSeleI[45];
                            ArreglosGlobales.PosicionSeleI[37] = ArreglosGlobales.PosicionSeleI[46];
                            ArreglosGlobales.PosicionSeleI[38] = ArreglosGlobales.PosicionSeleI[47];
                            ArreglosGlobales.PosicionSeleI[39] = ArreglosGlobales.PosicionSeleI[48];
                            ArreglosGlobales.PosicionSeleI[40] = ArreglosGlobales.PosicionSeleI[49];
                            ArreglosGlobales.PosicionSeleI[41] = ArreglosGlobales.PosicionSeleI[50];
                            ArreglosGlobales.PosicionSeleI[42] = ArreglosGlobales.PosicionSeleI[51];
                            ArreglosGlobales.PosicionSeleI[43] = ArreglosGlobales.PosicionSeleI[52];
                            ArreglosGlobales.PosicionSeleI[44] = ArreglosGlobales.PosicionSeleI[53];
                            ContSecundarioSeleI.ContadorR_SeleI5 = ContSecundarioSeleI.ContadorR_SeleI6;
                            ContSecundarioSeleI.ContadorR_SeleI6 = 2;
                            ArreglosGlobales.PosicionSeleI[45] = 180;
                            ArreglosGlobales.PosicionSeleI[46] = 62;
                            ArreglosGlobales.PosicionSeleI[47] = 57;
                            ArreglosGlobales.PosicionSeleI[48] = 95;
                            ArreglosGlobales.PosicionSeleI[49] = 146;
                            ArreglosGlobales.PosicionSeleI[50] = 155;
                            ArreglosGlobales.PosicionSeleI[51] = 135;
                            ArreglosGlobales.PosicionSeleI[52] = 143;
                            ArreglosGlobales.PosicionSeleI[53] = 152;
                            P.Name = "panelSeleccionI5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI6")
                                    a.Name = "lblSeleccionI5";

                                if (a is Label && a.Name == "labelSeleccionI6")
                                    a.Name = "labelSeleccionI5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI6")
                                    a.Name = "TexboxSeleccionI5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI6")
                                    a.Name = "TexSeleccionI5";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI6")
                                    a.Name = "imagenSeleccionI5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI6")
                                    a.Name = "EliminarSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI6")
                                    a.Name = "buttonSeleccionI5";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio6")
                                    a.Name = "Radio5";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI7")
                        {
                            ArreglosGlobales.PosicionSeleI[45] = ArreglosGlobales.PosicionSeleI[54];
                            ArreglosGlobales.PosicionSeleI[46] = ArreglosGlobales.PosicionSeleI[55];
                            ArreglosGlobales.PosicionSeleI[47] = ArreglosGlobales.PosicionSeleI[56];
                            ArreglosGlobales.PosicionSeleI[48] = ArreglosGlobales.PosicionSeleI[57];
                            ArreglosGlobales.PosicionSeleI[49] = ArreglosGlobales.PosicionSeleI[58];
                            ArreglosGlobales.PosicionSeleI[50] = ArreglosGlobales.PosicionSeleI[59];
                            ArreglosGlobales.PosicionSeleI[51] = ArreglosGlobales.PosicionSeleI[60];
                            ArreglosGlobales.PosicionSeleI[52] = ArreglosGlobales.PosicionSeleI[61];
                            ArreglosGlobales.PosicionSeleI[53] = ArreglosGlobales.PosicionSeleI[62];
                            ArreglosGlobales.PosicionSeleI[54] = 180;
                            ArreglosGlobales.PosicionSeleI[55] = 62;
                            ArreglosGlobales.PosicionSeleI[56] = 57;
                            ArreglosGlobales.PosicionSeleI[57] = 95;
                            ArreglosGlobales.PosicionSeleI[58] = 146;
                            ArreglosGlobales.PosicionSeleI[59] = 155;
                            ArreglosGlobales.PosicionSeleI[60] = 135;
                            ArreglosGlobales.PosicionSeleI[61] = 143;
                            ArreglosGlobales.PosicionSeleI[62] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI6 = ContSecundarioSeleI.ContadorR_SeleI7;
                            ContSecundarioSeleI.ContadorR_SeleI7 = 2;
                            P.Name = "panelSeleccionI6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI7")
                                    a.Name = "lblSeleccionI6";

                                if (a is Label && a.Name == "labelSeleccionI7")
                                    a.Name = "labelSeleccionI6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI7")
                                    a.Name = "TexboxSeleccionI6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI7")
                                    a.Name = "TexSeleccionI6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI7")
                                    a.Name = "imagenSeleccionI6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI7")
                                    a.Name = "EliminarSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI7")
                                    a.Name = "buttonSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio7")
                                    a.Name = "Radio6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI8")
                        {
                            ArreglosGlobales.PosicionSeleI[54] = ArreglosGlobales.PosicionSeleI[63];
                            ArreglosGlobales.PosicionSeleI[55] = ArreglosGlobales.PosicionSeleI[64];
                            ArreglosGlobales.PosicionSeleI[56] = ArreglosGlobales.PosicionSeleI[65];
                            ArreglosGlobales.PosicionSeleI[57] = ArreglosGlobales.PosicionSeleI[66];
                            ArreglosGlobales.PosicionSeleI[58] = ArreglosGlobales.PosicionSeleI[67];
                            ArreglosGlobales.PosicionSeleI[59] = ArreglosGlobales.PosicionSeleI[68];
                            ArreglosGlobales.PosicionSeleI[60] = ArreglosGlobales.PosicionSeleI[69];
                            ArreglosGlobales.PosicionSeleI[61] = ArreglosGlobales.PosicionSeleI[70];
                            ArreglosGlobales.PosicionSeleI[62] = ArreglosGlobales.PosicionSeleI[71];
                            ArreglosGlobales.PosicionSeleI[63] = 180;
                            ArreglosGlobales.PosicionSeleI[64] = 62;
                            ArreglosGlobales.PosicionSeleI[65] = 57;
                            ArreglosGlobales.PosicionSeleI[66] = 95;
                            ArreglosGlobales.PosicionSeleI[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleI[69] = 135;
                            ArreglosGlobales.PosicionSeleI[70] = 143;
                            ArreglosGlobales.PosicionSeleI[71] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI7 = ContSecundarioSeleI.ContadorR_SeleI8;
                            ContSecundarioSeleI.ContadorR_SeleI8 = 2;
                            P.Name = "panelSeleccionI7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI8")
                                    a.Name = "lblSeleccionI7";

                                if (a is Label && a.Name == "labelSeleccionI8")
                                    a.Name = "labelSeleccionI7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI8")
                                    a.Name = "TexboxSeleccionI7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI8")
                                    a.Name = "TexSeleccionI7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI8")
                                    a.Name = "imagenSeleccionI7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI8")
                                    a.Name = "EliminarSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI8")
                                    a.Name = "buttonSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio8")
                                    a.Name = "Radio17";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
                        {
                            ArreglosGlobales.PosicionSeleI[63] = ArreglosGlobales.PosicionSeleI[72];
                            ArreglosGlobales.PosicionSeleI[64] = ArreglosGlobales.PosicionSeleI[73];
                            ArreglosGlobales.PosicionSeleI[65] = ArreglosGlobales.PosicionSeleI[74];
                            ArreglosGlobales.PosicionSeleI[66] = ArreglosGlobales.PosicionSeleI[75];
                            ArreglosGlobales.PosicionSeleI[67] = ArreglosGlobales.PosicionSeleI[76];
                            ArreglosGlobales.PosicionSeleI[68] = ArreglosGlobales.PosicionSeleI[77];
                            ArreglosGlobales.PosicionSeleI[69] = ArreglosGlobales.PosicionSeleI[78];
                            ArreglosGlobales.PosicionSeleI[70] = ArreglosGlobales.PosicionSeleI[79];
                            ArreglosGlobales.PosicionSeleI[71] = ArreglosGlobales.PosicionSeleI[80];
                            ArreglosGlobales.PosicionSeleI[72] = 180;
                            ArreglosGlobales.PosicionSeleI[73] = 62;
                            ArreglosGlobales.PosicionSeleI[74] = 57;
                            ArreglosGlobales.PosicionSeleI[75] = 95;
                            ArreglosGlobales.PosicionSeleI[76] = 146;
                            ArreglosGlobales.PosicionSeleI[77] = 155;
                            ArreglosGlobales.PosicionSeleI[78] = 135;
                            ArreglosGlobales.PosicionSeleI[79] = 143;
                            ArreglosGlobales.PosicionSeleI[80] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI8 = ContSecundarioSeleI.ContadorR_SeleI9;
                            ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                            P.Name = "panelSeleccionI8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI9")
                                    a.Name = "lblSeleccionI8";

                                if (a is Label && a.Name == "labelSeleccionI9")
                                    a.Name = "labelSeleccionI8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
                                    a.Name = "TexboxSeleccionI8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI9")
                                    a.Name = "TexSeleccionI8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI9")
                                    a.Name = "imagenSeleccionI8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                                    a.Name = "EliminarSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI9")
                                    a.Name = "buttonSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio9")
                                    a.Name = "Radio8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI6")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI6")
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
                    ArreglosGlobales.PosicionSeleI[45] = 180;
                    ArreglosGlobales.PosicionSeleI[46] = 62;
                    ArreglosGlobales.PosicionSeleI[47] = 57;
                    ArreglosGlobales.PosicionSeleI[48] = 95;
                    ArreglosGlobales.PosicionSeleI[49] = 146;
                    ArreglosGlobales.PosicionSeleI[50] = 155;
                    ArreglosGlobales.PosicionSeleI[51] = 135;
                    ArreglosGlobales.PosicionSeleI[52] = 143;
                    ArreglosGlobales.PosicionSeleI[53] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI6 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI7")
                        {
                            ArreglosGlobales.PosicionSeleI[45] = ArreglosGlobales.PosicionSeleI[54];
                            ArreglosGlobales.PosicionSeleI[46] = ArreglosGlobales.PosicionSeleI[55];
                            ArreglosGlobales.PosicionSeleI[47] = ArreglosGlobales.PosicionSeleI[56];
                            ArreglosGlobales.PosicionSeleI[48] = ArreglosGlobales.PosicionSeleI[57];
                            ArreglosGlobales.PosicionSeleI[49] = ArreglosGlobales.PosicionSeleI[58];
                            ArreglosGlobales.PosicionSeleI[50] = ArreglosGlobales.PosicionSeleI[59];
                            ArreglosGlobales.PosicionSeleI[51] = ArreglosGlobales.PosicionSeleI[60];
                            ArreglosGlobales.PosicionSeleI[52] = ArreglosGlobales.PosicionSeleI[61];
                            ArreglosGlobales.PosicionSeleI[53] = ArreglosGlobales.PosicionSeleI[62];
                            ArreglosGlobales.PosicionSeleI[54] = 180;
                            ArreglosGlobales.PosicionSeleI[55] = 62;
                            ArreglosGlobales.PosicionSeleI[56] = 57;
                            ArreglosGlobales.PosicionSeleI[57] = 95;
                            ArreglosGlobales.PosicionSeleI[58] = 146;
                            ArreglosGlobales.PosicionSeleI[59] = 155;
                            ArreglosGlobales.PosicionSeleI[60] = 135;
                            ArreglosGlobales.PosicionSeleI[61] = 143;
                            ArreglosGlobales.PosicionSeleI[62] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI6 = ContSecundarioSeleI.ContadorR_SeleI7;
                            ContSecundarioSeleI.ContadorR_SeleI7 = 2;
                            P.Name = "panelSeleccionI6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI7")
                                    a.Name = "lblSeleccionI6";

                                if (a is Label && a.Name == "labelSeleccionI7")
                                    a.Name = "labelSeleccionI6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI7")
                                    a.Name = "TexboxSeleccionI6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI7")
                                    a.Name = "TexSeleccionI6";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI7")
                                    a.Name = "imagenSeleccionI6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI7")
                                    a.Name = "EliminarSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI7")
                                    a.Name = "buttonSeleccionI6";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio7")
                                    a.Name = "Radio6";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI8")
                        {
                            ArreglosGlobales.PosicionSeleI[54] = ArreglosGlobales.PosicionSeleI[63];
                            ArreglosGlobales.PosicionSeleI[55] = ArreglosGlobales.PosicionSeleI[64];
                            ArreglosGlobales.PosicionSeleI[56] = ArreglosGlobales.PosicionSeleI[65];
                            ArreglosGlobales.PosicionSeleI[57] = ArreglosGlobales.PosicionSeleI[66];
                            ArreglosGlobales.PosicionSeleI[58] = ArreglosGlobales.PosicionSeleI[67];
                            ArreglosGlobales.PosicionSeleI[59] = ArreglosGlobales.PosicionSeleI[68];
                            ArreglosGlobales.PosicionSeleI[60] = ArreglosGlobales.PosicionSeleI[69];
                            ArreglosGlobales.PosicionSeleI[61] = ArreglosGlobales.PosicionSeleI[70];
                            ArreglosGlobales.PosicionSeleI[62] = ArreglosGlobales.PosicionSeleI[71];
                            ArreglosGlobales.PosicionSeleI[63] = 180;
                            ArreglosGlobales.PosicionSeleI[64] = 62;
                            ArreglosGlobales.PosicionSeleI[65] = 57;
                            ArreglosGlobales.PosicionSeleI[66] = 95;
                            ArreglosGlobales.PosicionSeleI[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleI[69] = 135;
                            ArreglosGlobales.PosicionSeleI[70] = 143;
                            ArreglosGlobales.PosicionSeleI[71] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI7 = ContSecundarioSeleI.ContadorR_SeleI8;
                            ContSecundarioSeleI.ContadorR_SeleI8 = 2;
                            P.Name = "panelSeleccionI7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI8")
                                    a.Name = "lblSeleccionI7";

                                if (a is Label && a.Name == "labelSeleccionI8")
                                    a.Name = "labelSeleccionI7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI8")
                                    a.Name = "TexboxSeleccionI7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI8")
                                    a.Name = "TexSeleccionI7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI8")
                                    a.Name = "imagenSeleccionI7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI8")
                                    a.Name = "EliminarSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI8")
                                    a.Name = "buttonSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio8")
                                    a.Name = "Radio17";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
                        {
                            ArreglosGlobales.PosicionSeleI[63] = ArreglosGlobales.PosicionSeleI[72];
                            ArreglosGlobales.PosicionSeleI[64] = ArreglosGlobales.PosicionSeleI[73];
                            ArreglosGlobales.PosicionSeleI[65] = ArreglosGlobales.PosicionSeleI[74];
                            ArreglosGlobales.PosicionSeleI[66] = ArreglosGlobales.PosicionSeleI[75];
                            ArreglosGlobales.PosicionSeleI[67] = ArreglosGlobales.PosicionSeleI[76];
                            ArreglosGlobales.PosicionSeleI[68] = ArreglosGlobales.PosicionSeleI[77];
                            ArreglosGlobales.PosicionSeleI[69] = ArreglosGlobales.PosicionSeleI[78];
                            ArreglosGlobales.PosicionSeleI[70] = ArreglosGlobales.PosicionSeleI[79];
                            ArreglosGlobales.PosicionSeleI[71] = ArreglosGlobales.PosicionSeleI[80];
                            ArreglosGlobales.PosicionSeleI[72] = 180;
                            ArreglosGlobales.PosicionSeleI[73] = 62;
                            ArreglosGlobales.PosicionSeleI[74] = 57;
                            ArreglosGlobales.PosicionSeleI[75] = 95;
                            ArreglosGlobales.PosicionSeleI[76] = 146;
                            ArreglosGlobales.PosicionSeleI[77] = 155;
                            ArreglosGlobales.PosicionSeleI[78] = 135;
                            ArreglosGlobales.PosicionSeleI[79] = 143;
                            ArreglosGlobales.PosicionSeleI[80] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI8 = ContSecundarioSeleI.ContadorR_SeleI9;
                            ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                            P.Name = "panelSeleccionI8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI9")
                                    a.Name = "lblSeleccionI8";

                                if (a is Label && a.Name == "labelSeleccionI9")
                                    a.Name = "labelSeleccionI8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
                                    a.Name = "TexboxSeleccionI8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI9")
                                    a.Name = "TexSeleccionI8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI9")
                                    a.Name = "imagenSeleccionI8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                                    a.Name = "EliminarSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI9")
                                    a.Name = "buttonSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio9")
                                    a.Name = "Radio8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI7")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI7")
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
                    ArreglosGlobales.PosicionSeleI[54] = 180;
                    ArreglosGlobales.PosicionSeleI[55] = 62;
                    ArreglosGlobales.PosicionSeleI[56] = 57;
                    ArreglosGlobales.PosicionSeleI[57] = 95;
                    ArreglosGlobales.PosicionSeleI[58] = 146;
                    ArreglosGlobales.PosicionSeleI[59] = 155;
                    ArreglosGlobales.PosicionSeleI[60] = 135;
                    ArreglosGlobales.PosicionSeleI[61] = 143;
                    ArreglosGlobales.PosicionSeleI[62] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI7 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI8")
                        {
                            ArreglosGlobales.PosicionSeleI[54] = ArreglosGlobales.PosicionSeleI[63];
                            ArreglosGlobales.PosicionSeleI[55] = ArreglosGlobales.PosicionSeleI[64];
                            ArreglosGlobales.PosicionSeleI[56] = ArreglosGlobales.PosicionSeleI[65];
                            ArreglosGlobales.PosicionSeleI[57] = ArreglosGlobales.PosicionSeleI[66];
                            ArreglosGlobales.PosicionSeleI[58] = ArreglosGlobales.PosicionSeleI[67];
                            ArreglosGlobales.PosicionSeleI[59] = ArreglosGlobales.PosicionSeleI[68];
                            ArreglosGlobales.PosicionSeleI[60] = ArreglosGlobales.PosicionSeleI[69];
                            ArreglosGlobales.PosicionSeleI[61] = ArreglosGlobales.PosicionSeleI[70];
                            ArreglosGlobales.PosicionSeleI[62] = ArreglosGlobales.PosicionSeleI[71];
                            ArreglosGlobales.PosicionSeleI[63] = 180;
                            ArreglosGlobales.PosicionSeleI[64] = 62;
                            ArreglosGlobales.PosicionSeleI[65] = 57;
                            ArreglosGlobales.PosicionSeleI[66] = 95;
                            ArreglosGlobales.PosicionSeleI[67] = 146;
                            ArreglosGlobales.PosicionSeleM[68] = 155;
                            ArreglosGlobales.PosicionSeleI[69] = 135;
                            ArreglosGlobales.PosicionSeleI[70] = 143;
                            ArreglosGlobales.PosicionSeleI[71] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI7 = ContSecundarioSeleI.ContadorR_SeleI8;
                            ContSecundarioSeleI.ContadorR_SeleI8 = 2;
                            P.Name = "panelSeleccionI7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI8")
                                    a.Name = "lblSeleccionI7";

                                if (a is Label && a.Name == "labelSeleccionI8")
                                    a.Name = "labelSeleccionI7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI8")
                                    a.Name = "TexboxSeleccionI7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI8")
                                    a.Name = "TexSeleccionI7";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI8")
                                    a.Name = "imagenSeleccionI7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI8")
                                    a.Name = "EliminarSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI8")
                                    a.Name = "buttonSeleccionI7";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio8")
                                    a.Name = "Radio17";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
                        {
                            ArreglosGlobales.PosicionSeleI[63] = ArreglosGlobales.PosicionSeleI[72];
                            ArreglosGlobales.PosicionSeleI[64] = ArreglosGlobales.PosicionSeleI[73];
                            ArreglosGlobales.PosicionSeleI[65] = ArreglosGlobales.PosicionSeleI[74];
                            ArreglosGlobales.PosicionSeleI[66] = ArreglosGlobales.PosicionSeleI[75];
                            ArreglosGlobales.PosicionSeleI[67] = ArreglosGlobales.PosicionSeleI[76];
                            ArreglosGlobales.PosicionSeleI[68] = ArreglosGlobales.PosicionSeleI[77];
                            ArreglosGlobales.PosicionSeleI[69] = ArreglosGlobales.PosicionSeleI[78];
                            ArreglosGlobales.PosicionSeleI[70] = ArreglosGlobales.PosicionSeleI[79];
                            ArreglosGlobales.PosicionSeleI[71] = ArreglosGlobales.PosicionSeleI[80];
                            ArreglosGlobales.PosicionSeleI[72] = 180;
                            ArreglosGlobales.PosicionSeleI[73] = 62;
                            ArreglosGlobales.PosicionSeleI[74] = 57;
                            ArreglosGlobales.PosicionSeleI[75] = 95;
                            ArreglosGlobales.PosicionSeleI[76] = 146;
                            ArreglosGlobales.PosicionSeleI[77] = 155;
                            ArreglosGlobales.PosicionSeleI[78] = 135;
                            ArreglosGlobales.PosicionSeleI[79] = 143;
                            ArreglosGlobales.PosicionSeleI[80] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI8 = ContSecundarioSeleI.ContadorR_SeleI9;
                            ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                            P.Name = "panelSeleccionI8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI9")
                                    a.Name = "lblSeleccionI8";

                                if (a is Label && a.Name == "labelSeleccionI9")
                                    a.Name = "labelSeleccionI8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
                                    a.Name = "TexboxSeleccionI8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI9")
                                    a.Name = "TexSeleccionI8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI9")
                                    a.Name = "imagenSeleccionI8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                                    a.Name = "EliminarSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI9")
                                    a.Name = "buttonSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio9")
                                    a.Name = "Radio8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI8")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI8")
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
                    ArreglosGlobales.PosicionSeleI[63] = 180;
                    ArreglosGlobales.PosicionSeleI[64] = 62;
                    ArreglosGlobales.PosicionSeleI[65] = 57;
                    ArreglosGlobales.PosicionSeleI[66] = 95;
                    ArreglosGlobales.PosicionSeleI[67] = 146;
                    ArreglosGlobales.PosicionSeleI[68] = 155;
                    ArreglosGlobales.PosicionSeleI[69] = 135;
                    ArreglosGlobales.PosicionSeleI[70] = 143;
                    ArreglosGlobales.PosicionSeleI[71] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI8 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
                        {
                            ArreglosGlobales.PosicionSeleI[63] = ArreglosGlobales.PosicionSeleI[72];
                            ArreglosGlobales.PosicionSeleI[64] = ArreglosGlobales.PosicionSeleI[73];
                            ArreglosGlobales.PosicionSeleI[65] = ArreglosGlobales.PosicionSeleI[74];
                            ArreglosGlobales.PosicionSeleI[66] = ArreglosGlobales.PosicionSeleI[75];
                            ArreglosGlobales.PosicionSeleI[67] = ArreglosGlobales.PosicionSeleI[76];
                            ArreglosGlobales.PosicionSeleI[68] = ArreglosGlobales.PosicionSeleI[77];
                            ArreglosGlobales.PosicionSeleI[69] = ArreglosGlobales.PosicionSeleI[78];
                            ArreglosGlobales.PosicionSeleI[70] = ArreglosGlobales.PosicionSeleI[79];
                            ArreglosGlobales.PosicionSeleI[71] = ArreglosGlobales.PosicionSeleI[80];
                            ArreglosGlobales.PosicionSeleI[72] = 180;
                            ArreglosGlobales.PosicionSeleI[73] = 62;
                            ArreglosGlobales.PosicionSeleI[74] = 57;
                            ArreglosGlobales.PosicionSeleI[75] = 95;
                            ArreglosGlobales.PosicionSeleI[76] = 146;
                            ArreglosGlobales.PosicionSeleI[77] = 155;
                            ArreglosGlobales.PosicionSeleI[78] = 135;
                            ArreglosGlobales.PosicionSeleI[79] = 143;
                            ArreglosGlobales.PosicionSeleI[80] = 152;
                            ContSecundarioSeleI.ContadorR_SeleI8 = ContSecundarioSeleI.ContadorR_SeleI9;
                            ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                            P.Name = "panelSeleccionI8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI9")
                                    a.Name = "lblSeleccionI8";

                                if (a is Label && a.Name == "labelSeleccionI9")
                                    a.Name = "labelSeleccionI8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI9")
                                    a.Name = "TexboxSeleccionI8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI9")
                                    a.Name = "TexSeleccionI8";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI9")
                                    a.Name = "imagenSeleccionI8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                                    a.Name = "EliminarSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI9")
                                    a.Name = "buttonSeleccionI8";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio9")
                                    a.Name = "Radio8";
                            }
                        }
                    }
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI9")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI9")
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
                    ArreglosGlobales.PosicionSeleI[72] = 180;
                    ArreglosGlobales.PosicionSeleI[73] = 62;
                    ArreglosGlobales.PosicionSeleI[74] = 57;
                    ArreglosGlobales.PosicionSeleI[75] = 95;
                    ArreglosGlobales.PosicionSeleI[76] = 146;
                    ArreglosGlobales.PosicionSeleI[77] = 155;
                    ArreglosGlobales.PosicionSeleI[78] = 135;
                    ArreglosGlobales.PosicionSeleI[79] = 143;
                    ArreglosGlobales.PosicionSeleI[80] = 152;
                    ContSecundarioSeleI.ContadorR_SeleI9 = 2;
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
                        {
                            P.Name = "panelSeleccionI9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblSeleccionI10")
                                    a.Name = "lblSeleccionI9";

                                if (a is Label && a.Name == "labelSeleccionI10")
                                    a.Name = "labelSeleccionI9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxSeleccionI10")
                                    a.Name = "TexboxSeleccionI9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexSeleccionI10")
                                    a.Name = "TexSeleccionI9";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenSeleccionI10")
                                    a.Name = "imagenSeleccionI9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                                    a.Name = "EliminarSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJButton>())
                            {
                                if (a is RJButton && a.Name == "buttonSeleccionI10")
                                    a.Name = "buttonSeleccionI9";
                            }
                            foreach (var a in P.Controls.OfType<RJRadioButton>())
                            {
                                if (a is RadioButton && a.Name == "Radio10")
                                    a.Name = "Radio9";
                            }
                        }
                    }
                    Obtener_Contadores.Total_SeleI--;
                }

            }
            else if (EliminarSeleI.Name == "EliminarSeleccionI10")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelSeleccionI10")
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
                    Obtener_Contadores.Total_SeleI--;
                }

            }
        }

        public void AgregarCampo(RJButton ButtonSeleI, PanelRedondeado tempSeleI, PanelRedondeado panelLateral, Color normalColor)
        {

            if (ButtonSeleI.Name == "buttonSeleccionI1")
            {
                ContSecundarioSeleI.ContadorR_SeleI++;
                ArreglosGlobales.PosicionSeleI[0] += 41;
                ArreglosGlobales.PosicionSeleI[1] += 41;
                ArreglosGlobales.PosicionSeleI[2] += 41;
                ArreglosGlobales.PosicionSeleI[3] += 41;
                ArreglosGlobales.PosicionSeleI[4] += 41;
                ArreglosGlobales.PosicionSeleI[5] += 41;
                ArreglosGlobales.PosicionSeleI[6] += 41;
                ArreglosGlobales.PosicionSeleI[7] += 41;
                ArreglosGlobales.PosicionSeleI[8] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[0];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[1]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[2]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[1]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;

                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[3]);

                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI1")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[4]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI1")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[4]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[6]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[7]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[8]);
                    }
                    else if (a is Label && a.Name == "labelSeleccionI1")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[5]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[8]);

                    }
                }
            }
            else if (ButtonSeleI.Name == "buttonSeleccionI2")
            {
                ContSecundarioSeleI.ContadorR_SeleI2++;
                ArreglosGlobales.PosicionSeleI[9] += 41;
                ArreglosGlobales.PosicionSeleI[10] += 41;
                ArreglosGlobales.PosicionSeleI[11] += 41;
                ArreglosGlobales.PosicionSeleI[12] += 41;
                ArreglosGlobales.PosicionSeleI[13] += 41;
                ArreglosGlobales.PosicionSeleI[14] += 41;
                ArreglosGlobales.PosicionSeleI[15] += 41;
                ArreglosGlobales.PosicionSeleI[16] += 41;
                ArreglosGlobales.PosicionSeleI[17] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[9];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI2.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[10]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI2.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[11]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI2.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI2.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[10]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[12]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI2")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[13]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI2")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[13]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[15]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[16]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[17]);
                    }
                    else if (a is Label && a.Name == "labelSeleccionI2")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[14]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[17]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI3")
            {
                ArreglosGlobales.PosicionSeleI[18] += 41;
                ArreglosGlobales.PosicionSeleI[19] += 41;
                ArreglosGlobales.PosicionSeleI[20] += 41;
                ArreglosGlobales.PosicionSeleI[21] += 41;
                ArreglosGlobales.PosicionSeleI[22] += 41;
                ArreglosGlobales.PosicionSeleI[23] += 41;
                ArreglosGlobales.PosicionSeleI[24] += 41;
                ArreglosGlobales.PosicionSeleI[25] += 41;
                ArreglosGlobales.PosicionSeleI[26] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[18];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI3.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[19]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI3.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[20]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI3.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI3.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[19]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[21]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI3")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[22]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI3")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[22]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[24]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[25]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[26]);
                    }
                    else if (a is Label && a.Name == "labelSeleccionI3")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[23]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[26]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI3++;

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI4")
            {
                ArreglosGlobales.PosicionSeleI[27] += 41;
                ArreglosGlobales.PosicionSeleI[28] += 41;
                ArreglosGlobales.PosicionSeleI[29] += 41;
                ArreglosGlobales.PosicionSeleI[30] += 41;
                ArreglosGlobales.PosicionSeleI[31] += 41;
                ArreglosGlobales.PosicionSeleI[32] += 41;
                ArreglosGlobales.PosicionSeleI[33] += 41;
                ArreglosGlobales.PosicionSeleI[34] += 41;
                ArreglosGlobales.PosicionSeleI[35] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[27];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI4.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[28]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI4.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[29]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI4.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI4.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[28]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[30]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI4")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[31]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI4")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[31]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[33]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[34]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[35]);
                    }
                    if (a is Label && a.Name == "labelSeleccionI4")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[32]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[35]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI4++;

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI5")
            {
                ArreglosGlobales.PosicionSeleI[36] += 41;
                ArreglosGlobales.PosicionSeleI[37] += 41;
                ArreglosGlobales.PosicionSeleI[38] += 41;
                ArreglosGlobales.PosicionSeleI[39] += 41;
                ArreglosGlobales.PosicionSeleI[40] += 41;
                ArreglosGlobales.PosicionSeleI[41] += 41;
                ArreglosGlobales.PosicionSeleI[42] += 41;
                ArreglosGlobales.PosicionSeleI[43] += 41;
                ArreglosGlobales.PosicionSeleI[44] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[36];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI5.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[37]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI5.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[38]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI5.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI5.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[37]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[39]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI5")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[40]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI5")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[40]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[42]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[43]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[44]);
                    }
                    if (a is Label && a.Name == "labelSeleccionI5")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[41]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[44]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI5++;

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI6")
            {
                ArreglosGlobales.PosicionSeleI[45] += 41;
                ArreglosGlobales.PosicionSeleI[46] += 41;
                ArreglosGlobales.PosicionSeleI[47] += 41;
                ArreglosGlobales.PosicionSeleI[48] += 41;
                ArreglosGlobales.PosicionSeleI[49] += 41;
                ArreglosGlobales.PosicionSeleI[50] += 41;
                ArreglosGlobales.PosicionSeleI[51] += 41;
                ArreglosGlobales.PosicionSeleI[52] += 41;
                ArreglosGlobales.PosicionSeleI[53] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[45];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI6.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[46]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI6.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[47]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI6.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI6.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[46]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[48]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI6")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[49]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI6")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[49]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[51]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[52]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[53]);
                    }
                    if (a is Label && a.Name == "labelSeleccionI6")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[50]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[53]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI6++;

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI7")
            {
                ArreglosGlobales.PosicionSeleI[54] += 41;
                ArreglosGlobales.PosicionSeleI[55] += 41;
                ArreglosGlobales.PosicionSeleI[56] += 41;
                ArreglosGlobales.PosicionSeleI[57] += 41;
                ArreglosGlobales.PosicionSeleI[58] += 41;
                ArreglosGlobales.PosicionSeleI[59] += 41;
                ArreglosGlobales.PosicionSeleI[60] += 41;
                ArreglosGlobales.PosicionSeleI[61] += 41;
                ArreglosGlobales.PosicionSeleI[62] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[54];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI7.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[55]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI7.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[56]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI7.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI7.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[55]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[57]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI7")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[58]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI7")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[58]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[60]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[61]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[62]);
                    }
                    if (a is Label && a.Name == "labelSeleccionI7")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[59]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[62]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI7++;

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI8")
            {
                ArreglosGlobales.PosicionSeleI[63] += 41;
                ArreglosGlobales.PosicionSeleI[64] += 41;
                ArreglosGlobales.PosicionSeleI[65] += 41;
                ArreglosGlobales.PosicionSeleI[66] += 41;
                ArreglosGlobales.PosicionSeleI[67] += 41;
                ArreglosGlobales.PosicionSeleI[68] += 41;
                ArreglosGlobales.PosicionSeleI[69] += 41;
                ArreglosGlobales.PosicionSeleI[70] += 41;
                ArreglosGlobales.PosicionSeleI[71] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[63];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI8.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[64]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI8.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[65]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI8.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI8.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[64]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[66]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI8")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[67]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI8")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[67]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[69]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[70]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[71]);
                    }
                    if (a is Label && a.Name == "labelSeleccionI8")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[68]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[71]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI8++;

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI9")
            {
                ArreglosGlobales.PosicionSeleI[72] += 41;
                ArreglosGlobales.PosicionSeleI[73] += 41;
                ArreglosGlobales.PosicionSeleI[74] += 41;
                ArreglosGlobales.PosicionSeleI[75] += 41;
                ArreglosGlobales.PosicionSeleI[76] += 41;
                ArreglosGlobales.PosicionSeleI[77] += 41;
                ArreglosGlobales.PosicionSeleI[78] += 41;
                ArreglosGlobales.PosicionSeleI[79] += 41;
                ArreglosGlobales.PosicionSeleI[80] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[72];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI9.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[73]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI9.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[74]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI9.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI9.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[73]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[75]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI9")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[76]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI9")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[76]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[78]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[79]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[80]);
                    }
                    if (a is Label && a.Name == "labelSeleccionI9")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[77]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[80]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI9++;

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI10")
            {
                ArreglosGlobales.PosicionSeleI[81] += 41;
                ArreglosGlobales.PosicionSeleI[82] += 41;
                ArreglosGlobales.PosicionSeleI[83] += 41;
                ArreglosGlobales.PosicionSeleI[84] += 41;
                ArreglosGlobales.PosicionSeleI[85] += 41;
                ArreglosGlobales.PosicionSeleI[86] += 41;
                ArreglosGlobales.PosicionSeleI[87] += 41;
                ArreglosGlobales.PosicionSeleI[88] += 41;
                ArreglosGlobales.PosicionSeleI[89] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[81];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI10.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[82]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI10.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[83]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI10.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI10.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[82]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[84]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI10")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleI[85]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI10")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleI[85]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[87]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[88]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[89]);
                    }
                    if (a is Label && a.Name == "labelSeleccionI10")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[86]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[89]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI10++;

            }
            else if (ButtonSeleI.Name == "buttonSeleccionI11")
            {
                ArreglosGlobales.PosicionSeleI[90] += 41;
                ArreglosGlobales.PosicionSeleI[91] += 41;
                ArreglosGlobales.PosicionSeleI[92] += 41;
                ArreglosGlobales.PosicionSeleI[93] += 41;
                ArreglosGlobales.PosicionSeleI[94] += 41;
                ArreglosGlobales.PosicionSeleI[95] += 41;
                ArreglosGlobales.PosicionSeleI[96] += 41;
                ArreglosGlobales.PosicionSeleI[97] += 41;
                ArreglosGlobales.PosicionSeleI[98] += 41;
                tempSeleI.Height = ArreglosGlobales.PosicionSeleI[90];
                tempSeleI.BorderRadius = 24;
                panelLateral.BorderRadius = 0;
                panelLateral.BackColor = Color.FromArgb(27, 102, 218);

                RJRadioButton RadioSeleccionI = new RJRadioButton
                {
                    Name = "Radio" + ContSecundarioSeleI.ContadorR_SeleI11.ToString(),
                    CheckedColor = normalColor,
                    Location = new Point(39, ArreglosGlobales.PosicionSeleI[91]),
                    Size = new Size(21, 21)
                };
                tempSeleI.Controls.Add(RadioSeleccionI);

                BunifuMaterialTextbox TexboxOpcciónSeleccionI = new BunifuMaterialTextbox
                {
                    Name = "TexboxOpcciónSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI11.ToString(),
                    LineIdleColor = Color.White,
                    LineFocusedColor = normalColor,
                    LineMouseHoverColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.FromArgb(64, 64, 64),
                    Location = new Point(60, ArreglosGlobales.PosicionSeleI[92]),
                    Width = 430,
                    Text = "Opcción" + ContSecundarioSeleI.ContadorR_SeleI11.ToString()
                };
                BunifuImageButton EliminarOpccionSeleccionI = new BunifuImageButton
                {
                    Name = "EliminarOpccionSeleccionI" + ContSecundarioSeleI.ContadorR_SeleI11.ToString(),
                    BackColor = Color.White,
                    Location = new Point(477, ArreglosGlobales.PosicionSeleI[91]),
                    Size = new Size(20, 20),
                    Image = Properties.Resources.Close_512px,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Zoom = 10
                };

                tempSeleI.Controls.Add(EliminarOpccionSeleccionI);
                tempSeleI.Controls.Add(TexboxOpcciónSeleccionI);
                tempEliminarOpcSeleI = EliminarOpccionSeleccionI;
                tempEliminarOpcSeleI.Click += EliminarOpccionSeleI_Click;
                ButtonSeleI.Location = new Point(60, ArreglosGlobales.PosicionSeleI[93]);
                foreach (var a in tempSeleI.Controls.OfType<PictureBox>())
                {
                    if (a is PictureBox && a.Name == "imagenSeleccionI11")
                        a.Location = new Point(17, ArreglosGlobales.PosicionSeleM[94]);
                }
                foreach (var a in tempSeleI.Controls.OfType<BunifuImageButton>())
                {
                    if (a is BunifuImageButton && a.Name == "EliminarSeleccionI11")
                        a.Location = new Point(340, ArreglosGlobales.PosicionSeleM[94]);
                }
                foreach (var a in tempSeleI.Controls.OfType<PanelRedondeado>())
                {
                    if (a is PanelRedondeado && a.Width == 500)
                    {
                        a.Location = new Point(15, ArreglosGlobales.PosicionSeleI[96]);
                    }
                    else if (a is PanelRedondeado && a.Width == 2)
                    {
                        a.Location = new Point(375, ArreglosGlobales.PosicionSeleI[97]);
                    }
                }
                foreach (var a in tempSeleI.Controls.OfType<Label>())
                {
                    if (a is Label && a.Text == "Obligatoria")
                    {
                        a.Location = new Point(380, ArreglosGlobales.PosicionSeleI[98]);
                    }
                    if (a is Label && a.Name == "labelSeleccionI11")
                        a.Location = new Point(55, ArreglosGlobales.PosicionSeleI[95]);
                }
                foreach (var a in tempSeleI.Controls.OfType<RJToggleButton>())
                {
                    if (a is RJToggleButton && a.Width == 40)
                    {
                        a.Location = new Point(470, ArreglosGlobales.PosicionSeleI[98]);
                    }
                }
                MessageBox.Show(ButtonSeleI.Name);
                ContSecundarioSeleI.ContadorR_SeleI11++;

            }

        }

        private void EliminarOpccionSeleI_Click(object sender, EventArgs e)
        {
            tempEliminarOpcSeleI = sender as BunifuImageButton;
            EliminarOpcSeleI.Pregunta(tempPanelPrincipal_SeleI, tempEliminarOpcSeleI);

        }
    }
}
