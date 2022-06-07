using System;

namespace Labyrinths_AStar_Dijkstra.Model.Structures
{
    public class Stack<T> : Queue<T>
    {
        public Stack() : base() { }

        public override void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);

            newNode.Next = Head;
            Head = newNode;
            Count++;
        }
    }
    /*{
        public int Capacity { get; private set; }
        public int Count { get; private set; }
        private T[] _data { get; set; }

        public Stack()
        {
            Capacity = 100;
            Count = 0;
            _data = new T[Capacity];
        }

        public void Push(T value)
        {
            if (Count==Capacity) Resize();
            _data[Count] = value;
            Count++;
        }

        public T Pop()
        {
            if (Count == 0) throw new IndexOutOfRangeException();
            Count--;
            return _data[Count];
        }

        private void Resize()
        {
            Capacity += 100;
            T[] newData = new T[Capacity];
            for (int i = 0; i < Count; i++)
            {
                newData[i] = _data[i];
            }
            _data = newData;
        }
    }*/
}