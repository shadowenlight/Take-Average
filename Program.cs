using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter a number of integers seperated by spaces:\n");

            string input = Console.ReadLine();

            string[] strings = input.Split(' ');

            int sum = 0;
            foreach (var item in strings)
            {
                int number = int.Parse(item);

                sum += number;
            }
            int average = sum / strings.Length;

            Console.WriteLine("Average of the integers is: " + average);
        }
    }
}