using System;
using System.Collections.Generic;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)

        {
            bool convo = true;
            while (convo)
            {
                Console.WriteLine("What would you like to say to the bot?");
                Console.WriteLine("hello");
                Console.WriteLine("sup");
                Console.WriteLine("hello there");
                Console.WriteLine("bye");
                Console.WriteLine();
                string input = Console.ReadLine().ToLower();
          
                if (input == "hello")
                {
                    Console.WriteLine("Hi good to see you" + Environment.NewLine);
                }
                else if (input == "sup")
                {
                    Console.WriteLine("I am good" + Environment.NewLine);
                }
                else if (input == "hello there")
                {
                    Console.WriteLine("General Kenobi" + Environment.NewLine);
                }
                else if (input == "bye")
                {
                    Console.WriteLine("Good bye!" + Environment.NewLine);
                    convo = false;
                }

            }
        }
    }
}
