using Bunifu.Framework.UI;
using CapaPresentacion.Globales;
using Controles_personalizados;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Controles_Dinamicos.Seleccion_Multiple
{
    public class Cambiarlocation
    {
        public void cambio(PanelRedondeado tempPanelPrincipal_SeleM, int pos1,int pos2,int contador)
        {
            switch (contador)
            {
                case 2:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }
                        break;
                    }
                case 3:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 50;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 100;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 100;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 150;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 150;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 6:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 200;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 200;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 7:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 250;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 250;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 8:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 300;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 300;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM9")
                            {
                                b.Name = "CheckBoxSeleccionM8";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM9")
                            {
                                b.Name = "TexboxOpcciónSeleccionM8";
                                b.Text = "Opcción8";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM9")
                            {
                                b.Name = "EliminarOpccionSeleccionM8";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 9:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 350;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 350;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM9")
                            {
                                b.Name = "CheckBoxSeleccionM8";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM9")
                            {
                                b.Name = "TexboxOpcciónSeleccionM8";
                                b.Text = "Opcción8";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM9")
                            {
                                b.Name = "EliminarOpccionSeleccionM8";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM10")
                            {
                                b.Name = "CheckBoxSeleccionM9";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM10")
                            {
                                b.Name = "TexboxOpcciónSeleccionM9";
                                b.Text = "Opcción9";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM10")
                            {
                                b.Name = "EliminarOpccionSeleccionM9";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 10:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 400;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 400;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM9")
                            {
                                b.Name = "CheckBoxSeleccionM8";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM9")
                            {
                                b.Name = "TexboxOpcciónSeleccionM8";
                                b.Text = "Opcción8";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM9")
                            {
                                b.Name = "EliminarOpccionSeleccionM8";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM10")
                            {
                                b.Name = "CheckBoxSeleccionM9";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM10")
                            {
                                b.Name = "TexboxOpcciónSeleccionM9";
                                b.Text = "Opcción9";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM10")
                            {
                                b.Name = "EliminarOpccionSeleccionM9";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM11")
                            {
                                b.Name = "CheckBoxSeleccionM10";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM11")
                            {
                                b.Name = "TexboxOpcciónSeleccionM10";
                                b.Text = "Opcción10";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM11")
                            {
                                b.Name = "EliminarOpccionSeleccionM10";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 11:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 450;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 450;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM9")
                            {
                                b.Name = "CheckBoxSeleccionM8";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM9")
                            {
                                b.Name = "TexboxOpcciónSeleccionM8";
                                b.Text = "Opcción8";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM9")
                            {
                                b.Name = "EliminarOpccionSeleccionM8";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM10")
                            {
                                b.Name = "CheckBoxSeleccionM9";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM10")
                            {
                                b.Name = "TexboxOpcciónSeleccionM9";
                                b.Text = "Opcción9";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM10")
                            {
                                b.Name = "EliminarOpccionSeleccionM9";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM11")
                            {
                                b.Name = "CheckBoxSeleccionM10";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM11")
                            {
                                b.Name = "TexboxOpcciónSeleccionM10";
                                b.Text = "Opcción10";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM11")
                            {
                                b.Name = "EliminarOpccionSeleccionM10";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM12")
                            {
                                b.Name = "CheckBoxSeleccionM11";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM12")
                            {
                                b.Name = "TexboxOpcciónSeleccionM11";
                                b.Text = "Opcción11";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM12")
                            {
                                b.Name = "EliminarOpccionSeleccionM11";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 12:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 500;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 500;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM9")
                            {
                                b.Name = "CheckBoxSeleccionM8";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM9")
                            {
                                b.Name = "TexboxOpcciónSeleccionM8";
                                b.Text = "Opcción8";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM9")
                            {
                                b.Name = "EliminarOpccionSeleccionM8";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM10")
                            {
                                b.Name = "CheckBoxSeleccionM9";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM10")
                            {
                                b.Name = "TexboxOpcciónSeleccionM9";
                                b.Text = "Opcción9";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM10")
                            {
                                b.Name = "EliminarOpccionSeleccionM9";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM11")
                            {
                                b.Name = "CheckBoxSeleccionM10";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM11")
                            {
                                b.Name = "TexboxOpcciónSeleccionM10";
                                b.Text = "Opcción10";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM11")
                            {
                                b.Name = "EliminarOpccionSeleccionM10";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM12")
                            {
                                b.Name = "CheckBoxSeleccionM11";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM12")
                            {
                                b.Name = "TexboxOpcciónSeleccionM11";
                                b.Text = "Opcción11";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM12")
                            {
                                b.Name = "EliminarOpccionSeleccionM11";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM13")
                            {
                                b.Name = "CheckBoxSeleccionM12";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM13")
                            {
                                b.Name = "TexboxOpcciónSeleccionM12";
                                b.Text = "Opcción12";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM13")
                            {
                                b.Name = "EliminarOpccionSeleccionM12";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 13:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 550;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 550;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM9")
                            {
                                b.Name = "CheckBoxSeleccionM8";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM9")
                            {
                                b.Name = "TexboxOpcciónSeleccionM8";
                                b.Text = "Opcción8";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM9")
                            {
                                b.Name = "EliminarOpccionSeleccionM8";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM10")
                            {
                                b.Name = "CheckBoxSeleccionM9";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM10")
                            {
                                b.Name = "TexboxOpcciónSeleccionM9";
                                b.Text = "Opcción9";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM10")
                            {
                                b.Name = "EliminarOpccionSeleccionM9";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM11")
                            {
                                b.Name = "CheckBoxSeleccionM10";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM11")
                            {
                                b.Name = "TexboxOpcciónSeleccionM10";
                                b.Text = "Opcción10";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM11")
                            {
                                b.Name = "EliminarOpccionSeleccionM10";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM12")
                            {
                                b.Name = "CheckBoxSeleccionM11";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM12")
                            {
                                b.Name = "TexboxOpcciónSeleccionM11";
                                b.Text = "Opcción11";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM12")
                            {
                                b.Name = "EliminarOpccionSeleccionM11";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM13")
                            {
                                b.Name = "CheckBoxSeleccionM12";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM13")
                            {
                                b.Name = "TexboxOpcciónSeleccionM12";
                                b.Text = "Opcción12";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM13")
                            {
                                b.Name = "EliminarOpccionSeleccionM12";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM14")
                            {
                                b.Name = "CheckBoxSeleccionM13";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM14")
                            {
                                b.Name = "TexboxOpcciónSeleccionM13";
                                b.Text = "Opcción13";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM14")
                            {
                                b.Name = "EliminarOpccionSeleccionM13";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 14:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 600;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 600;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM9")
                            {
                                b.Name = "CheckBoxSeleccionM8";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM9")
                            {
                                b.Name = "TexboxOpcciónSeleccionM8";
                                b.Text = "Opcción8";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM9")
                            {
                                b.Name = "EliminarOpccionSeleccionM8";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM10")
                            {
                                b.Name = "CheckBoxSeleccionM9";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM10")
                            {
                                b.Name = "TexboxOpcciónSeleccionM9";
                                b.Text = "Opcción9";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM10")
                            {
                                b.Name = "EliminarOpccionSeleccionM9";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM11")
                            {
                                b.Name = "CheckBoxSeleccionM10";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM11")
                            {
                                b.Name = "TexboxOpcciónSeleccionM10";
                                b.Text = "Opcción10";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM11")
                            {
                                b.Name = "EliminarOpccionSeleccionM10";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM12")
                            {
                                b.Name = "CheckBoxSeleccionM11";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM12")
                            {
                                b.Name = "TexboxOpcciónSeleccionM11";
                                b.Text = "Opcción11";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM12")
                            {
                                b.Name = "EliminarOpccionSeleccionM11";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM13")
                            {
                                b.Name = "CheckBoxSeleccionM12";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM13")
                            {
                                b.Name = "TexboxOpcciónSeleccionM12";
                                b.Text = "Opcción12";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM13")
                            {
                                b.Name = "EliminarOpccionSeleccionM12";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM14")
                            {
                                b.Name = "CheckBoxSeleccionM13";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM14")
                            {
                                b.Name = "TexboxOpcciónSeleccionM13";
                                b.Text = "Opcción13";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM14")
                            {
                                b.Name = "EliminarOpccionSeleccionM13";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM15")
                            {
                                b.Name = "CheckBoxSeleccionM14";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM15")
                            {
                                b.Name = "TexboxOpcciónSeleccionM14";
                                b.Text = "Opcción14";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM15")
                            {
                                b.Name = "EliminarOpccionSeleccionM14";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
                case 15:
                    {
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM3")
                            {
                                b.Name = "CheckBoxSeleccionM2";
                                ArreglosGlobales.PosicionSeleM[pos1] -= 650;
                                ArreglosGlobales.PosicionSeleM[pos2] -= 650;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM3")
                            {
                                b.Name = "TexboxOpcciónSeleccionM2";
                                b.Text = "Opcción2";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM3")
                            {
                                b.Name = "EliminarOpccionSeleccionM2";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }

                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM4")
                            {
                                b.Name = "CheckBoxSeleccionM3";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM4")
                            {
                                b.Name = "TexboxOpcciónSeleccionM3";
                                b.Text = "Opcción3";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM4")
                            {
                                b.Name = "EliminarOpccionSeleccionM3";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM5")
                            {
                                b.Name = "CheckBoxSeleccionM4";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM5")
                            {
                                b.Name = "TexboxOpcciónSeleccionM4";
                                b.Text = "Opcción4";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM5")
                            {
                                b.Name = "EliminarOpccionSeleccionM4";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM6")
                            {
                                b.Name = "CheckBoxSeleccionM5";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM6")
                            {
                                b.Name = "TexboxOpcciónSeleccionM5";
                                b.Text = "Opcción5";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM6")
                            {
                                b.Name = "EliminarOpccionSeleccionM5";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM7")
                            {
                                b.Name = "CheckBoxSeleccionM6";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM7")
                            {
                                b.Name = "TexboxOpcciónSeleccionM6";
                                b.Text = "Opcción6";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM7")
                            {
                                b.Name = "EliminarOpccionSeleccionM6";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM8")
                            {
                                b.Name = "CheckBoxSeleccionM7";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM8")
                            {
                                b.Name = "TexboxOpcciónSeleccionM7";
                                b.Text = "Opcción7";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM8")
                            {
                                b.Name = "EliminarOpccionSeleccionM7";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM9")
                            {
                                b.Name = "CheckBoxSeleccionM8";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM9")
                            {
                                b.Name = "TexboxOpcciónSeleccionM8";
                                b.Text = "Opcción8";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM9")
                            {
                                b.Name = "EliminarOpccionSeleccionM8";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM10")
                            {
                                b.Name = "CheckBoxSeleccionM9";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM10")
                            {
                                b.Name = "TexboxOpcciónSeleccionM9";
                                b.Text = "Opcción9";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM10")
                            {
                                b.Name = "EliminarOpccionSeleccionM9";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM11")
                            {
                                b.Name = "CheckBoxSeleccionM10";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM11")
                            {
                                b.Name = "TexboxOpcciónSeleccionM10";
                                b.Text = "Opcción10";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM11")
                            {
                                b.Name = "EliminarOpccionSeleccionM10";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM12")
                            {
                                b.Name = "CheckBoxSeleccionM11";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM12")
                            {
                                b.Name = "TexboxOpcciónSeleccionM11";
                                b.Text = "Opcción11";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM12")
                            {
                                b.Name = "EliminarOpccionSeleccionM11";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM13")
                            {
                                b.Name = "CheckBoxSeleccionM12";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM13")
                            {
                                b.Name = "TexboxOpcciónSeleccionM12";
                                b.Text = "Opcción12";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM13")
                            {
                                b.Name = "EliminarOpccionSeleccionM12";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM14")
                            {
                                b.Name = "CheckBoxSeleccionM13";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM14")
                            {
                                b.Name = "TexboxOpcciónSeleccionM13";
                                b.Text = "Opcción13";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM14")
                            {
                                b.Name = "EliminarOpccionSeleccionM13";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }

                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (b is BunifuCheckbox && b.Name == "CheckBoxSeleccionM15")
                            {
                                b.Name = "CheckBoxSeleccionM14";
                                ArreglosGlobales.PosicionSeleM[pos2] += 50;
                                ArreglosGlobales.PosicionSeleM[pos1] += 50;
                                b.Location = new Point(27, ArreglosGlobales.PosicionSeleM[pos1]);

                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (b is BunifuMaterialTextbox && b.Name == "TexboxOpcciónSeleccionM15")
                            {
                                b.Name = "TexboxOpcciónSeleccionM14";
                                b.Text = "Opcción14";
                                b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[pos2]);
                            }
                        }
                        foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (b is BunifuImageButton && b.Name == "EliminarOpccionSeleccionM15")
                            {
                                b.Name = "EliminarOpccionSeleccionM14";
                                b.Location = new Point(688, ArreglosGlobales.PosicionSeleM[pos1]);
                            }
                        }
                        break;
                    }
            }

        }
    }
}
