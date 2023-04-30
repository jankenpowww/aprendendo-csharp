using System;

namespace a10cs;

class Program
{
    enum diasDaSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}

    static void Main (string[] args)
    {
        diasDaSemana dia = diasDaSemana.Segunda;
        
        // Convertendo o valor explicitamente para o tipo inteiro via typecasting.
        int numDia = (int) dia;

        Console.WriteLine($"'{dia}' corresponde ao índice {numDia} dentro do enum.");
    }
}