using System;

namespace Somar
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Calculadora de soma");
            Console.Write("Digite um valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite outro valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("A soma é igual a: " + (num1 + num2));
            Console.ReadLine();

        }
    }
}
