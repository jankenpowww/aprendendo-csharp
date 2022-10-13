using System;

namespace aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numinteiro = 12; //variável 'int' armazena valores inteiros.

            char caractere = 'e';   //variável 'char' armazena um valor único de caractere (representado entre apóstrofos)

            float numdecimal = 6.5f; //variável 'float' armazena valores decimais (f determina informação do tipo 'float').

            string cadeiaDeCaracteres = "Isso é um texto."; //variável 'string' armazena valores de cadeia de caracteres.

            bool booleano = false;  //variável 'bool' recebe um valor booleano.

            var i = 10;  //Declarando uma variável sem tipo definido.

            Console.WriteLine(numinteiro);
            Console.WriteLine(caractere);
            Console.WriteLine(numdecimal);
            Console.WriteLine(cadeiaDeCaracteres);
            Console.WriteLine(booleano);
            Console.WriteLine(i);

            /**/

            //É possível declarar várias variaveis de uma vez, desde que sejam do mesmo tipo.

            int num1 = 1, num2 = 2, num3 = 3;
            Console.WriteLine($"\n\n{num1}, {num2}, {num3}.");
        }
    }
}
