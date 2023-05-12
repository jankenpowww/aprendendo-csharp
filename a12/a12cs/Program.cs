using System;

namespace a12cs;

class Program
{
    static void Main (string[] args)
    {
        //Estrutura condicional simples - usado para verificar um estado e retornar true. Ele não impede
        //o fluxo normal do programa, já que não há determinado um fluxo alternativo para caso
        //o teste retornar falso.

        Console.Write("Qual o seu nome? ");
        string? nome = Console.ReadLine();

        if (nome?.Substring(0, 1).ToLower() == "m"){ //Captura a substring de índice 0 de uma string.
            Console.WriteLine("Seu nome começa com 'M'!");
        }

        Console.WriteLine("Seu nome é '{0}'", nome);
    }
}
