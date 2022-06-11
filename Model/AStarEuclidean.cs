using System;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public class AStarEuclidean : DijkstrasAlgorithm
    {
        public AStarEuclidean(Vertice[] vertices, int[][] distanceMatrix, LabyrinthVisualiser visualiser) : base(vertices, distanceMatrix, visualiser) { }        
        protected override double GetCriteria(Vertice current, Vertice finish)
        {
            return current.MinDistance + 10*Math.Sqrt(Math.Pow(current.X - finish.X, 2) + Math.Pow(current.Y - finish.Y, 2));
        }
    }
}