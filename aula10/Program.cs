using System;

namespace aula10
{
    class Program
    {
        //Criando um Enum com os dias da semana.
        enum diaDaSem{dom, seg, ter, qua, qui, sex, sab};
        static void Main(string[] args)
        {
            Console.Clear();

            //Criando uma variável do tipo Enum criado e relacionando-o com um valor possível definido através de acessos da própria classe Enum.
            diaDaSem dia = diaDaSem.qui;
            Console.WriteLine("{0}", dia);

            Console.WriteLine("\n\n");

            //Criando uma variável do tipo Enum criado e relacionando-o com um valor possível definido dentro do Enum a partir de um índice possível.
            dia = (diaDaSem)2;
            Console.WriteLine(dia);

            Console.WriteLine("\n\n");

            //Conseguindo o valor numérico do índice correspondente a "Segunda".
            int numDia = (int)diaDaSem.seg;

            Console.WriteLine(numDia);
        }
    }
}
