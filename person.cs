using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    class Person : IComparable<Person>
    {
        public int m_id { get; private set; }
        public int m_age { get; private set; }
        public float m_height { get; private set; }
        public string m_name { get; private set; }

        public Person(int m_id, int m_age, string m_name, float m_height)
        {
            this.m_id = m_id;
            this.m_age = m_age;
            this.m_name = m_name;
            this.m_height = m_height;



        }

        public int CompareTo(Person p)
        {
           return this.m_id - p.m_id;
        }

        public override string ToString()
        {
            return $"person's id is : {m_id}, name : {m_name},  height : {m_height}, age : {m_age}";
        }
    }
}
