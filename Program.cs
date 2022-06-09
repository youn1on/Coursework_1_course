using System;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Controller;
using Labyrinths_AStar_Dijkstra.Model;

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
            Application.Run(new Form1());
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
            
        }
    }
}