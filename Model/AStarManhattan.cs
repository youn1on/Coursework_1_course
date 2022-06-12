using System;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public class AStarManhattan : DijkstrasAlgorithm
    {
        /// <summary>
        /// A* algorithm with manhattan heuristic to find shortest path between two points.
        /// </summary>
        public AStarManhattan(Vertice[] vertices, int[][] distanceMatrix, LabyrinthVisualiser visualiser) : base(
            vertices, distanceMatrix, visualiser) { }

        /// <summary>
        /// Determines the order of passing vertices using manhattan heuristic.
        /// </summary>
        /// <returns>A number that determines position of a vertice in priority queue calculated via manhattan heuristic.</returns>
        protected override double GetCriteria(Vertice current, Vertice finish)
        {
            // In A* processing order depends on distances between start point and current points and distances to endpoint.
            // Manhattan heuristic calculates distances to endpoint as minimal number of cells needed to be passed to reach it.
            return current.MinDistance + Math.Abs(current.X - finish.X) + Math.Abs(current.Y - finish.Y);
        }
    }
}