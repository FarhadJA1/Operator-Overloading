using System;

namespace ComparePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics


            #endregion


            #region Operator Overloading

            #endregion
             Person person1 = new Person()
            {
                Name = "Farhad",

                Surname = "Azadaliyev",

                Age = 25

                
            };

            Person person2 = new Person()
            {
                Name = "Tural",

                Surname = "Zeynalli",

                Age = 24

            };

            Person person3 = new Person()
            {
                Name = "Kamran",

                Surname = "Mammadov",

                Age = 21


            };

            Console.WriteLine(person1<person3);

        }
        
    }
}
