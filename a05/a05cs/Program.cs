namespace a05cs;
class Program
{

    static void verifMaioridade(params int[] idade){
        string resCompMariodade = idade[0] >= 18 || idade[1] >= 18 ? "Uma dessas pessoas é maior de idade." : "Ninguém é maior de idade."; 

        Console.WriteLine(resCompMariodade);
    }

    static void Main(string[] args){
        /*Programa que pergunta nome e idade pro usuário.*/
        /*Utilizando operadores.*/

        Console.Write("Insira um nome: ");
        string? nome1 = Console.ReadLine();

        Console.Write("Quantos anos {0} tem? ", nome1);
        int idade1 = int.Parse(Console.ReadLine());

        Console.Write("Insira outro nome: ");
        string? nome2 = Console.ReadLine();

        Console.Write("Quantos anos {0} tem? ", nome2);
        int idade2 = int.Parse(Console.ReadLine());

        string resCompIdade = idade1 > idade2 ? $"{nome1} é mais velho que {nome2}.\n" : $"{nome2} é mais velho(a) que {nome1}.\n";

        string resSomaIdade = $"A soma de {idade1} e {idade2} é igual a {idade1 + idade2}.";

        Console.Clear();
        Console.Beep();

        Console.WriteLine(resCompIdade + resSomaIdade);
        verifMaioridade(idade1, idade2);
    }
}