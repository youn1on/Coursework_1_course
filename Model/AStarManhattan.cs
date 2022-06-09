using System;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public class AStarManhattan : DijkstrasAlgorithm
    {
        public AStarManhattan(Vertice[] vertices, int[][] distanceMatrix, LabyrinthVisualiser visualiser) : base(
            vertices, distanceMatrix, visualiser) { }

        protected override double GetCriteria(Vertice current, Vertice finish)
        {
            return current.MinDistance + Math.Abs(current.X - finish.X) + Math.Abs(current.Y - finish.Y);
        }
    }
}