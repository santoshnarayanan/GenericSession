using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBasics.Methods
{
    public class NonGenericClass
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
    }
}
