using System;

namespace MySecondConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // these are explicit declerations

            int myFirstInteger;
            myFirstInteger = 12; // = int32  around 2 billion
            // short = int16 around 32 thousand
            // long = int64   nine quintillion


            // decimal is good for money, double and floats are good foor science and math
            decimal money = 12.50m;
            double moreDecimalStuff = 12.50;
            float floatingPoint = 12.50f;

            bool myFirstBoolean = true;
            myFirstBoolean = false;

            char oneCharacter = 'c';

            DateTime rightNow = DateTime.Now;
            DateTime today = DateTime.Today;




            // strings are aways double quotes while char are single quotes

            // the examples below are now expected in C#
            // C# will recogize the variable type when just using var but you must put a value on the right
            // hover over the var to confirm variable type


            // implicit declarations

            var myFirstString = "This is my first string...";

            // var poem = "Roses are red, " +
            //    "violets are blue, " +
            //   "csharp is great, " +
            //   "and so are you.";


            // string literal
            // the @ before a string lets you put in \ without causing issues
            var poem = @"Roses are red,
                violets are blue,
                csharp is great,
                and so are you.";


            // string interpalated
            var name = "Todd";
            var age = 39;
            // var greeting = $"Hi. My name is {todd.name} and I'm {age} years old.";

            // combine both literal and interpalated by using $@ (it needs be be in that order)



            //reference types are pointers that points to the info saved in memory

            // this is a really bad idea. Don't do it. Use proper types.
            object myNumber = 1; // this is valid but a bad idea. It's called "boxing". Putting a value type and store it in a reference type. Inefficient
            myNumber = "stuff";


            // creating anonymous type
            var todd = new {Name = "Todd"};
            var greeting = $"Hi. My name is {todd.Name} and I'm {age} years old.";


            // var names = new string[3];
            var names = new string[5] { "John", "Anca", "Michele", "me", "you" };

            Console.WriteLine(names[1]);
            names[1] = "Todd";
            names[3] = "Anca";


            // Console.WriteLine(poem);
            Console.WriteLine(greeting);

            // blue text C# keywords
            // green text stuff you've created or dotnet framework type thing (things defined outside of C#)


            // you have to provide boolean statements to your if statetment

            var shouldExcute = true;
            
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Hello {name}. Welcome to this console app.");
            }


            // don't write large switch statments, keep them short
            
            switch (oneCharacter)
            {
                case 'a' :
                case 'b' :
                        Console.WriteLine("It's the letter A!");
                        break;
                case 'c' :
                    Console.WriteLine("It's the letter C!");
                    break;
                default :
                    Console.WriteLine("This is your default! It wasn't A or B!");
                    break;
            }

            for (int i = 0; i < names.Length; i++)
            {
                if (i < 3)
                {
                    continue;
                }
                Console.WriteLine($"This current name is {names[i]}.");
            }
            // more common loop we will use is foreach
            foreach (var n in names)
            {
                Console.WriteLine($"Inside the foreach loops the name is {n}");
            }

            // while (true) will cause an invinet loop because true will always be true
            while (true)
            {
                if (DateTime.Now > new DateTime(2020,7,27,19,28,40))
                {
                    break;
                }
            }

            Console.WriteLine("Please enter your name...");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}");


            Console.WriteLine("Please enter a comma seperate list of numbers...");
            var listOfNumbers = Console.ReadLine();

            listOfNumbers.Split(',');

            foreach (var digit in listOfNumbers)
            {
                Console.WriteLine(digit);
            }

        }
    }
}
