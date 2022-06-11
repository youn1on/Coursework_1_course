using System;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public class AStarEuclidean : DijkstrasAlgorithm
    {
        /// <summary>
        /// A* algorithm with euclidean heuristic to find shortest path between two points.
        /// </summary>
        public AStarEuclidean(Vertice[] vertices, int[][] distanceMatrix, LabyrinthVisualiser visualiser) : base(vertices, distanceMatrix, visualiser) { }        
        /// <summary>
        /// Determines the order of passing vertices using euclidean heuristic.
        /// </summary>
        /// <returns>A number that determines position of a vertice in priority queue calculated via euclidean heuristic.</returns>
        protected override double GetCriteria(Vertice current, Vertice finish)
        {
            return current.MinDistance + 10*Math.Sqrt(Math.Pow(current.X - finish.X, 2) + Math.Pow(current.Y - finish.Y, 2));
        }
    }
}