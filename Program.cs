/*Suppose the population of countries A & B are 60 and 90 millions respectively
 and the rate of population growth for A & B are 5.8% and 4.2% respectively per year.
 Write a program to print the population of A & B each year until the population
 of A exceeds that of B and also print the number of years for the population of A 
 to exceed the population of B.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            double a=60000000;
            double b=90000000;
            while (a < b)
            {
                a = (a + (a * 0.058));
                b = (b + (b * 0.042));
                year++;

            }// while (a > b);
                Console.WriteLine("population of A is:"+a);
            Console.WriteLine("population of B is:" + b);
            Console.WriteLine("Number of years:"+year);
        }
    }
}
