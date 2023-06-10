namespace a17cs2;
class Program
{
    static void Main(string[] args)
    {
        //Array de tamanho fixo. Literalmente cria-se uma instÇancia de array de inteiro onde
        //é informado um tamanho fixo, neste caso, um array de inteiro de 3 elementos.
        int[] numeros = new int[3];

        numeros[0] = 2;
        numeros[1] = 43;
        numeros[2] = 543;

        //Sendo um array fixo de comprimento 3, há apenas três índices de espaço disponíveis,
        //indo de 0 à 2. Um novo índice de 3 em diante é impossível.
        numeros[3] = 74;

        Console.WriteLine(numeros.Length);
    }
}
