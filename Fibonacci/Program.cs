//I've created this fibonacci series with C# for fun...
//I will create a visual program to get fibonacci series (Probably with ASP .NET Core || .NET Core WinForm or PHP/Laravel)
using System;

namespace MyFibonacciApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstFiboSeries = 0; //First fibo series
            int secondFiboSeries = 1; //Second fibo series
            int result = 0; //Here is where first and second fibo index will add together
            Console.Write("Enter fibonacci series: ");
            string? number = Console.ReadLine();
            int? n = Convert.ToInt32(number); //I've convert 'number' variable to int

            //Check if number is 0 or negative (Validation Part)
            if (n <= 0)
            {
                Console.WriteLine("You cannot enter 0 or negative numbers!");
                return;
            }

            //Here is in loop, first x and y add together then assigned to result then with
            //swap technique I've get put result in second index to be ready for add with next i[n]
            for (int i = 0; i < n; i++)
            {
                result = firstFiboSeries + secondFiboSeries;
                firstFiboSeries = secondFiboSeries;
                secondFiboSeries = result;
                Console.WriteLine(result);
                
            }
            //Here is the final result of our fibonacci series
            Console.WriteLine("And here is the last fibonacci series : {0}", result);
        }
    }
}