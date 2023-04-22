using System;
namespace a06cs;

class Program
{
    static void Main (string[] args)
    {
        float n1, n2, total;

        Console.Write("Digite um valor em R$ ");
        n1 = float.Parse(Console.ReadLine());

        Console.Write("Digite outro valor em R$ ");
        n2 = float.Parse(Console.ReadLine());

        total = n1 + n2;

        /* Concatenando com sinal de mais
        Console.WriteLine("R$ " + n1 + " + " + "R$ " + n2 + " = " + "R$ " + total); */

        /*Por índices
        Console.WriteLine("R$ {0} + R$ {1} = R$ {2}", n1, n2, total); */

        /*Por índices: determinando tabulação e formatando o valor em reais.
        Console.WriteLine("R$ {0,20} <- n1", n1);
        Console.WriteLine("R$ {0,20} <- n2", n2);
        Console.WriteLine("O resultado é {0:c}", total); */

        /* Dollar Sign */
        Console.WriteLine($"{n1:c} + {n2:c} = {total:c}");
    }
}