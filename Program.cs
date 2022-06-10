using System;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Controller;
using Labyrinths_AStar_Dijkstra.Model;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra
{
    static class Program
    {
        public static bool ClosedByUser = true;
        public static string[] FileContent;
        public static int[][] labyrinth;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialForm());
            if (ClosedByUser) return;
            if (FileContent == null)
            {
                ClosedByUser = true;
                Application.Run(new Randomizer());
                if (ClosedByUser) return;
            }
            else
            {
                labyrinth = FileContentProcessor.GetLabyrinthMatrix(FileContent);
            }
            Application.Run(new DisplayResult());
        }
    }
}