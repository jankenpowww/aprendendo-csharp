//Switch cases aninhados.

using System;

namespace a12cs5;

class Program
{
    static void Main (string[] args)
    {
        Console.Write("Digite um número entre 0 e 2: ");
        int num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 0:
            case 1:
            case 2:
                Console.WriteLine($"Você digitou {num}.");
            break;

            default:
                Console.WriteLine($"VocÊ digitou um número diferente do intervalo proposto.");
            break;
        }
    }
}