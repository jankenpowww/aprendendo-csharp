using System;

namespace a11cs;

class Program
{
    enum diasDaSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}

    static void Main (string[] args)
    {
        //typecast - 1 refere-se ao índice correspondente a
        //segunda. O typecasting do tipo vai atribuir a constante
        //referente a este índice para a variável 'dia'.
        diasDaSemana dia = (diasDaSemana) 1;

        Console.WriteLine(dia);
    }
}