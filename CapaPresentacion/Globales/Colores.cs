using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Globales
{
    public static class Colores
    {
        private static Color ligthColor;
        private static Color darkColor;
        private static Color normalColor;

        public static Color LigthColor { get => ligthColor; set => ligthColor = value; }
        public static Color DarkColor { get => darkColor; set => darkColor = value; }
        public static Color NormalColor { get => normalColor; set => normalColor = value; }
    }
}
