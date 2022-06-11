using System;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Controller;

namespace Labyrinths_AStar_Dijkstra
{
    static class Program
    {
        public static bool ClosedByUser = true;
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
        }
    }
}