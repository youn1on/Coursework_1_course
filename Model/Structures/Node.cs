namespace Labyrinths_AStar_Dijkstra.Model.Structures
{
    public class Node<T>
    {
        public T Value { get; }
        public Node<T> Next { get; set; }
        public double Criteria { get; }

        /// <summary>
        /// Element of a queue which has its certain value and criteria which determines its position in a queue.
        /// </summary>
        public Node(T value, double criteria = 0)
        {
            Value = value;
            Next = null;
            Criteria = criteria;
        }
    }
}