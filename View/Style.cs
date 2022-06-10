using System.Drawing;

namespace Labyrinths_AStar_Dijkstra.View
{
    public static class Style
    {
        public static Color ConfirmButtonColor = Color.LightGreen;

        public static Point RandomizeLocation = new System.Drawing.Point(170, 162);
        public static Size VisualizedLabyrinthSize = new Size(600, 600);
        public static Point LabyrinthLocation = new Point(100, 350);
        public static Point ConfirmButtonPoint = new Point(400, 162);
        public static Point CheckButtonPoint = new Point(170, 120);
        public static Point ConfirmVisualiserPoint = new Point(400, 120);
        
        public static Font ButtonFont = new Font("Goudy Old Style", 16, FontStyle.Italic, GraphicsUnit.Point, 0);
        public static Font TextFieldFont = new Font("Goudy Old Style", 14, FontStyle.Italic, GraphicsUnit.Point, 0);
    }
}