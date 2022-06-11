using System.Drawing;

namespace Labyrinths_AStar_Dijkstra.View
{
    public static class Style
    {
        /// <summary>
        /// Saves styles needed for objects of several classes
        /// </summary>
        public static Color ConfirmButtonColor = Color.LightGreen;

        public static Point RandomizeLocation = new Point(170, 162);
        public static Point LabyrinthLocation = new Point(100, 320);
        public static Point ConfirmButtonPoint = new Point(400, 162);
        public static Point ConfirmVisualiserPoint = new Point(400, 90);
        public static Point CheckVisualiserPoint = new Point(170, 90);
        public static Point FullFormsLocation = new Point(600, 0);
        public static Point SmallFormLocation = new Point(600, 200);
        public static Point RandomizerFormLocation = FullFormsLocation;
        public static Point BackButtonLocation = new Point(0, 0);

        public static Size VisualizedLabyrinthSize = new Size(600, 600);
        public static Size FullFormSize = new Size(752, 780);
        public static Size SmallFormSize = new Size(825, 450);
        public static Size RandomizerFormSize = FullFormSize;
        public static Size BackButtonSize = new Size(30, 30);
        
        
        public static Font SmallFont = new Font("Times new Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
        public static Font MultiplyLabelFont = new Font("Times new Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        public static Font ButtonFont = new Font("Times New Roman", 16, FontStyle.Italic, GraphicsUnit.Point, 0);
        public static Font TextFieldFont = new Font("Times New Roman", 14, FontStyle.Regular, GraphicsUnit.Point, 0);
    }
}