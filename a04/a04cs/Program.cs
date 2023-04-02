namespace a04cs;
class Program
{
    /*Criando uma classe Pessoa.*/
    class Pessoa{
        private string nome;
        private int idade;

        public void setNome(string nome){
            this.nome = nome;
        }

        public string getNome(){
            return this.nome;
        }

        public void setIdade(int idade){
            this.idade = idade;
        }

        public int getIdade(){
            return this.idade;
        }

        public void verDados(){
            Console.WriteLine("Nome: {0}\nIdade: {1}", getNome(), getIdade());
        }
    }

    static void Main(string[] args)
    {
        /*Instanciando um novo objeto de 'Pessoa'.*/
        Pessoa p1 = new Pessoa();
        p1.setNome("Matheus");
        p1.setIdade(19);

        p1.verDados();
    }
}