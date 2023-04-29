using System;

namespace a08cs;
class Program
{
    static void Main (string[] args)
    {
        //Programa que compara dois valores.

        string resultado;

        Console.Write("Digite um número inteiro: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número inteiro: ");
        int n2 = int.Parse(Console.ReadLine());

        if (!(n1 == n2)){
            resultado = n1 > n2 ? $"{n1} é maior que {n2}" : $"{n2} é maior que {n1}.";
        } else {
            resultado = "Os valores são iguais.";
        }

        Console.WriteLine("{0}", resultado);
    }
}