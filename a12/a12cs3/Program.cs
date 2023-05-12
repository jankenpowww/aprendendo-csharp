using System;

namespace a12cs3;

class Program
{
    static void Main (string[] args)
    {
        Console.Write("Quantos anos você tem? ");
        uint idade = uint.Parse(Console.ReadLine());

        if (idade >= 0 && idade <= 17){
            Console.WriteLine("Você é menor de idade.");

        } else if (idade >= 18 && idade <= 60){
            Console.WriteLine("Você é maior de idade.");

        } else {
            Console.WriteLine("Você é maior de idade (e idoso).");
        }
    }
}