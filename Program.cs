// Faça um programa em C# que imprima a soma dos números de 1 até 1000.

using System;

namespace SomaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine("A soma de números de 1 a 1000 é: " + soma);
        }
    }
}
