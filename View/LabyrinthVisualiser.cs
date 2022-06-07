using System.Drawing;
using System.Windows.Forms;

namespace Labyrinths_AStar_Dijkstra.View
{
    public class LabyrinthVisualiser
    {
        public Label[][] Cells;
        public int CellSize;
        public LabyrinthVisualiser(int[][] labyrinth)
        {
            Cells = new Label[labyrinth.Length][];
            for (int i = 0; i < Cells.Length; i++) Cells[i] = new Label[labyrinth[0].Length];
            CellSize = labyrinth.Length > labyrinth[0].Length
                ? Style.VisualizedLabyrinthSize.Height / labyrinth.Length
                : Style.VisualizedLabyrinthSize.Width / labyrinth[0].Length;
            /*(int startX, int startY) = (Style.LabyrinthLocation.X, Style.LabyrinthLocation.Y);
            if (labyrinth.Length > labyrinth[0].Length) startY = (labyrinth.Length - labyrinth[0].Length) * CellSize / 2;
            else startX = (labyrinth[0].Length - labyrinth.Length) * CellSize / 2;*/
            for (int i = 0; i < labyrinth.Length; i++)
            {
                for (int j = 0; j < labyrinth[0].Length; j++)
                {
                    Cells[i][j] = new Label();
                    Cells[i][j].Size = new Size(CellSize, CellSize);
                    Cells[i][j].Location = new Point(/*startX+*/i*CellSize, /*startY+*/j*CellSize);
                    Cells[i][j].Name = $"{i}:{j}";
                    Cells[i][j].BackColor = labyrinth[i][j] == 0 ? Color.White : labyrinth[i][j] == 1 ? Color.Black : Color.Plum;
                }
            }
        }

        public Label[] GetCellsArray()
        {
            Label[] cells = new Label[Cells.Length * Cells[0].Length];
            for (int i = 0; i < Cells.Length; i++)
            {
                for (int j = 0; j < Cells[0].Length; j++)
                {
                    cells[i * Cells[0].Length + j] = Cells[i][j];
                }
            }

            return cells;
        }

        public void Draw(ref GroupBox box)
        {
            
        }
    }
}