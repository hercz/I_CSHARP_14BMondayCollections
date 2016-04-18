using System;
using System.Collections;

namespace Part2

//Create a program that shows the integers - given by the user - in reverse sequence! Use Stackto change the sequence!

{
    class Program

    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " Write here an int: ");
                stack.Push(Int32.Parse(Console.ReadLine()));
            }

            Console.ReadKey();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
