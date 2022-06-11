using System;
using System.Collections.Generic;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public class LabyrinthProcessor
    {
        /// <summary>
        /// Determines all vertices and returns them.
        /// </summary>
        /// <returns>List of vertices in user's labyrinth.</returns>
        public static Vertice[] GetVerticeList(int[][] _labyrinth, int[][] dots)
        {
            int[][] labyrinth = new int[_labyrinth.Length][];
            for (int i = 0; i < _labyrinth.Length; i++)
            {
                labyrinth[i] = new int[_labyrinth[0].Length];
                for (int j = 0; j < _labyrinth[0].Length; j++)
                {
                    labyrinth[i][j] = _labyrinth[i][j];
                }
            }
            List<Vertice> verticeList = new List<Vertice>();
            for (int i = 1; i < labyrinth.Length - 1; i++)
            {
                for (int j = 1; j < labyrinth[i].Length - 1; j++)
                {
                    if (labyrinth[i][j] != 1 && (!IsTunnel(labyrinth, i, j) ||
                                                 i == dots[0][0] && j == dots[0][1] ||
                                                 i == dots[1][0] && j == dots[1][1]))
                    {
                        verticeList.Add(new Vertice(i, j));
                        labyrinth[i][j] = 2;
                    }
                }
            }

            Vertice[] vertices = new Vertice[verticeList.Count];
            for (int i = 0; i < vertices.Length; i++) vertices[i] = verticeList[i];
            return vertices;
        }
        /// <summary>
        /// Checks if cell shouldn't be a vertice.
        /// </summary>
        private static bool IsTunnel(int[][] labyrinth, int i, int j)
        {
            return labyrinth[i][j - 1] == 1 && labyrinth[i][j + 1] == 1 && labyrinth[i - 1][j] != 1 &&
                labyrinth[i + 1][j] != 1 || labyrinth[i][j - 1] != 1 && labyrinth[i][j + 1] != 1 &&
                labyrinth[i - 1][j] == 1 && labyrinth[i + 1][j] == 1;
        }

        /// <summary>
        /// Forms distance matrix.
        /// </summary>
        public static int[][] GetDistances(Vertice[] vertices, int[][] labyrinth)
        {
            int[][] distances = new int[vertices.Length][];
            for (int i = 0; i < vertices.Length; i++)
                distances[i] = new int[vertices.Length];

            for (int i = 0; i < vertices.Length; i++)
            {
                for (int j = i; j < vertices.Length; j++)
                {
                    distances[i][j] = Int32.MaxValue/2;
                    distances[j][i] = Int32.MaxValue/2;
                }
            }
            
            for (int i = 0; i < vertices.Length; i++)
            {
                
                for (int j = i + 1; j < vertices.Length; j++)
                {
                    if (IsAdjacent(vertices[i], vertices[j], labyrinth))
                    {
                        distances[i][j] = distances[j][i] = GetDistance(vertices[i], vertices[j]);
                    }
                }
            }

            return distances;
        }
        /// <summary>
        /// Checks if vertices are adjacent.
        /// </summary>
        /// <returns>True if vertices are adjacent.</returns>
        private static bool IsAdjacent(Vertice vertice1, Vertice vertice2, int[][] labyrinth)
        {
            if ((vertice1.X == vertice2.X) == (vertice1.Y == vertice2.Y))
            {
                return false;
            }

            for (int j = Math.Min(vertice1.Y, vertice2.Y) + 1; j < Math.Max(vertice1.Y, vertice2.Y); j++)
            {
                if (labyrinth[vertice1.X][j] > 0) return false;
            }

            for (int i = Math.Min(vertice1.X, vertice2.X) + 1; i < Math.Max(vertice1.X, vertice2.X); i++)
            {
                if (labyrinth[i][vertice1.Y] > 0) return false;
            }

            return true;
        }

        /// <summary>
        /// Calculates linear distance between two points.
        /// </summary>
        /// <returns>Returns distance between two points.</returns>
        private static int GetDistance(Vertice vertice1, Vertice vertice2)
        {
            return (int) Math.Sqrt(Math.Pow(vertice1.X - vertice2.X, 2) + Math.Pow(vertice1.Y - vertice2.Y, 2));
        }

        /// <summary>
        /// Finds indexes of startpoint and endpoint in a vertice array by coordinates.
        /// </summary>
        /// <returns>Indexes of startpoint and endpoint.</returns>
        public static int[] GetEntryPointIndexes(Vertice[] vertices, int[][] coordinates)
        {
            int found = 0;
            int[] indexes = new int[2];
            for (int i = 0; i < vertices.Length && found < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (vertices[i].X == coordinates[j][0] && vertices[i].Y == coordinates[j][1])
                    {
                        indexes[j] = i;
                        found++;
                    }
                }
            }

            return indexes;
        }
    }
}