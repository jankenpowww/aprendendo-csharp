namespace a03cs;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine(nome + ", quantos anos você tem?");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantos quilos você pesa?");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Qual a sua altura?");
        float altura = float.Parse(Console.ReadLine());

        Console.WriteLine("Você é do sexo masculino ou feminino? (respectivamente 'm' ou 'f')");
        var sexo = Console.ReadLine();

        switch (sexo.ToString().ToLower()){
            case "m":
                sexo = "Masculino";
            break;

            case "f":
                sexo = "Feminino";
            break;
        }

        Console.WriteLine($"\nSeu nome é {nome} e você tem {idade} anos de idade. Peso: {peso.ToString().Substring(0, 5)}, Altura: {altura.ToString().Substring(0, 4)}. Você é do sexo {sexo}");

        /*Quando um valor não é atribuído através de conversão de tipo para float e é atribuído um valor literal, deve-se passar 'f' do lado do valor para enfatizar que ele é do tipo float.*/
        float valorFloat = 3.543f;
        Console.WriteLine(valorFloat);
    }
}
