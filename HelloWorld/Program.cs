using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My First Step In C#");

            //variable in C#

            //Cannot start variable with number e.g -> 1route
            //while we declare variable recomended to use meaningful names

            //naming convention:
            //Camel Case -> firstName

            //Pascal Case -> FirstName

            //Hungarian Case -> strFirstName

            //For local variables: Camel Case
            int number;

            //For constant variable: Pascal Case

            const float Pi = 3.14f;


            //declare variable:

            byte byteNumber = 2;
            int count = 10;
            float floatNumber = 20.05f;
            char character = 'B';
            string myName = "Ben";
            bool newWithThisLang = true;

            //

            Console.WriteLine("My name is: " +myName);
            Console.WriteLine(byteNumber);
            Console.WriteLine(count);
            Console.WriteLine(floatNumber);
            Console.WriteLine(character);
            Console.WriteLine(newWithThisLang);

        }
    }
}

 