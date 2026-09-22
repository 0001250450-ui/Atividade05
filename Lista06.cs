A) using System;

class Program

{

static void Main()

{

Console.WriteLine("Data e Hora Atual: " + DateTime.Now);

}

}

B) using System;

class Program

{

static void Main()

{

Console.Write("Digite a primeira data (dd/mm/aaaa): ");

DateTime data1 = DateTime.Parse(Console.ReadLine());

Console.Write("Digite a segunda data (dd/mm/aaaa): ");

DateTime data2 = DateTime.Parse(Console.ReadLine());

TimeSpan diferenca = data2 - data1;

Console.WriteLine($"Diferença: {Math.Abs(diferenca.Days)} dias.");

}

}

C)

using System;

class Program

{

static void Main()

{

Console.Write("Digite a data de nascimento (dd/mm/aaaa): ");

DateTime nascimento = DateTime.Parse(Console.ReadLine());

DateTime hoje = DateTime.Today;

int idade = hoje.Year - nascimento.Year;

if (nascimento.Date > hoje.AddYears(-idade)) idade--;

Console.WriteLine($"Sua idade é: {idade} anos.");

}

}

d) using System;

class Program

{

static void Main()

{

Console.Write("Digite uma data (dd/mm): ");

string data = Console.ReadLine();

switch (data)

{

case "01/01":

case "21/04":

case "01/05":

case "07/09":

case "12/10":

case "02/11":

case "15/11":

case "25/12":

Console.WriteLine("É um feriado nacional!");

break;

default:

Console.WriteLine("Não é um feriado nacional cadastrado.");

break;

}

}

}

e) using System;

class Program

{

static void Main()

{

Console.WriteLine("Escolha uma opção:\n1 - Opção 1\n2 - Opção 2\n3 - Opção 3");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)

{

case 1:

Console.WriteLine("Você escolheu a Opção 1.");

break;

case 2:

Console.WriteLine("Você escolheu a Opção 2.");

break;

case 3:

Console.WriteLine("Você escolheu a Opção 3.");

break;

default:

Console.WriteLine("Opção inválida.");

break;

}

}

}

F) using System;

class Program

{

static void Main()

{

Console.Write("Digite um número inteiro: ");

int numero = int.Parse(Console.ReadLine());

if (numero > 0)

Console.WriteLine("O número é positivo.");

else if (numero < 0)

Console.WriteLine("O número é negativo.");

else

Console.WriteLine("O número é zero.");

}

}

g) using System;

class Program

{

static void Main()

{

Console.Write("Escolha uma cor (vermelho, azul ou verde): ");

string cor = Console.ReadLine().ToLower();

switch (cor)

{

case "vermelho":

case "azul":

case "verde":

Console.WriteLine($"A cor escolhida foi: {cor}.");

break;

default:

Console.WriteLine("Cor inválida.");

break;

}

}

}

h) using System;

class Program

{

static void Main()

{

Console.Write("Digite uma letra: ");

char letra = char.ToLower(Console.ReadKey().KeyChar);

Console.WriteLine();

switch (letra)

{

case 'a': case 'e': case 'i': case 'o': case 'u':

Console.WriteLine("É uma vogal.");

break;

default:

if (char.IsLetter(letra))

Console.WriteLine("É uma consoante.");

else

Console.WriteLine("Caractere inválido.");

break;

}

}

}

I) using System;

class Program

{

static void Main()

{

Console.Write("Digite um número de 1 a 7: ");

int dia = int.Parse(Console.ReadLine());

switch (dia)

{

case 1: Console.WriteLine("Domingo"); break;

case 2: Console.WriteLine("Segunda-feira"); break;

case 3: Console.WriteLine("Terça-feira"); break;

case 4: Console.WriteLine("Quarta-feira"); break;

case 5: Console.WriteLine("Quinta-feira"); break;

case 6: Console.WriteLine("Sexta-feira"); break;

case 7: Console.WriteLine("Sábado"); break;

default: Console.WriteLine("Número inválido."); break;

}

}

}

j) using System;

class Program

{

static void Main()

{

Console.Write("Escolha o tamanho da camiseta (P, M ou G): ");

char tamanho = char.ToUpper(Console.ReadKey().KeyChar);

Console.WriteLine();

switch (tamanho)

{

case 'P':

Console.WriteLine("Preço: R$ 30,00");

break;

case 'M':

Console.WriteLine("Preço: R$ 40,00");

break;

case 'G':

Console.WriteLine("Preço: R$ 50,00");

break;

default:

Console.WriteLine("Tamanho inválido.");

break;

}

}

}
