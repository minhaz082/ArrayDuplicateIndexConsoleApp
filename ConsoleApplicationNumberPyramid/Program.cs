using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationNumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[10]{ 3, 2, 5, 2, 3, 4,3, 8, 4,8 };
            Console.Write("Array Elements are :");
            
            foreach (int myNumber in myArray)
            {
                Console.Write(myNumber);
            }

            Console.Write("\n");
            int input;
            //do
            //{
                Console.Write("\nEnter number for index value : ");
                input = Convert.ToInt16(Console.ReadLine());                
                
                    int index = -1;
                    while ((index = Array.IndexOf(myArray, input, index + 1)) != -1)
                    {
                        Console.WriteLine(input + " has index " + index);
                    }
                    Console.ReadKey();                
            //} while (input != null);
        }
    }
}
