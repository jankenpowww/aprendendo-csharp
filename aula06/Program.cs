using System;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20, n3 = 30;

            //Formatando com concatenação.
            //Utilizamos + para concatenar texto e variável.
                Console.WriteLine(n1 + ", " + n2 + ", " + n3);

            //Formatando através de índices.
            //Informamos as variáveis dentro de placeholders dentro do texto e formatamos a saída de cada um informando seu índice e variáveis posteriormente.
                Console.WriteLine("{0}, {1}, {2}", n1, n2, n3);

            //Formatando com template string.
            //Template strings utilizam placeholder onde vão as variáveis. Isso facilita a junção de variável
            //e texto. Para isso, utilizamos o sinal de cifrão e a variável entre chaves.
                Console.WriteLine($"{n1}, {n2}, {n3}");

            /**/

            Console.WriteLine("\n\n\n");

            //Formatação de números.
            //Formatando valores e exibindo uma informação.

                double valorCompra = 5.50;
                double lucro = 0.1;
                double valorVenda;
                string nomeProduto = "Camiseta";

                valorVenda = valorCompra + (valorCompra * lucro);

                Console.WriteLine("Produto.......:{0, 15}", nomeProduto);

                Console.WriteLine("Val.Compra....:{0, 15:c}", valorCompra);

                Console.WriteLine("Lucro.........:{0, 15:p}", lucro);

                Console.WriteLine("Val.Venda.....:{0, 15:c}", valorVenda);

                /**/

                Console.WriteLine("\n\n\n");

                	string nome = "Matheus";
	                int idade = 19;
	                double salario = 2345.54;

	                double porcDesc = 0.15;
	                double desconto = salario * porcDesc;
	                double salDesconto = salario - desconto;

	                Console.WriteLine("Nome: {0, 10}", nome);
	                Console.WriteLine("Idade: {0, 10}", idade);

	                Console.WriteLine("Salário: {0, 10:c}", salario, "\n");

	                Console.WriteLine("Porc. Desconto: {0, 10:p}", porcDesc, "\n");

	                Console.WriteLine("Desconto: {0, 10:c} \n Salário (c/ Desc): {1, 10:c}", desconto, salDesconto);
        }
    }
}