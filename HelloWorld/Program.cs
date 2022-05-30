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

            var byteNumber = 2;
            var count = 10;
            var floatNumber = 20.05f;
            var character = 'B';
            var myName = "Ben";
            var newWithThisLang = true;

            //by pressing cmd + click <var> will open Assembly Browser and all the lib fuction.

            Console.WriteLine("My name is: " +myName);
            Console.WriteLine(byteNumber);
            Console.WriteLine(count);
            Console.WriteLine(floatNumber);
            Console.WriteLine(character);
            Console.WriteLine(newWithThisLang);



            

        }
    }
}

 