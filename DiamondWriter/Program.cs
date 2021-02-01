using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of rows: ");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());

            //Display the top part
            for (int i = 1; i <= numberOfRows; i++)
            {
                //Determine the amount of spaces based on the row.
                Console.Write(new string(' ', numberOfRows - i));
                //for (int columns = 1; columns <= rowAmount - i; columns++)
                //{
                //    Console.Write(" ");
                //}

                //Duplicate columns with row and minus with one (to get 0 based value)
                Console.Write(new string('*', 2 * i - 1));
                //for (int columns = 1; columns <= 2 * i - 1; columns++)
                //{
                //    Console.Write("*");
                //}

                Console.WriteLine();
            }

            //Reverse engineer loop to display bottom part.
            for (int i = numberOfRows - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', numberOfRows - i));
                //for (int columns = 1; columns <= rowAmount - i; columns++)
                //{
                //    Console.Write(" ");
                //}

                Console.Write(new string('*', 2 * i - 1));
                //for (int columns = 1; columns <= 2 * i - 1; columns++)
                //{
                //    Console.Write("*");
                //}

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
