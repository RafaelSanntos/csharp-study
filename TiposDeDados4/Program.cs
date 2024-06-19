Console.WriteLine("Definindo variáveis do tipo string, var, object e dynamic: ");

string nome = "Rafael";
nome = "Rafael Santos";

Console.WriteLine(nome);

Console.WriteLine("------------------------------\n");

var idade = 21; // var o compilador define o tipo automaticamente
Console.WriteLine(idade);

Console.WriteLine("------------------------------\n");

object obj = "Olá, mundo!";
Console.WriteLine(obj); // Saída: Olá, mundo!

// Como obj é um object, precisamos fazer um cast (conversão de tipos) para usar métodos específicos como os de string
string str = (string)obj;
Console.WriteLine(str.ToUpper());  // Saída: OLÁ, MUNDO!

Console.WriteLine("------------------------------\n");

// Tipo dynamic é util quando usamos Reflection - retorna metadados em tempo de execução

dynamic dyn = "Olá, mundo!";
Console.WriteLine(dyn);  // Saída: Olá, mundo!

// Como dyn é um dynamic, podemos usar métodos específicos de string diretamente
Console.WriteLine(dyn.ToUpper());  // Saída: OLÁ, MUNDO!