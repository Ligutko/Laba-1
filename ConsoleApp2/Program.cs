#if true
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Task 1:");

            string name = "Andriy";
            string surname = "Ligutko";
            int age = 17;
            Console.WriteLine("Hello, my name is {0} {1}. I'm {2} years old!", name, surname, age);
            //Console.WriteLine($"Hello, my name is {name} {surname}, I'm {age} years old!");
            Console.WriteLine("-------------------");
#endif

            //Task2
            Console.WriteLine("Task2");
            int a = 3;
            int b = 3;
            double result;


            result = Math.Pow(a + b, 3) - ((Math.Pow(a, 3) + (3 * Math.Pow(a, 2) * b)) /
                (Math.Pow(3 * a * b, 2) + Math.Pow(b, 3)));
            Console.WriteLine("Result of Task 2: " + result);
            Console.WriteLine("-------------------");
            Console.WriteLine("task2:");

            // Aditionaly
            double varA = 3;
            double varB = 2;


            // variant 1
            double result1 = ((Math.Pow(varA + varB, 2) - (Math.Pow(varA, 2) + 2 * varA * varB)) / Math.Pow(varB, 2));
            Console.WriteLine(" 1: " + result1);

            Console.WriteLine("------------------------");

            //// variant 2
            //double result2 = ((Math.Pow(varA - varB, 2) - (Math.Pow(varA, 2) - 2 * varA * varB)) / Math.Pow(varB, 2));
            //Console.WriteLine("variant 2: " + result2);

            //// variant 3
            //double result3 = ((Math.Pow(varA + varB, 3) - (Math.Pow(varA, 3) + 3 * Math.Pow(varA, 2) * varB)) / (3 * varA * varB * varB + Math.Pow(varB, 3)));
            //Console.WriteLine("variant 3: " + result3);

            //// variant 4
            //double result4 = ((Math.Pow(varA + varB, 3) - Math.Pow(varA, 3)) / (3 * varA * varB * varB + Math.Pow(varB, 3) + 3 * varA * varB));
            //Console.WriteLine("variant 4: " + result4);

            //// variant 5
            //double result5 = ((Math.Pow(varA - varB, 3) - (Math.Pow(varA, 3) - 3 * Math.Pow(varA, 2) * varB)) / (Math.Pow(varB, 3) - 3 * varA * varB * varB));
            //Console.WriteLine("variant 5: " + result5);


            //int number = 721;


            //int ones = number % 10;
            //int tens = (number / 10) % 10;
            //int hundreds = number / 100;
            //Console.WriteLine(reversedNumber); 


            //int reversedNumber = ones * 10000 + tens * 10 + hundreds;
            //int reversed = 0;

            //while (number > 0)
            //Console.WriteLine(reversedNumber);

            //Task 3

            Console.Write("Enter Number no more than 3 number :");
            int number = Convert.ToInt32(Console.ReadLine());

            double first = number % 10;
            double second = (number % 100 - first) / 10;
            double third = (number - second * 10 - first) / 100;

            string reversed = first.ToString() + second.ToString() + third.ToString();
            Console.WriteLine(result);
            Console.WriteLine(reversed);
            Console.Read();

            Console.WriteLine("------------------------");




            Console.ReadKey();

        }
    }
}
