//Utilizar o typecasting dentro das expressões de atribuíção 
//garante a integridade das informações e seu intuito.
//Em outras palavras: assegurar que um valor inteiro deve ser 
//passado ao invés de um valor decimal.

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Você tem {idade} anos de idade.");