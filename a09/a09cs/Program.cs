using System;

namespace a09cs;

class Program
{
    static void Main (string[] args)
    {
        int valor = 25;

        //Desloca para a esquerda. Multiplica por dois uma vez.
        Console.WriteLine(valor << 1); //50

        //Desloca para a direita. Divide por dois uma vez.
        Console.WriteLine(valor >> 1); //12
    }
}