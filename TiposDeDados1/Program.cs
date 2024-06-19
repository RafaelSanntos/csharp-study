
const sbyte idade = 21; //declarando constante

//declarando variáveis:

sbyte valor1 = -128;                            // -128 a 127
byte valor2 = 255;                              // 0 a 225
short valor3 = -32768;                          // -32768 a -32767
ushort valor4 = 65535;                          // 0 a 65535
int valor5 = -2147483648;                       // -2147483648 a 2147483647
uint valor6 = 4294967295;                       // 0 a 4294967295
long valor7 = -9223372036854775808;             // -9223372036854775808 a 9223372036854775807
ulong valor8 = 18446744073709551615;            // 0 a 18446744073709551615

Console.WriteLine($"Tenho {idade} anos e estou declarando variáveis numéricas:");

Console.WriteLine($@"
sbyte:  {valor1}
byte:   {valor2}
short:  {valor3}
ushort: {valor4}
int:    {valor5}
uint:   {valor6}
long:   {valor7}
ulong:  {valor8}
");
