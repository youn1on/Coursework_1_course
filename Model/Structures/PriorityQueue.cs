using System;

namespace Labyrinths_AStar_Dijkstra.Model.Structures
{
    public class PriorityQueue
    {
        public int Count { get; protected set; }
        public Node<int> Head { get; set; }

        /// <summary>
        /// Data structure, in which the order of processing is determined by criteria.
        /// </summary>
        public PriorityQueue()
        {
            Count = 0;
            Head = null;
        }
        /// <summary>
        /// returns first element of queue and deletes it.
        /// </summary>
        /// <returns>Value of head node.</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public int Pop()
        {
            if (Head == null) throw new IndexOutOfRangeException();
            Node<int> headNode = Head;
            Head = Head.Next;
            Count--;
            return headNode.Value;
        }
        /// <summary>
        /// Adds an element to a queue.
        /// </summary>
        public void Push(int value, double criteria)
        {
            Node<int> newNode = new Node<int>(value, criteria);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<int> last;
                if (Head.Criteria>newNode.Criteria)
                {
                    newNode.Next = Head;
                    Head = newNode;
                }
                else
                {
                    last = Head;
                    while (last.Next != null && last.Next.Criteria <= newNode.Criteria)
                    {
                        last = last.Next;
                        if (last.Value == newNode.Value) return;
                    }
                    if (last.Value == newNode.Value) return;
                    newNode.Next = last.Next;
                    last.Next = newNode;
                }
                last = newNode;
                while (last != null && last.Next is not null)
                {
                    while (last.Next.Value == newNode.Value) last.Next = last.Next.Next;
                    last = last.Next;
                }
                
            }

            Count++;
        }
    }
}