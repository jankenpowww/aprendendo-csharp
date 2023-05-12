using System;

namespace a12cs4;

class Program
{
    static void Main (string[] args)
    {
        Console.Write("Digite um número entre 0 e 2: ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 0:
                Console.WriteLine("Você digitou zero.");
            break;

            case 1:
                Console.WriteLine("Você digitou um.");
            break;

            case 2:
                Console.WriteLine("Você digitou dois.");
            break;

            default:
                Console.WriteLine("Você digitou um número fora do intervalo entre 0 e 2. Definindo o valor como zero...");
                goto case 0;
        }
    }
}
