using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    class Program
    {
       static void PrintPersonsArrays(Person[] p)
        {
            foreach (Person people in p)
            {
                Console.WriteLine(people);

            }
        }

        static void Main(string[] args)
        {
            Person josh = new Person(5, 20, "Josh", 1.90f);
            Person ron = new Person(1, 26, "Ron", 1.68f);
            Person mark = new Person(4, 25, "Mark", 1.74f);
            Person charlie = new Person(3, 21, "Charlie", 1.78f);
            Person freddy = new Person(2, 22, "Freddy", 1.70f);

            Person[] Persons = { josh, ron, mark, charlie, freddy };

            PrintPersonsArrays(Persons);
            Console.WriteLine("..............................................");
            Console.WriteLine("Compared by id");
            Array.Sort(Persons);
            PrintPersonsArrays(Persons);


            Console.WriteLine("..............................................");
            Console.WriteLine("Compared by Name");
            Array.Sort(Persons, new PersonCompareByName());
            PrintPersonsArrays(Persons);

            Console.WriteLine("..............................................");
            Console.WriteLine("Compared by Age");
            Array.Sort(Persons, new PersonCompareByAge());
            PrintPersonsArrays(Persons);


            Console.WriteLine("..............................................");
            Console.WriteLine("Compared by Height");
            Array.Sort(Persons, new PersonCompareByHeight());
            PrintPersonsArrays(Persons);





        }
    }
}
