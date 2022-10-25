using Bunifu.Framework.UI;
using Controles_personalizados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Controles_Dinamicos.Mail
{
    public class Pregunta_TipoMail : Preguntas
    {

        public Pregunta_TipoMail(string nombre_contenedor, string nombre_contador, int contador_pregunta, string nombre_pregunta, string text_pregunta, 
        string nombre_respuesta, string text_respuesta, string nombre_imagen, Image image, string nombre_tipo, string text_tipo, string nombre_eliminar)
        : base(nombre_contenedor, nombre_contador, contador_pregunta, nombre_pregunta, text_pregunta, nombre_respuesta, text_respuesta, nombre_imagen, image,
        nombre_tipo, text_tipo, nombre_eliminar)
        {
        }

        public override void EliminarPregunta(BunifuImageButton Eliminar, Panel panelhijo)
        {
            if (Eliminar.Name == "EliminarMail1")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail2")
                        {
                            P.Name = "panelMail1";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail2")
                                    a.Name = "lblMail1";

                                if (a is Label && a.Name == "labelMail2")
                                    a.Name = "labelMail1";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail2")
                                    a.Name = "TexboxMail1";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail2")
                                    a.Name = "TexMail1";

                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail2")
                                    a.Name = "imagenMail1";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail2")
                                    a.Name = "EliminarMail1";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail3")
                        {
                            P.Name = "panelMail2";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail3")
                                    a.Name = "lblMail2";

                                if (a is Label && a.Name == "labelMail3")
                                    a.Name = "labelMail2";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail3")
                                    a.Name = "TexboxMail2";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail3")
                                    a.Name = "TexMail2";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail3")
                                    a.Name = "imagenMail2";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail3")
                                    a.Name = "EliminarMail2";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail4")
                        {
                            P.Name = "panelMail3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail4")
                                    a.Name = "lblMail3";

                                if (a is Label && a.Name == "labelMail4")
                                    a.Name = "labelMail3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail4")
                                    a.Name = "TexboxMail3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail4")
                                    a.Name = "TexMail3";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail4")
                                    a.Name = "imagenMail3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail4")
                                    a.Name = "EliminarMail3";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail5")
                        {
                            P.Name = "panelMail4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail5")
                                    a.Name = "lblMail4";

                                if (a is Label && a.Name == "labelMail5")
                                    a.Name = "labelMail4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail5")
                                    a.Name = "TexboxMail4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail5")
                                    a.Name = "TexMail4";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail5")
                                    a.Name = "imagenMail4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail5")
                                    a.Name = "EliminarMail4";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail6")
                        {
                            P.Name = "panelMail5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail6")
                                    a.Name = "lblMail5";

                                if (a is Label && a.Name == "labelMail6")
                                    a.Name = "labelMail5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail6")
                                    a.Name = "TexboxMail5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail6")
                                    a.Name = "TexMail5";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail6")
                                    a.Name = "imagenMail5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail6")
                                    a.Name = "EliminarMail5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail7")
                        {
                            P.Name = "panelMail6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail7")
                                    a.Name = "lblMail6";

                                if (a is Label && a.Name == "labelMail7")
                                    a.Name = "labelMail6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail7")
                                    a.Name = "TexboxMail6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail7")
                                    a.Name = "TexMail6";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail7")
                                    a.Name = "imagenMail6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail7")
                                    a.Name = "EliminarMail6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail8")
                        {
                            P.Name = "panelMail7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail8")
                                    a.Name = "lblMail7";

                                if (a is Label && a.Name == "labelMail8")
                                    a.Name = "labelMail7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail8")
                                    a.Name = "TexboxMail7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail8")
                                    a.Name = "TexMail7";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail8")
                                    a.Name = "imagenMail7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail8")
                                    a.Name = "EliminarMail7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail9")
                        {
                            P.Name = "panelMail8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail9")
                                    a.Name = "lblMail8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "labelMail8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail9")
                                    a.Name = "TexboxMail8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail9")
                                    a.Name = "TexMail8";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail9")
                                    a.Name = "imagenMail8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail9")
                                    a.Name = "EliminarMail8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail2")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail3")
                        {
                            P.Name = "panelMail2";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail3")
                                    a.Name = "lblMail2";

                                if (a is Label && a.Name == "labelMail3")
                                    a.Name = "labelMail2";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail3")
                                    a.Name = "TexboxMail2";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail3")
                                    a.Name = "TexMail2";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail3")
                                    a.Name = "imagenMail2";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail3")
                                    a.Name = "EliminarMail2";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail4")
                        {
                            P.Name = "panelMail3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail4")
                                    a.Name = "lblMail3";

                                if (a is Label && a.Name == "labelMail4")
                                    a.Name = "labelMail3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail4")
                                    a.Name = "TexboxMail3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail4")
                                    a.Name = "TexMail3";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail4")
                                    a.Name = "imagenMail3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail4")
                                    a.Name = "EliminarMail3";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail5")
                        {
                            P.Name = "panelMail4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail5")
                                    a.Name = "lblMail4";

                                if (a is Label && a.Name == "labelMail5")
                                    a.Name = "labelMail4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail5")
                                    a.Name = "TexboxMail4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail5")
                                    a.Name = "Tex4Mail";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail5")
                                    a.Name = "imagenMail4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail5")
                                    a.Name = "EliminarMail4";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail6")
                        {
                            P.Name = "panelMail5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail6")
                                    a.Name = "lblMail5";

                                if (a is Label && a.Name == "labelMail6")
                                    a.Name = "labelMail5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail6")
                                    a.Name = "TexboxMail5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail6")
                                    a.Name = "TexMail5";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail6")
                                    a.Name = "imagenMail5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail6")
                                    a.Name = "EliminarMail5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail7")
                        {
                            P.Name = "panelMail6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail7")
                                    a.Name = "lblMail6";

                                if (a is Label && a.Name == "labelMail7")
                                    a.Name = "labelMail6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail7")
                                    a.Name = "TexboxMail6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail7")
                                    a.Name = "TexMail6";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail7")
                                    a.Name = "imagenMail6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail7")
                                    a.Name = "EliminarMail6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail8")
                        {
                            P.Name = "panelMail7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail8")
                                    a.Name = "lblMail7";

                                if (a is Label && a.Name == "labelMail8")
                                    a.Name = "labelMail7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail8")
                                    a.Name = "TexboxMail7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail8")
                                    a.Name = "TexMail7";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail8")
                                    a.Name = "imagenMail7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail8")
                                    a.Name = "EliminarMail7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail9")
                        {
                            P.Name = "panelMail8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail9")
                                    a.Name = "lblMail8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "labelMail8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail9")
                                    a.Name = "TexboxMail8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail9")
                                    a.Name = "TexMail8";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail9")
                                    a.Name = "imagenMail8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail9")
                                    a.Name = "EliminarMail8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail3")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail4")
                        {
                            P.Name = "panelMail3";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail4")
                                    a.Name = "lblMail3";

                                if (a is Label && a.Name == "labelMail4")
                                    a.Name = "labelMail3";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail4")
                                    a.Name = "TexboxMail3";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail4")
                                    a.Name = "TexMail3";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail4")
                                    a.Name = "imagenMail3";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail4")
                                    a.Name = "EliminarMail3";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail5")
                        {
                            P.Name = "panelMail4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail5")
                                    a.Name = "lblMail4";

                                if (a is Label && a.Name == "labelMail5")
                                    a.Name = "labelMail4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail5")
                                    a.Name = "TexboxMail4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail5")
                                    a.Name = "Tex4Mail";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail5")
                                    a.Name = "imagenMail4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail5")
                                    a.Name = "EliminarMail4";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail6")
                        {
                            P.Name = "panelMail5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail6")
                                    a.Name = "lblMail5";

                                if (a is Label && a.Name == "labelMail6")
                                    a.Name = "labelMail5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail6")
                                    a.Name = "TexboxMail5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail6")
                                    a.Name = "TexMail5";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail6")
                                    a.Name = "imagenMail5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail6")
                                    a.Name = "EliminarMail5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail7")
                        {
                            P.Name = "panelMail6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail7")
                                    a.Name = "lblMail6";

                                if (a is Label && a.Name == "labelMail7")
                                    a.Name = "labelMail6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail7")
                                    a.Name = "TexboxMail6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail7")
                                    a.Name = "TexMail6";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail7")
                                    a.Name = "imagenMail6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail7")
                                    a.Name = "EliminarMail6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail8")
                        {
                            P.Name = "panelMail7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail8")
                                    a.Name = "lblMail7";

                                if (a is Label && a.Name == "labelMail8")
                                    a.Name = "labelMail7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail8")
                                    a.Name = "TexboxMail7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail8")
                                    a.Name = "TexMail7";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail8")
                                    a.Name = "imagenMail7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail8")
                                    a.Name = "EliminarMail7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail9")
                        {
                            P.Name = "panelMail8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail9")
                                    a.Name = "lblMail8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "labelMail8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail9")
                                    a.Name = "TexboxMail8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail9")
                                    a.Name = "TexMail8";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail9")
                                    a.Name = "imagenMail8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail9")
                                    a.Name = "EliminarMail8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail4")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail5")
                        {
                            P.Name = "panelMail4";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail5")
                                    a.Name = "lblMail4";

                                if (a is Label && a.Name == "labelMail5")
                                    a.Name = "labelMail4";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail5")
                                    a.Name = "TexboxMail4";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail5")
                                    a.Name = "Tex4Mail";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail5")
                                    a.Name = "imagenMail4";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail5")
                                    a.Name = "EliminarMail4";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail6")
                        {
                            P.Name = "panelMail5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail6")
                                    a.Name = "lblMail5";

                                if (a is Label && a.Name == "labelMail6")
                                    a.Name = "labelMail5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail6")
                                    a.Name = "TexboxMail5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail6")
                                    a.Name = "TexMail5";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail6")
                                    a.Name = "imagenMail5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail6")
                                    a.Name = "EliminarMail5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail7")
                        {
                            P.Name = "panelMail6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail7")
                                    a.Name = "lblMail6";

                                if (a is Label && a.Name == "labelMail7")
                                    a.Name = "labelMail6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail7")
                                    a.Name = "TexboxMail6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail7")
                                    a.Name = "TexMail6";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail7")
                                    a.Name = "imagenMail6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail7")
                                    a.Name = "EliminarMail6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail8")
                        {
                            P.Name = "panelMail7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail8")
                                    a.Name = "lblMail7";

                                if (a is Label && a.Name == "labelMail8")
                                    a.Name = "labelMail7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail8")
                                    a.Name = "TexboxMail7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail8")
                                    a.Name = "TexMail7";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail8")
                                    a.Name = "imagenMail7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail8")
                                    a.Name = "EliminarMail7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail9")
                        {
                            P.Name = "panelMail8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail9")
                                    a.Name = "lblMail8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "labelMail8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail9")
                                    a.Name = "TexboxMail8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail9")
                                    a.Name = "TexMail8";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail9")
                                    a.Name = "imagenMail8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail9")
                                    a.Name = "EliminarMail8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail5")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail6")
                        {
                            P.Name = "panelMail5";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail6")
                                    a.Name = "lblMail5";

                                if (a is Label && a.Name == "labelMail6")
                                    a.Name = "labelMail5";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail6")
                                    a.Name = "TexboxMail5";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail6")
                                    a.Name = "TexMail5";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail6")
                                    a.Name = "imagenMail5";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail6")
                                    a.Name = "EliminarMail5";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail7")
                        {
                            P.Name = "panelMail6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail7")
                                    a.Name = "lblMail6";

                                if (a is Label && a.Name == "labelMail7")
                                    a.Name = "labelMail6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail7")
                                    a.Name = "TexboxMail6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail7")
                                    a.Name = "TexMail6";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail7")
                                    a.Name = "imagenMail6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail7")
                                    a.Name = "EliminarMail6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail8")
                        {
                            P.Name = "panelMail7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail8")
                                    a.Name = "lblMail7";

                                if (a is Label && a.Name == "labelMail8")
                                    a.Name = "labelMail7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail8")
                                    a.Name = "TexboxMail7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail8")
                                    a.Name = "TexMail7";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail8")
                                    a.Name = "imagenMail7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail8")
                                    a.Name = "EliminarMail7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail9")
                        {
                            P.Name = "panelMail8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail9")
                                    a.Name = "lblMail8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "labelMail8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail9")
                                    a.Name = "TexboxMail8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail9")
                                    a.Name = "TexMail8";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail9")
                                    a.Name = "imagenMail8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail9")
                                    a.Name = "EliminarMail8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail6")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail7")
                        {
                            P.Name = "panelMail6";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail7")
                                    a.Name = "lblMail6";

                                if (a is Label && a.Name == "labelMail7")
                                    a.Name = "labelMail6";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail7")
                                    a.Name = "TexboxMail6";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail7")
                                    a.Name = "TexMail6";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail7")
                                    a.Name = "imagenMail6";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail7")
                                    a.Name = "EliminarMail6";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail8")
                        {
                            P.Name = "panelMail7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail8")
                                    a.Name = "lblMail7";

                                if (a is Label && a.Name == "labelMail8")
                                    a.Name = "labelMail7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail8")
                                    a.Name = "TexboxMail7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail8")
                                    a.Name = "TexMail7";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail8")
                                    a.Name = "imagenMail7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail8")
                                    a.Name = "EliminarMail7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail9")
                        {
                            P.Name = "panelMail8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail9")
                                    a.Name = "lblMail8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "labelMail8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail9")
                                    a.Name = "TexboxMail8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail9")
                                    a.Name = "TexMail8";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail9")
                                    a.Name = "imagenMail8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail9")
                                    a.Name = "EliminarMail8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail7")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail8")
                        {
                            P.Name = "panelMail7";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail8")
                                    a.Name = "lblMail7";

                                if (a is Label && a.Name == "labelMail8")
                                    a.Name = "labelMail7";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail8")
                                    a.Name = "TexboxMail7";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail8")
                                    a.Name = "TexMail7";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail8")
                                    a.Name = "imagenMail7";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail8")
                                    a.Name = "EliminarMail7";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail9")
                        {
                            P.Name = "panelMail8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail9")
                                    a.Name = "lblMail8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "labelMail8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail9")
                                    a.Name = "TexboxMail8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail9")
                                    a.Name = "TexMail8";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail9")
                                    a.Name = "imagenMail8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail9")
                                    a.Name = "EliminarMail8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail8")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail9")
                        {
                            P.Name = "panelMail8";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail9")
                                    a.Name = "lblMail8";

                                if (a is Label && a.Name == "label9")
                                    a.Name = "labelMail8";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail9")
                                    a.Name = "TexboxMail8";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail9")
                                    a.Name = "TexMail8";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail9")
                                    a.Name = "imagenMail8";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail9")
                                    a.Name = "EliminarMail8";
                            }
                        }
                        else if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail9")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
                        if (P is PanelRedondeado && P.Name == "panelMail10")
                        {
                            P.Name = "panelMail9";
                            foreach (var a in P.Controls.OfType<Label>())
                            {
                                if (a is Label && a.Name == "lblMail10")
                                    a.Name = "lblMail9";

                                if (a is Label && a.Name == "labelMail10")
                                    a.Name = "labelMail9";

                            }
                            foreach (var a in P.Controls.OfType<BunifuMaterialTextbox>())
                            {
                                if (a is BunifuMaterialTextbox && a.Name == "TexboxMail10")
                                    a.Name = "TexboxMail9";

                                if (a is BunifuMaterialTextbox && a.Name == "TexMail10")
                                    a.Name = "TexMail9";
                            }

                            foreach (var a in P.Controls.OfType<PictureBox>())
                            {
                                if (a is PictureBox && a.Name == "imagenMail10")
                                    a.Name = "imagenMail9";
                            }

                            foreach (var a in P.Controls.OfType<BunifuImageButton>())
                            {
                                if (a is BunifuImageButton && a.Name == "EliminarMail10")
                                    a.Name = "EliminarMail9";
                            }
                        }
                    }
                    Contador_pregunta--;
                }

            }
            else if (Eliminar.Name == "EliminarMail10")
            {
                DialogResult result = new DialogResult();
                Form message = new frmYes_or_not("¿Desea eliminar la pregunta?");
                result = message.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var P in panelhijo.Controls.OfType<PanelRedondeado>())
                    {
                        if (P is PanelRedondeado && P.Name == "panelMail1")
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
