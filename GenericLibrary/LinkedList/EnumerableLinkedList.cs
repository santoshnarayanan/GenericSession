using System.Collections;
using System.Collections.Generic;

namespace LinkedList.Enumerable
{
    public class EnumerableLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;

        public EnumerableLinkedList()
        {
            Count = 0;
            _head = null;
        }

        public void Insert(T data)
        {
            var node = CreateNode(data);
            node.Next = _head;
            _head = node;
        }

        private Node<T> CreateNode(T data)
        {
            Count++;
            return new Node<T>
            {
                Data = data
            };
        }

        public int Count { get; private set; }

        public T Get(int index)
        {
            int position = 0;
            Node<T> node = _head;
            while (position < index && node != null)
            {
                node = node.Next;
                position++;
            }
            if (node != null)
            {
                return node.Data;
            }
            return default(T);
        }

        private class Node<TData>
        {
            public TData Data;
            public Node<TData> Next;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}