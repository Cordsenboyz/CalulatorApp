﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables for user input
            int num1 = 0; int num2 = 0;


            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");


            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Take user input and convert to mathematical symbol
            // Use Mathematical symbol to get results from the two user inputs and write result in console
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}