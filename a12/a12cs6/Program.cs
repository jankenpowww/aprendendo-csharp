//Utilizando goto e labels. O goto aponta para o label que executa novamente todo o
//bloco de código que está imediatamente abaixo desta label.

using System;

namespace a12cs6;

class Program
{
    static void Main (string[] args)
    {
        //Definindo uma label. É daqui que o código se repete uma vez
        //que há um comando goto que retornará o fluxo de execução daqui.
        repeteCodigo:
            const int respostaCerta = 3 - 4 * 2;

            Console.Write("3 - 4 * 2 é igual a ... ");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta == respostaCerta){
                Console.WriteLine("Você acertou!");
            } else {
                Console.WriteLine("\nVocê errou tente novamente!");
                goto repeteCodigo;
            }
    }
}