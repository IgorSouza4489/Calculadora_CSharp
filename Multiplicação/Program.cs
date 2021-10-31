using System;

namespace Multiplicação
{
    class Program
    {
        static void Main(string[] args)
        {
            //drone
            double num1, num2;
            Console.WriteLine("Calculadora de multiplicação");
            Console.Write("Digite um valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite outro valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"A multiplicação dos números {num1} * {num2} é: " + (num1 * num2));
            Console.ReadLine();
        }
    }
}
