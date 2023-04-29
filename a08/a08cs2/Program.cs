using System;

namespace a08cs2;
class Program
{
    static void Main (string[] args)
    {
        //Console.ReadKey() - 'rk' recebe o tipo 'ConsoleKeyInfo'. 
        //Isso dá a variável acesso à variários parâmetros quando é 
        //atribuído alguma coisa através do ReadKey(). A propriedade 
        //'Key' armazena o valor pressionado que pode ser convertido para uma String.

        //O valor é mostrado na tela em seguida.

        //'ConsoleKeyInfo' é uma estrutura do C#, ele pode ser utilizado para 
        //definir uma variável desse tipo escífico que lida apenas com 
        //informações de botões do teclado.

        Console.WriteLine("Aperte qualquer tecla...");

        ConsoleKeyInfo rk = Console.ReadKey();
        Console.WriteLine("Você apertou '" + rk.Key.ToString() + "'.");
    }
}