﻿using System;

namespace Divisão
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Calculadora de divisão");
            Console.Write("Digite um valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite outro valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"A divisão dos números {num1} / {num2} é: " + (num1 / num2));
            Console.ReadLine();
        }
    }
}
