using System;

namespace Labyrinths_AStar_Dijkstra.Model.Structures
{
    public class PriorityQueue<T>
    {
        public int Count { get; protected set; }
        public Node<T> Head { get; set; }
        private Node<T> _tail;

        public PriorityQueue()
        {
            Count = 0;
            Head = null;
            _tail = null;
        }
        public T Pop()
        {
            if (Head == null) throw new IndexOutOfRangeException();
            Node<T> headNode = Head;
            Head = Head.Next;
            Count--;
            return headNode.Value;
        }
        public void Push(T value, double criteria)
        {
            Node<T> newNode = new Node<T>(value, criteria);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> last = Head;
                while (last.Next != null && last.Next.Criteria <= newNode.Criteria) last = last.Next;
                newNode.Next = last.Next;
                last.Next = newNode;
            }

            Count++;
        }
    }
}