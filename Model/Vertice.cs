using System;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public class Vertice
    {
        public int X { get; }
        public int Y { get; }

        public int MinDistance = Int32.MaxValue/2;
        public bool Passed = false;
        public int Previous;

        /// <summary>
        /// Key points of optimized labyrinth, which we consider when finding a route.
        /// </summary>
        /// <remarks>Can be corners, crossings or entry points.</remarks>
        public Vertice(int x, int y)
        {
            X = x;
            Y = y;
            Previous = -1;
        }
    }
}