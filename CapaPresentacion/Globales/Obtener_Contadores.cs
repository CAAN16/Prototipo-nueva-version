namespace CapaPresentacion.Globales
{
    static class Obtener_Contadores
    {
        private static int total_Preguntas = 1;
        private static int total_NombreC = 1;
        private static int total_Mail = 1;
        private static int total_Tel = 1;
        private static int total_TextC = 1;
        private static int total_TextL = 1;
        private static int total_SeleM = 1;
        private static int total_SeleI = 1;

        public static int Total_Preguntas { get => total_Preguntas; set => total_Preguntas = value; }
        public static int Total_NombreC { get => total_NombreC; set => total_NombreC = value; }
        public static int Total_Mail { get => total_Mail; set => total_Mail = value; }
        public static int Total_Tel { get => total_Tel; set => total_Tel = value; }
        public static int Total_TextC { get => total_TextC; set => total_TextC = value; }
        public static int Total_TextL { get => total_TextL; set => total_TextL = value; }
        public static int Total_SeleM { get => total_SeleM; set => total_SeleM = value; }
        public static int Total_SeleI { get => total_SeleI; set => total_SeleI = value; }
    }
}
