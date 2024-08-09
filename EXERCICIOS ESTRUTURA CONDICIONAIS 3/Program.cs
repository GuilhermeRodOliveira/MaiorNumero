using System;

namespace EXERCICIOS_ESTRUTURA_CONDICIONAIS_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Faça um programa que peça ao usuário para digitar dois números e depois mostre qual é o maior número.
            
            Console.WriteLine("Vou verificar qual número é maior.");

            Console.WriteLine("Insira o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Clear();

            if (numero1 > numero2) 
            {
                Console.WriteLine($"{numero1} é maior do que o {numero2}.");
            }

            else if (numero1 < numero2) 
            {
                Console.WriteLine($"{numero2} é maior do que o {numero1}.");
            }

            else 
            {
                Console.WriteLine($"Os {numero2} e {numero1} são iguais.");
            }
        }
    }
}
