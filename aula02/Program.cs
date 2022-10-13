using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1; //Declarando variável tipo inteiro
            int valor2; //Declarando variável tipo inteiro

            Console.Write("Digite um número: ");
            valor1 = Convert.ToInt32(Console.ReadLine()); //Convertendo String >> Inteiro

            Console.Write("Digite outro número: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");  //Template String C#
        }
    }
}
