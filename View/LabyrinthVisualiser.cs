using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Labyrinths_AStar_Dijkstra.Controller;
using Labyrinths_AStar_Dijkstra.Model;

namespace Labyrinths_AStar_Dijkstra.View
{
    public class LabyrinthVisualiser
    {
        private int[][] labyrinth;
        public int CellSize;
        public LabyrinthVisualiser(int[][] labyrinth, Randomizer form)
           {
               CellSize = labyrinth.Length > labyrinth[0].Length
                   ? Style.VisualizedLabyrinthSize.Height / labyrinth.Length
                   : Style.VisualizedLabyrinthSize.Width / labyrinth[0].Length;
               this.labyrinth = labyrinth;
               form.background = new Label();
               form.background.BackColor = Color.Black;
               form.background.Size = new Size(CellSize * labyrinth[0].Length, CellSize * labyrinth.Length);
               form.background.Location = new Point(Style.LabyrinthLocation.X+(Style.VisualizedLabyrinthSize.Width-form.background.Size.Width)/2,
                   Style.LabyrinthLocation.Y+(Style.VisualizedLabyrinthSize.Height-form.background.Size.Height)/2);
               form.background.Paint += new PaintEventHandler(Draw);
               form.Controls.Add(form.background);
           }

        public void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, CellSize);
            Vertice[] vertices = LabyrinthProcessor.GetVerticeList(labyrinth, new[] {new[] {0, 0}, new[] {0, 0}});
            int[][] distances = LabyrinthProcessor.GetDistances(vertices, labyrinth);

            for (int i = 0; i < distances.Length; i++)
            {
                for (int j = i + 1; j < distances.Length; j++)
                {
                    if (distances[i][j] < Int32.MaxValue / 2)
                    {
                        (int x1, int y1, int x2, int y2) = (vertices[i].Y * CellSize + CellSize / 2,
                            vertices[i].X * CellSize + CellSize / 2,
                            vertices[j].Y * CellSize + CellSize / 2, vertices[j].X * CellSize + CellSize / 2);
                        if (x1 == x2)
                        {
                            y1 -= CellSize / 2;
                            y2 += CellSize / 2;
                        }
                        else
                        {
                            x1 -= CellSize / 2;
                            x2 += CellSize / 2;
                        }

                        e.Graphics.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }

            foreach (Vertice vertice in vertices)
            {
                pen.Color = Color.LightBlue;
                e.Graphics.DrawLine(pen, vertice.Y*CellSize+CellSize/2, vertice.X*CellSize, vertice.Y*CellSize+CellSize/2, vertice.X*CellSize+CellSize);
            }
        }
    }
}