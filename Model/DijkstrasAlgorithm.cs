using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Model.Structures;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public class DijkstrasAlgorithm
    {
        /// <summary>
        /// Dijkstra's algorithm which finds shortest route between two points.
        /// </summary>
        protected readonly Vertice[] Vertices;
        protected readonly int[][] DistanceMatrix;
        protected LabyrinthVisualiser Visualiser;
        public bool animated = false; //Selects animated or not visualisation.
        public DijkstrasAlgorithm(Vertice[] vertices, int[][] distanceMatrix, LabyrinthVisualiser visualiser)
        {
            Vertices = vertices;
            DistanceMatrix = distanceMatrix;
            Visualiser = visualiser;
        }
        
        /// <summary>
        /// Main logic of Djikstra's algorithm to find path between two points.
        /// </summary>
        public bool FindRoute(int startPointIndex, int endPointIndex)
        {
            PriorityQueue queue = new PriorityQueue();
            Vertices[startPointIndex].MinDistance = 0;
            queue.Push(startPointIndex, 0); // Pushing star point index to queue.
            
            while (queue.Count > 0)
            {
                int currentVertice = queue.Pop();
                if (currentVertice == endPointIndex) // Endpoint is reached.
                {
                    MessageBox.Show($"Amount of vertices considered: {Visualiser.passed.Count+1} \nPath length: {Vertices[endPointIndex].MinDistance}");
                    return true;
                }
                for (int i = 0; i<Vertices.Length; i++)
                {
                    if (DistanceMatrix[currentVertice][i]==Int32.MaxValue/2) continue; // Searching for adjacent vertices.
                    if (Vertices[i].MinDistance >
                        Vertices[currentVertice].MinDistance + DistanceMatrix[currentVertice][i]) // If new distance is lower than current:
                    { // Rewrite distance and predecessor.
                        Vertices[i].MinDistance =
                            Vertices[currentVertice].MinDistance + DistanceMatrix[currentVertice][i];
                        Vertices[i].Previous = currentVertice;
                    }

                    if (!Vertices[i].Passed) // Pushing all unpassed adjacent vertices to the queue.
                    {   
                        queue.Push(i, GetCriteria(Vertices[i], Vertices[endPointIndex]));
                    }
                }

                Vertices[currentVertice].Passed = true;
                if (Vertices[currentVertice].Previous != -1) Visualiser.passed.Add((Vertices[Vertices[currentVertice].Previous],
                    Vertices[currentVertice])); // Adding vertice and its previous vertice to visualiser.
                if (animated) Visualiser.Refresh();
                // Delay in animation for small labyrinths.
                if (Vertices.Length<1000 && animated) System.Threading.Thread.Sleep(3000/Vertices.Length);
            }
            return false;
        }

        /// <summary>
        /// Method (overriden in child classes), which determines the order of passing vertices.
        /// </summary>
        /// <returns>Current minimal distance from startpoint to vertice</returns>
        protected virtual double GetCriteria(Vertice current, Vertice finish)
        {
            return current.MinDistance; // In Dijkstra the order of processing depends on distances only.
        }
    }
}