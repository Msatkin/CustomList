using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Person : IComparable<Person>
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }
        public int CompareTo(Person obj)
        {
            return this.name.CompareTo(obj.name);
        }
    }
}
