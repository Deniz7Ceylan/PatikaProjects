using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir metin girin: ");
            string input = Console.ReadLine();
            string output = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.WriteLine("Ters çevrilmiş metin: " + output);
            Console.ReadLine();
        }
    }
}