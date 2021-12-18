using System;
using System.Collections.Generic;
using System.Text;

namespace ComparePerson
{
    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }

        public static string operator >(Person person1, Person person2)
        {
            if(person1.Age > person2.Age)
            {
                return person1.Name;
            }
            else
            {
                return person2.Name;
            }
        }
        public static string operator<(Person person1, Person person2)
        {
            if (person1.Age < person2.Age)
            {
                return person1.Name;
            }
            else
            {
                return person2.Name;
            }
        }




    }
}
