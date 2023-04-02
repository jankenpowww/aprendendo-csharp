namespace a04cs1;
class Program
{
    /*Escopo: o método a seguir não pode ser acessado dentro do método Main por questões de: 
    função não foi declarada dentro do escopo onde vai ser chamada.
    
    Há duas soluções possíveis: ou a estrutura do método a seguir é transformado em um método estático, ou
    ele é recortado para dentro de Main (sem o modificador 'public'))
    
    A questão do escopo ainda pode ser observada quando é impossível chamar a variável 'total', 
    já que ela só existe dentro do escopo da função em que foi declarada.*/

    /*'params' passado dentro do critério de argumentos de método pode receber mais de um valor em uma chamada de método do tipo especificado.*/
    int somarValores(params int[] valores){
        int total = 0;

        for (int i = 0; i < valores.Length; i++){
            total += valores[i];
        }

        return total;
    }

    static void Main(string[] args){
        Console.WriteLine(somarValores(1, 2, 3, 4));
    }
}