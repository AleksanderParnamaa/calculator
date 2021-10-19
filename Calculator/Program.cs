using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene number:");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe('+', '-', '/' või '*'");
            char userOperation = Convert.ToChar(Console.ReadLine());
            switch (userOperation)
            {
                case '+':
                    AddTwoNumber(firstnumber, secondnumber);
                    break;
                
            }
            switch (userOperation)
            {
                case '-':
                    miinusTwoNumber(firstnumber, secondnumber);
                    break;
                
            }
            switch (userOperation)
            {
                case '/':
                    divideTwoNumber(firstnumber, secondnumber);
                    break;
                
            }
            switch (userOperation)
            {
                case '*':
                    korrutaTwoNumber(firstnumber, secondnumber);
                    break;
                
            }
        }
        private static void AddTwoNumber(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
        private static void miinusTwoNumber(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }
        private static void divideTwoNumber(int x, int y)
        {
            int result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
        private static void korrutaTwoNumber(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");


        }
    }
}
