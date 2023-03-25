using System;
namespace a02;
class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine(retornarMultiplicacao(6));
    }

    /*O método retornarMultiplicacao() não seria possível de ser utilizado se não fosse um membro estático; elementos estáticos podem ser chamados independentemente de uma classe.*/
    public static string retornarMultiplicacao(int num){
        string resultado = "";
        
        for (int i = 0; i <= 10; i++){
            resultado += $"{num} x {i} = {num * i}\n";
        }

        return resultado;
    }
}