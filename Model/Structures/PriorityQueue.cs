using System;

namespace Labyrinths_AStar_Dijkstra.Model.Structures
{
    public class PriorityQueue
    {
        public int Count { get; protected set; }
        public Node<int> Head { get; set; }

        public PriorityQueue()
        {
            Count = 0;
            Head = null;
        }
        public int Pop()
        {
            if (Head == null) throw new IndexOutOfRangeException();
            Node<int> headNode = Head;
            Head = Head.Next;
            Count--;
            return headNode.Value;
        }
        public void Push(int value, double criteria)
        {
            Node<int> newNode = new Node<int>(value, criteria);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<int> last = Head;
                while (last.Next != null && last.Next.Criteria <= newNode.Criteria)
                {
                    last = last.Next;
                    if (last.Value == newNode.Value) return;
                }
                if (last.Value == newNode.Value) return;
                newNode.Next = last.Next;
                last.Next = newNode;
                last = newNode;
                while (last != null && last.Next is not null)
                {
                    if (last.Next.Value == newNode.Value) last.Next = last.Next.Next;
                    last = last.Next;
                }
                
            }

            Count++;
        }
    }
}