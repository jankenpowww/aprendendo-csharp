using System;

namespace aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 10 + 5;  //'total' recebe a soma entre 10 e 5.
            Console.WriteLine("\n" + total); //mostrará "15" no terminal.

            //Operador ternário no C#.
            bool isIgual = 5 * 2 == 15 ? true : false;
            Console.WriteLine("\n" + isIgual);

            bool result1 = 10 < 20;
            Console.WriteLine("\n" + result1);

            bool result2 = 3 * 3 == 9 && 9 * 2 == 20;   //E
            Console.WriteLine("\n" + result2);

            bool result3 = 10 * 10 == 200 || 7 * 4 == 28;   //Ou
            Console.WriteLine("\n" + result3);

            bool result4 = !(1 + 1 == 2);
            Console.WriteLine("\n" + result4);  //Não

            /**/

            Console.WriteLine("\n\n\n");

            //Exemplo de incremento e decremento + laço de repetição.

            int n1 = 0;

            while (n1 <= 20){
                Console.WriteLine(n1);
                n1++;
            }

            while (n1 >= 0){
                Console.WriteLine(n1);
                n1--;
            }
        }
    }
}
