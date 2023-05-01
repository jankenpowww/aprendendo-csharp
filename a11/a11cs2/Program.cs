//Conversões de tipo.

//Automática: ela acontece naturalmente durante atribuição
//de valores entre as variáveis. Podem ser de tipos diferentes, mas
//como esses valores são numéricos, a atribuição é correta.

//Note que atribuir um float para double é completamente aceitável, 
//e o contrário não. Isso porquê double define um tipo de comprimento maior do que float.
//

double n1 = 3.43d;
float n2 = (float) n1;

Console.WriteLine("Valor de n1: {0}", n1);
Console.WriteLine("Valor de n2: {0}", n2);