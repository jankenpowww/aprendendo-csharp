using System;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /*Bitwise: utilizamos deslocadores de bit para a esquerda para dobrar seu valor, enquanto que utilizamos o deslocador para a direita para diminuir seu valor pela metade. Isso dependerá do valor de deslocamento desejado.*/

            int n1 = 10, n2 = 26, n3 = 256;

            Console.WriteLine("{0}, {1}, {2}", n1, n2, n3); //Exibindo os valores originais.

            n1 = n1 << 2; //n1 dobrará seu valor.
            n2 = n2 >> 1; //n2 terá seu valor diminuído pela metade.

            n3 = n3 << 1;   //Podemos informar o número de bits deslocados também.

            Console.WriteLine("\n");

            Console.WriteLine("{0}, {1}, {2}", n1, n2, n3);
        }
    }
}