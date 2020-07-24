using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBasics.Classes
{
    public class Repository<T>
    {
        private readonly List<T> _data = new List<T>();

        public void Add(T toAdd)
        {
            _data.Add(toAdd);
        }

        public void Remove(T removeT)
        {
            _data.Remove(removeT);
        }

        public IEnumerable<T> All()
        {
            return _data;
        }

        public T Get(int index)
        {
            return _data[index];
        }

    }
}