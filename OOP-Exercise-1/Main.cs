using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_1
{
    public static class Main
    {
        private static Person _person;

        public static void AddPerson(string firstname, string lastname)
        {
            var person = new Person(firstname, lastname);
            _person = person;
        }

        public static void GetFullName()
        {
            Console.WriteLine($"FullName: {_person.FirstName} {_person.LastName}");
        }
    }

}
