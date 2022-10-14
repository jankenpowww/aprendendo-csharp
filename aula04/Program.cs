using System;

namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis globais são visíveis para escopos dentro
            //de uma classe
            string str = "Essa é uma variável global.";

            //Escopo de variável:
            /*Dependendo de onde a variável é declarada, ela só 
            pode ser acessada e utilizada somente onde foi 
            declarada*/

            //Consideremos 2 funções diretentes:

            int funcao01(){
                int x = 10; //Declarando uma variável x.
                Console.WriteLine(str);
                return x;
            }

            int funcao02(){
                int x = 45;
                Console.WriteLine(str);
                return x;
            }

            /*Temos duas funções diferentes e não podemos utilizar
            variáveis que venham de outros escopos (exceto globais), o que permite que 
            criemos variáveis de mesmo identificador desde que 
            elas não existam dentro de um escopo.*/

            Console.WriteLine(funcao01());
            Console.WriteLine(funcao02());
        }
    }
}
