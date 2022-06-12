using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Controller;
using Labyrinths_AStar_Dijkstra.Model;

namespace Labyrinths_AStar_Dijkstra.View
{
    public class LabyrinthVisualiser
    {
        private Point _start, _finish; // Coordinates of start point and endpoint.
        private readonly int _cellSize; // Optimal size of cell to display on a screen.
        private Randomizer form; // The form on which the labyrinth needs to be displayed.
        public List<(Vertice, Vertice)> passed; // List of passed vertices and their predecessors.
        private readonly int[][] distances;
        private Vertice[] vertices;

        /// <summary>
        /// Visualises labyrinth on a given form.
        /// </summary>
        public LabyrinthVisualiser(Randomizer _form, Point start = default, Point finish = default)
        {
            passed = new List<(Vertice, Vertice)>();
            _start = start;
            _finish = finish;
            form = _form;
            _cellSize = Program.labyrinth.Length > Program.labyrinth[0].Length
                ? Style.VisualizedLabyrinthSize.Height / Program.labyrinth.Length
                : Style.VisualizedLabyrinthSize.Width / Program.labyrinth[0].Length;
            
            vertices = LabyrinthProcessor.GetVerticeList(Program.labyrinth, _start == default? new[] {new[] {1, 1}, new[] {1, 1}}:new[] {new[]{_start.X, _start.Y}, new[]{_finish.X, _finish.Y}});
            distances = LabyrinthProcessor.GetDistances(vertices);
            
            form.background = new Label();
            form.background.BackColor = Color.Black;
            form.background.Paint += DrawLabyrinth;
            form.Controls.Add(form.background);
        }

        /// <summary>
        /// Visualises labyrinth with all vertices, routes which were considered, startpoint and endpoint.
        /// </summary>
        private void DrawLabyrinth(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, _cellSize);
            Label This = (Label) sender;
            This.Size = new Size(_cellSize * Program.labyrinth[0].Length, _cellSize * Program.labyrinth.Length);
            This.Location = new Point(
                Style.LabyrinthLocation.X + (Style.VisualizedLabyrinthSize.Width - form.background.Size.Width) / 2,
                Style.LabyrinthLocation.Y + (Style.VisualizedLabyrinthSize.Height - form.background.Size.Height) / 2);
            
            for (int i = 0; i < distances.Length; i++)
            {
                for (int j = i + 1; j < distances.Length; j++)
                {
                    if (distances[i][j] < Int32.MaxValue / 2) // If vertices i and j is adjacent:
                    {
                        //Getting the coordinate of a cell corner on the label.
                        /*(int x1, int y1, int x2, int y2) = (vertices[i].Y * _cellSize, vertices[i].X * _cellSize,
                                                            vertices[j].Y * _cellSize, vertices[j].X * _cellSize);*/
                        (int x1, int y1, int x2, int y2) = (vertices[i].Y * _cellSize + _cellSize / 2,
                            vertices[i].X * _cellSize + _cellSize / 2,
                            vertices[j].Y * _cellSize + _cellSize / 2, vertices[j].X * _cellSize + _cellSize / 2);
                        if (x1 == x2)
                        {
                            /*x1 += _cellSize / 2;
                            x2 += _cellSize / 2;
                            y2 += _cellSize;*/
                            y1 -= _cellSize / 2;
                            y2 += _cellSize / 2;
                        }
                        else
                        {
                            /*y1 += _cellSize / 2;
                            y2 += _cellSize / 2;
                            x2 += _cellSize;*/
                            x1 -= _cellSize / 2;
                            x2 += _cellSize / 2;
                        }

                        e.Graphics.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }

            foreach (Vertice vertice in vertices) //Displaying vertices.
            {
                pen.Color = Color.LightBlue;
                e.Graphics.DrawLine(pen, vertice.Y*_cellSize+_cellSize/2, vertice.X*_cellSize, vertice.Y*_cellSize+_cellSize/2, vertice.X*_cellSize+_cellSize);
            }

            if (_start != default) //Displaying startpoint and endpoint.
            {
                pen.Color = Color.Crimson;
                e.Graphics.DrawLine(pen, _start.Y*_cellSize+_cellSize/2, _start.X*_cellSize, _start.Y*_cellSize+_cellSize/2, _start.X*_cellSize+_cellSize);
                e.Graphics.DrawLine(pen, _finish.Y*_cellSize+_cellSize/2, _finish.X*_cellSize, _finish.Y*_cellSize+_cellSize/2, _finish.X*_cellSize+_cellSize);
            }

            foreach ((Vertice, Vertice) verticePair in passed) //Displaying considered cells.
            {
                DrawPathBetween(verticePair.Item1, verticePair.Item2, e);
            }

            if (passed.Count > 0) // Do not execute before startpoint and endpoint is given.
            {
                var _form = (DisplayResult) form;
                DrawRoute(_form.vertices, DisplayResult.EndPointIndex, e);
            }
        }

        /// <summary>
        /// Refreshing label.
        /// </summary>
        public void Refresh()
        {
            form.background.Refresh();
        }

        /// <summary>
        /// Visualises line between vertices.
        /// </summary>
        private void DrawPathBetween(Vertice vertice1, Vertice vertice2, PaintEventArgs e, Color pathColor = default)
        {
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
            e.Graphics.DrawLine(pen, x1, y1, x2, y2);
            pen.Color = pathColor==default?Color.RoyalBlue:pathColor;
            //Drawing path between two vertices.
            e.Graphics.DrawLine(pen, vertice2.Y*_cellSize+_cellSize/2, vertice2.X*_cellSize, 
                vertice2.Y*_cellSize+_cellSize/2, vertice2.X*_cellSize+_cellSize);
        }

        /// <summary>
        /// Draws route from startpoint to endpoint if it exists.
        /// </summary>
        private void DrawRoute(Vertice[] vertices, int finIndex,  PaintEventArgs e)
        {
            Vertice current = vertices[finIndex];
            DrawPathBetween(current, current, e, Color.Red);
            while (current.Previous != -1)
            {
                Vertice previous = vertices[current.Previous];
                DrawPathBetween(current, previous, e, Color.Crimson);
                current = previous;
            }
            DrawPathBetween(current, current, e, Color.Red);
        }
    }
}