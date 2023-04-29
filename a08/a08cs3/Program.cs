//Exemplo ReadKey() - é possível acessar propriedades e variáveis diretamente
//do método ao invés de declarar a estrutura ConsoleKeyInfo propriamente dita, visto
//que o único objetivo é retornar uma string com o valor pressionado.

Console.WriteLine("Digite qualquer botão...");
string botaoPressionado = Console.ReadKey().Key.ToString();

Console.WriteLine("Botão pressionado: " + botaoPressionado);