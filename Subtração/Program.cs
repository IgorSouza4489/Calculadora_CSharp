using System;

namespace Subtração
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Calculadora de subtração");
            Console.Write("Digite um valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite outro valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("A subtração é igual a: " + (num1 - num2));
            Console.ReadLine();
        }
    }
}
