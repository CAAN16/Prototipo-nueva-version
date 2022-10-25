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
using System.Windows.Forms;

namespace CapaPresentacion.Controles_Dinamicos.Seleccion_Multiple
{
    public class AccionSecundaria_TipoSeleccionM
    {
        public void Pregunta(PanelRedondeado tempPanelPrincipal_SeleM, BunifuImageButton tempEliminarOpcSeleM)
        {
            Cambiarlocation cambiarlocation = new Cambiarlocation();
            switch (tempEliminarOpcSeleM.Name)
            {
                case "EliminarOpccionSeleccionM2":
                {
                        foreach (var a in tempPanelPrincipal_SeleM.Controls.OfType<BunifuCheckbox>())
                        {
                            if (a is BunifuCheckbox && a.Name == "CheckBoxSeleccionM2")
                            {
                                tempPanelPrincipal_SeleM.Controls.Remove(a);
                                a.Dispose();
                            }
                        }
                        foreach (var a in tempPanelPrincipal_SeleM.Controls.OfType<BunifuMaterialTextbox>())
                        {
                            if (a is BunifuMaterialTextbox && a.Name == "TexboxOpcciónSeleccionM2")
                            {
                                tempPanelPrincipal_SeleM.Controls.Remove(a);
                                a.Dispose();
                            }
                        }
                        foreach (var a in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                        {
                            if (a is BunifuImageButton && a.Name == "EliminarOpccionSeleccionM2")
                            {
                                tempPanelPrincipal_SeleM.Controls.Remove(a);
                                a.Dispose();
                            }
                        }

                        if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM1")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM--;
                            for (int i = 0; i <= 8; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }

                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM1")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[3]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[6]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[7]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[8]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM1")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[5]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM1")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[4]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM1")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[4]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[8]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 1, 2, ContSecundarioSeleM.ContadorR_SeleM);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[0];
                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM2")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM2--;
                            for (int i = 9; i <= 17; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM2")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[12]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[15]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[16]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[17]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM2")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[14]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM2")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[13]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM2")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[13]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[17]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 10, 11, ContSecundarioSeleM.ContadorR_SeleM2);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[9];

                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM3")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM3--;
                            for (int i = 18; i <= 26; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM3")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[21]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[24]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[25]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[26]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM3")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[23]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM3")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[22]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM3")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[22]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[26]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 19, 20, ContSecundarioSeleM.ContadorR_SeleM3);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[18];
                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM4")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM4--;
                            for (int i = 27; i <= 35; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM4")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[30]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[33]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[34]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[35]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM4")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[32]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM4")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[31]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM4")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[31]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[35]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 28, 29, ContSecundarioSeleM.ContadorR_SeleM4);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[27];
                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM5")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM5--;
                            for (int i = 36; i <= 44; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM5")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[39]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[42]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[43]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[44]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM5")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[41]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM5")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[40]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM5")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[40]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[44]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 37, 38, ContSecundarioSeleM.ContadorR_SeleM5);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[36];

                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM6")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM6--;
                            for (int i = 45; i <= 53; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM6")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[48]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[51]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[52]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[53]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM6")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[50]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM6")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[49]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM6")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[49]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[53]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 46, 47, ContSecundarioSeleM.ContadorR_SeleM6);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[45];
                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM7")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM7--;
                            for (int i = 54; i <= 62; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM7")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[57]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[60]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[61]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[62]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM7")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[59]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM7")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[58]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM7")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[58]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[62]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 55, 56, ContSecundarioSeleM.ContadorR_SeleM7);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[54];
                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM8")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM8--;
                            for (int i = 63; i <= 71; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM8")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[66]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[69]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[70]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[71]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM8")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[68]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM8")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[67]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM8")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[67]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[71]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 64, 65, ContSecundarioSeleM.ContadorR_SeleM8);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[63];

                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM9")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM9--;
                            for (int i = 72; i <= 80; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM9")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[75]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[78]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[79]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[80]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM9")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[77]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM9")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[76]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM9")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[76]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[80]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 73, 74, ContSecundarioSeleM.ContadorR_SeleM9);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[72];
                        }
                        else if (tempPanelPrincipal_SeleM.Name == "panelSeleccionM10")
                        {
                            ContSecundarioSeleM.ContadorR_SeleM10--;
                            for (int i = 81; i <= 89; i++)
                            {
                                ArreglosGlobales.PosicionSeleM[i] -= 50;
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJButton>())
                            {
                                if (b is RJButton && b.Name == "buttonSeleccionM10")
                                {
                                    b.Location = new Point(60, ArreglosGlobales.PosicionSeleM[84]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PanelRedondeado>())
                            {
                                if (b is PanelRedondeado && b.Width == 700)
                                {

                                    b.Location = new Point(15, ArreglosGlobales.PosicionSeleM[87]);
                                }
                                else if (b is PanelRedondeado && b.Width == 2)
                                {

                                    b.Location = new Point(538, ArreglosGlobales.PosicionSeleM[88]);
                                }
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<Label>())
                            {
                                if (b is Label && b.Text == "Obligatoria")
                                {

                                    b.Location = new Point(550, ArreglosGlobales.PosicionSeleM[89]);
                                }
                                else if (b is Label && b.Name == "labelSeleccionM10")
                                {

                                    b.Location = new Point(58, ArreglosGlobales.PosicionSeleM[86]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<PictureBox>())
                            {
                                if (b is PictureBox && b.Name == "imagenSeleccionM10")
                                {
                                    b.Location = new Point(17, ArreglosGlobales.PosicionSeleM[85]);
                                }

                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<BunifuImageButton>())
                            {
                                if (b is BunifuImageButton && b.Name == "EliminarSeleccionM10")
                                    b.Location = new Point(488, ArreglosGlobales.PosicionSeleM[85]);
                            }
                            foreach (var b in tempPanelPrincipal_SeleM.Controls.OfType<RJToggleButton>())
                            {
                                if (b is RJToggleButton && b.Width == 47)
                                {
                                    b.Location = new Point(666, ArreglosGlobales.PosicionSeleM[89]);
                                }
                            }
                            cambiarlocation.cambio(tempPanelPrincipal_SeleM, 82, 83, ContSecundarioSeleM.ContadorR_SeleM10);
                            tempPanelPrincipal_SeleM.Height = ArreglosGlobales.PosicionSeleM[81];
                        }

                        break;
                }
                case "EliminarOpccionSeleccionM3":
                {
                        break;
                }
            }
        }
    }
}
