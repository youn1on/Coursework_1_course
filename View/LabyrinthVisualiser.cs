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
        private Point _start, _finish;
        private readonly int _cellSize;
        private PaintEventArgs paintEventArgs;
        private Randomizer form;

        public LabyrinthVisualiser(int[][] labyrinth, Randomizer _form, Point start = default, Point finish = default)
        {
            _start = start;
            _finish = finish;
            form = _form;
            _cellSize = labyrinth.Length > labyrinth[0].Length
                ? Style.VisualizedLabyrinthSize.Height / labyrinth.Length
                : Style.VisualizedLabyrinthSize.Width / labyrinth[0].Length;
            this.labyrinth = labyrinth;
            form.background = new Label();
            form.background.BackColor = Color.Black;
            form.background.Size = new Size(_cellSize * labyrinth[0].Length, _cellSize * labyrinth.Length);
            form.background.Location = new Point(
                Style.LabyrinthLocation.X + (Style.VisualizedLabyrinthSize.Width - form.background.Size.Width) / 2,
                Style.LabyrinthLocation.Y + (Style.VisualizedLabyrinthSize.Height - form.background.Size.Height) / 2);
            form.background.Paint += DrawLabyrinth;
            form.Controls.Add(form.background);
            
        }

        public void DrawLabyrinth(object sender, PaintEventArgs e)
        {
            paintEventArgs = e;
            Pen pen = new Pen(Color.White, _cellSize);
            Vertice[] vertices = LabyrinthProcessor.GetVerticeList(labyrinth, _start == default? new[] {new[] {1, 1}, new[] {1, 1}}:new[] {new[]{_start.X, _start.Y}, new[]{_finish.X, _finish.Y}});
            int[][] distances = LabyrinthProcessor.GetDistances(vertices, labyrinth);

            for (int i = 0; i < distances.Length; i++)
            {
                for (int j = i + 1; j < distances.Length; j++)
                {
                    if (distances[i][j] < Int32.MaxValue / 2)
                    {
                        (int x1, int y1, int x2, int y2) = (vertices[i].Y * _cellSize + _cellSize / 2,
                            vertices[i].X * _cellSize + _cellSize / 2,
                            vertices[j].Y * _cellSize + _cellSize / 2, vertices[j].X * _cellSize + _cellSize / 2);
                        if (x1 == x2)
                        {
                            y1 -= _cellSize / 2;
                            y2 += _cellSize / 2;
                        }
                        else
                        {
                            x1 -= _cellSize / 2;
                            x2 += _cellSize / 2;
                        }

                        e.Graphics.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }

            foreach (Vertice vertice in vertices)
            {
                pen.Color = Color.LightBlue;
                e.Graphics.DrawLine(pen, vertice.Y*_cellSize+_cellSize/2, vertice.X*_cellSize, vertice.Y*_cellSize+_cellSize/2, vertice.X*_cellSize+_cellSize);
            }

            if (_start != default)
            {
                pen.Color = Color.Crimson;
                e.Graphics.DrawLine(pen, _start.Y*_cellSize+_cellSize/2, _start.X*_cellSize, _start.Y*_cellSize+_cellSize/2, _start.X*_cellSize+_cellSize);
                e.Graphics.DrawLine(pen, _finish.Y*_cellSize+_cellSize/2, _finish.X*_cellSize, _finish.Y*_cellSize+_cellSize/2, _finish.X*_cellSize+_cellSize);
            }
        }

        public void FillLabyrinth(object sender, PaintEventArgs e)
        {
            paintEventArgs = e;
            DisplayResult _form = (DisplayResult)form;
            _form.algo.FindRoute(_form.entryPoints[0], _form.entryPoints[1]);
            DrawRoute(_form.vertices, _form.entryPoints[1]);
        }
        
        public void DrawPathBetween(Vertice vertice1, Vertice vertice2, Color pathColor = default)
        {
            if (paintEventArgs == null) return;
            Pen pen = new Pen(pathColor==default?Color.CornflowerBlue:pathColor, _cellSize);
            (int x1, int y1, int x2, int y2) = (vertice1.Y*_cellSize, vertice1.X*_cellSize, vertice2.Y*_cellSize, vertice2.X*_cellSize);
            if (x1 == x2)
            {
                x1 += _cellSize / 2;
                x2 += _cellSize / 2;
                if (y1 > y2) y2 += _cellSize;
                else y1 += _cellSize;
            }
            else
            {
                y1 += _cellSize / 2;
                y2 += _cellSize / 2;
                if (x1 > x2) x2 += _cellSize;
                else x1 += _cellSize;
            }
            paintEventArgs.Graphics.DrawLine(pen, x1, y1, x2, y2);
            pen.Color = pathColor==default?Color.RoyalBlue:pathColor;
            paintEventArgs.Graphics.DrawLine(pen, vertice2.Y*_cellSize+_cellSize/2, vertice2.X*_cellSize, vertice2.Y*_cellSize+_cellSize/2, vertice2.X*_cellSize+_cellSize);
        }

        public void DrawRoute(Vertice[] vertices, int finIndex)
        {
            Vertice current = vertices[finIndex];
            DrawPathBetween(current, current, Color.Red);
            while (current.Previous != -1)
            {
                Vertice previous = vertices[current.Previous];
                DrawPathBetween(current, previous, Color.Crimson);
                current = previous;
            }
            DrawPathBetween(current, current, Color.Red);
        }
    }
}