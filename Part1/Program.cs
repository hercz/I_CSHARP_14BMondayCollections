using System;
using System.Collections;

/// <summary>
/// Create a program that organizes the strings given by the user! Use the ArrayList collection!
/// </summary>
namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strings = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " Write here a string: ");
                //strings.Insert(0, Console.ReadLine());
                strings.Add(Console.ReadLine());
            }

            Console.ReadKey();

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();




        }
    }
}
