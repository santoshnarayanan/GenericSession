using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBasics.Interfaces
{
    public class RepositoryN<T> : IRepository<T>
    {
        private readonly List<T> _data = new List<T>();

        public void Add(T toAdd)
        {
            _data.Add(toAdd);
        }


        public IEnumerable<T> All()
        {
            return _data;
        }

        public T Get(int index)
        {
            return _data[index];
        }

        public void Remove(T toremove)
        {
            _data.Remove(toremove);
        }
    }
}
