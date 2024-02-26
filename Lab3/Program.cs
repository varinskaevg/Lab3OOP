using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Number integer = new Integer();
            Number real = new Real();

            Console.WriteLine("Ціле:");
            Console.WriteLine("Додавання: " + integer.Add(5, 3));
            Console.WriteLine("Віднімання: " + integer.Subtract(5, 3));
            Console.WriteLine("Множення: " + integer.Multiply(5, 3));
            Console.WriteLine("Ділення: " + integer.Divide(5, 3));

            Console.WriteLine("\nДійсне:");
            Console.WriteLine("Додавання: " + real.Add(5.5, 3.5));
            Console.WriteLine("Віднімання: " + real.Subtract(5.5, 3.5));
            Console.WriteLine("Множення: " + real.Multiply(5.5, 3.5));
            Console.WriteLine("Ділення: " + real.Divide(5.5, 3.5));
        }
    }
}
