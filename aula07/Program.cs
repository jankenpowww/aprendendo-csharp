using System;

namespace aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            const int maioridade = 18;
	        int minhaIdade = 17;

	        if (minhaIdade >= maioridade){
		        Console.WriteLine("Você é maior de idade.");

	        } else {
		        Console.WriteLine("Você é menor de idade.");
            }

        }
    }
}