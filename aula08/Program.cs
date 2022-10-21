using System;

namespace aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("{0}, digite um número inteiro: ", nome);
            var v1 = Console.ReadLine();    //Definindo uma variável sem tipo.

            Console.Write("Digite outro número inteiro: ");
            var v2 = Console.ReadLine();

            Console.WriteLine("O resultado de {0} + {1} = {2}", v1, v2, (v1 + v2));
            //O resultado exibido acima será de uma concatenação dos valores v1
            //e v2, e não uma soma. Isso porque definimos que v1 e v2 são variáveis 
            //que receberão um tipo primitivo dependendo do que lhes forem atribuído, 
            //graças à cláusula 'var' utilizada. Se as variáveis tivessem um tipo definido,
            //a conversão de tipos durante a atribuíção de valor seria obrigatória.

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");

            Console.Write("Digite um número para fazer a soma: ");
            int num1 = int.Parse(Console.ReadLine());   //Convertendo de 'string' para 'inteiro'.

            Console.Write("Digite outro número para fazer a soma: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }
    }
}
