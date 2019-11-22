using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range(start, end ).
//If an invalid number or non-number text is entered, the method should throw an exception.

//Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1< ... < a10< 100
//Output
//Print 1 < a1< ... < a10< 100
//Or Exception if the above inequality is not true

namespace Tema1Week7Ex3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            Console.WriteLine("Digit 10 numbers, between 1 and 100, in ascending order :");

            try
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.Write("Enter number {0} between {1} and {2}: ", i, start, end);
                    start = ReadNumber(start, end);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Oops! Number out of the range !", start, end);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} -> {1}", e.Message);
            }


        }
        public static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > start && number < end)
            {
                return number;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }

}
