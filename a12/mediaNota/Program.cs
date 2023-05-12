//mediaNota - programa que lê as notas e devolve a média.

using System;

namespace mediaNota;

class Program
{
    static void Main (string[] args)
    {
        retornarMedia(3.4m, 4.2m, 6.5m);
    }

    static void retornarMedia(params decimal[] nota)
    {
        int qntNota = nota.Length;
        decimal somaNota = 0m;

        for (int i = 0; i < nota.Length; i++)
        {
            somaNota += nota[i];
        }

        Console.WriteLine("Quantidade de notas: {0}", qntNota);
        Console.WriteLine("A média dos valores é de {0}", (somaNota / qntNota));
    }
}