using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    class PersonCompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            Person p1 = (Person)x;
            Person p2 = (Person)y;
            return p1.m_name.CompareTo(p2.m_name);

        }
    }
     
}

