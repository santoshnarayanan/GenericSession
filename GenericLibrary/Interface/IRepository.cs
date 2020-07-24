using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBasics.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T toAdd);
        void Remove(T toremove);
        T Get(int index);
        IEnumerable<T> All(); 
    }
}
