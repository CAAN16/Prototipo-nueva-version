namespace CapaPresentacion.Globales
{
    public static class ArreglosGlobales
    {
        private static int[] posicionSeleM = new int[600];
        private static int[] posicionSeleI = new int[600];

        public static int[] PosicionSeleM { get => posicionSeleM; set => posicionSeleM = value; }
        public static int[] PosicionSeleI { get => posicionSeleI; set => posicionSeleI = value; }
    }
}
