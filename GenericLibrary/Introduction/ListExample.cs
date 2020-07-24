using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

namespace Intoduction.Examples
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ListExample
    {
        public static void NonGenericList()
        {
            ArrayList list = new ArrayList
            {
                new Person{FirstName="John", LastName="Blake"},
                new Person{FirstName="Santa", LastName="Cruise"},
            };
            Write((list[0] as Person).FirstName);
        }


        public static void GenericList()
        {
            List<Person> list = new List<Person>
            {
               new Person{FirstName="Smith", LastName="Cheryl"},
                new Person{FirstName="John", LastName="Jones"},
            };

            Write(list[0].FirstName);
        }

        public static void Write(string toWrite)
        {
            Debug.WriteLine(toWrite);
        }

    }
}