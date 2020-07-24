using Intoduction.Examples;

namespace LinkedList.NonGeneric
{
    public class PersonLinkedList
    {
        private PersonNode _head;

        public PersonLinkedList()
        {
            Count = 0;
            _head = null;
        }

        public void Insert(Person data)
        {
            var node = CreateNode(data);
            node.Next = _head;
            _head = node;
        }

        private PersonNode CreateNode(Person data)
        {
            Count++;
            return new PersonNode
            {
                Data = data
            };
        }

        public int Count { get; private set; }

        public Person Get(int index)
        {
            int position = 0;
            PersonNode node = _head;
            while (position < index && node != null)
            {
                node = node.Next;
                position++;
            }
            if (node != null)
            {
                return node.Data;
            }
            return null;
        }

        private class PersonNode
        {
            public Person Data;
            public PersonNode Next;
        }
    }
}