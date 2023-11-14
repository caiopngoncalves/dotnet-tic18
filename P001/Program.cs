// 1:

// Verificar  se o .NET SDK está corretamente instalado:  dotnet --version

// Listar Todas as Versões Instaladas do .NET SDK: dotnet --list-sdks

// Remover uma Versão Específica do .NET SDK: dotnet --uninstall-sdk <versão>

// Atualizar o .NET SDK para a Última Versão Estável: dotnet --install-dir /usr/share/dotnet

// 2:
Console.WriteLine($"Problema 2:");
Console.WriteLine();

int idade = 25;
int quantidadeProdutos = 100;

int somaIdadeProdutos = idade + quantidadeProdutos;
Console.WriteLine($"A soma da idade e da quantidade de produtos é: {somaIdadeProdutos}");

decimal precoUnitario = 29.99m;
decimal quantidadeComprada = 3;

decimal totalCompra = precoUnitario * quantidadeComprada;
Console.WriteLine($"O total da compra é: {totalCompra:C}");

long populacaoMundial = 7800000000L;
long pupulaçãoBrasil = 384400000L;

long populacaoTotal = populacaoMundial - pupulaçãoBrasil;
Console.WriteLine($"A soma da população mundial menos a população do Brasil é: {populacaoTotal}");

float alturaMontanha = 8848.86f;
float profundidadeOceano = -10994.0f;

float alturaAbsoluta = Math.Abs(alturaMontanha) + Math.Abs(profundidadeOceano);
Console.WriteLine($"A altura absoluta da montanha é: {alturaAbsoluta}");

double distanciaEstelar = 4.22;
double volumeGalaxia = 3.25;

double densidadeGalaxia = volumeGalaxia / distanciaEstelar;
Console.WriteLine($"A densidade média da galáxia é: {densidadeGalaxia:E}");

Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine();
//3: Ao converter uma variável do tipo double para int em C#, a parte fracionária da variável será removida e o valor é arredondado
Console.WriteLine($"Problema 3:");
Console.WriteLine();

double numeroDouble = 10.05;

int numeroInteiro = Convert.ToInt32(numeroDouble);
Console.WriteLine($"Número Inteiro: {numeroInteiro}");

Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine();
//4: 
Console.WriteLine($"Problema 4:");
Console.WriteLine();

int x = 10;
int y = 3;

int adicao = x + y;
int subtracao = x - y;
int multiplicacao = x * y;

int divisao = (y != 0) ? x / y : 0;

Console.WriteLine($"Adição: {adicao}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");

Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine();
//5:
Console.WriteLine($"Problema 5:");

int a = 5;
int b = 8;

bool aMaiorQueB = a > b;

if (aMaiorQueB)
{
    Console.WriteLine("a é maior que b.");
}
else
{
    Console.WriteLine("a não é maior que b.");
}
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine();
//6:
Console.WriteLine($"Problema 6:");

string str1 = "Hello";
string str2 = "World";

bool saoIguais = string.Equals(str1, str2);

if (saoIguais)
{
    Console.WriteLine("As strings são iguais.");
}
else
{
    Console.WriteLine("As strings são diferentes.");
}
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine();
//7:
Console.WriteLine($"Problema 7:");

bool condicao1 = true;
bool condicao2 = false;

bool ambasVerdadeiras = condicao1 && condicao2;

if (ambasVerdadeiras)
{
    Console.WriteLine("Ambas as condições são verdadeiras.");
}
else
{
    Console.WriteLine("Pelo menos uma das condições não é verdadeira.");
}
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine();
//8:
Console.WriteLine($"Problema 8:");

int num1 = 7;
int num2 = 3;
int num3 = 10;

bool num1MaiorQueNum2 = num1 > num2;

bool num3IgualSomaNum1Num2 = num3 == (num1 + num2);

if (num1MaiorQueNum2)
{
    Console.WriteLine("num1 é maior que num2.");
}
else
{
    Console.WriteLine("num1 não é maior que num2.");
}

if (num3IgualSomaNum1Num2)
{
    Console.WriteLine("num3 é igual a num1 + num2.");
}
else
{
    Console.WriteLine("num3 não é igual a num1 + num2.");
}
Console.WriteLine();