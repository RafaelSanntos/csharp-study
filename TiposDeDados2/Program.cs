// Tipos de dados - Decimal

float valor1 = 1.234F;          //6 a 9 digitos após a virgula
double valor2 = 1.234D;         //15 a 17 digitos após a virgula (calculo científico)
decimal valor3 = 1.234M;        //28 a 29 digitos após a virgula (usado para financeiro)

Console.WriteLine("Exibindo valores com casas decimais");

Console.WriteLine($@"
{valor1}
{valor1}
{valor1}");

Console.WriteLine("\nComparando a precisão de float, double e decimal");

float x = 1F / 3F;
double y = 1D / 3D;
decimal z = 1M / 3M;

Console.WriteLine($@"
{x}
{y}
{z}");
