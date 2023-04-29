using System;

namespace a07cs;

class Program
{
    static void Main (string[] args)
    {
        //O valor é definido no momento da declaração de uma variável constante.
        const uint idade = 21;

        //Constantes não podem receber qualquer outro valor depois de serem atribuídas um valor.
        idade = 32;

        Console.WriteLine(idade);
    }
}