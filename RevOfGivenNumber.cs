/*
 * Print the reverse of given number
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rev = 0;
            Console.WriteLine("Enter a Number : ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rev = rev * 10;
                rev = rev + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : "+rev);
            Console.ReadLine();
 
        }
    }
}
