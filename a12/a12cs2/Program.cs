using System;

namespace a12cs2;

class Program
{
    static void Main (string[] args)
    {
        //Estrutura condicional composta - determina o fluxo de execução de programa para caso
        //o teste retornar verdadeiro ou falso. Utilizando ternário.

        Console.Write("Qual é o seu nome? ");
        string? nome = Console.ReadLine();

        string resultado = nome?.Substring(0, 1).ToLower() == "m" ? "Seu nome começa com 'M'!" : "Seu nome não começa com 'M'.";

        Console.WriteLine(resultado);
        Console.WriteLine("Seu nome é " + nome);
    }
}