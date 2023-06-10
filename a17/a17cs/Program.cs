using System;

namespace a17cs;

class Program
{
    static void Main (string[] args)
    {
        //Arrays unidimensionais no C# - armazenam uma coleção de valores de tamanho dinâmico
        //e de tipo definido.
        int[] arrayNumeros = {143, 22, 354, 432, 43};

        //Length - propriedade exclusiva de arrays (e strings) que retornam
        //o comprimento de um valor. No caso das arrays, o número de
        //elementos.
        Console.WriteLine("A array possui " + arrayNumeros.Length + " elementos.");

        //Exibindo apenas um valor de um índice existente.
        Console.WriteLine("O valor presente no índice 3 é {0}.", arrayNumeros[3]);

        //Substituíndo um valor do índice.
        arrayNumeros[1] = 7;

        //Testando comprimentos de arrays.
        for (int i = 0; i <= arrayNumeros.Length; i++)
        {
            arrayNumeros[i] = arrayNumeros[i] * 2;
        }

        //Exibindo os valores no console.
        foreach(int num in arrayNumeros){
            Console.Write(num + " ");
        }
    }
}