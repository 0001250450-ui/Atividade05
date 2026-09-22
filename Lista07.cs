A) using System;

class Program

{

static void Main()

{

Console.Write("Digite um número inteiro positivo: ");

int limite = int.Parse(Console.ReadLine());

int i = 0;

while (i <= limite)

{

if (i % 2 == 0) Console.WriteLine(i);

i++;

}

}

}

B) using System;

class Program

{

static void Main()

{

Console.Write("Digite um número: ");

int num = int.Parse(Console.ReadLine());

int i = 1;

while (i <= 10)

{

Console.WriteLine($"{num} x {i} = {num * i}");

i++;

}

}

}

C) using System;

class Program

{

static void Main()

{

int soma = 0;

Console.Write("Digite um número (ou 0 para parar): ");

int num = int.Parse(Console.ReadLine());

while (num != 0)

{

soma += num;

Console.Write("Digite outro número (ou 0 para parar): ");

num = int.Parse(Console.ReadLine());

}

Console.WriteLine($"Soma total: {soma}");

}

}

D) using System;

class Program

{

static void Main()

{

string senhaCorreta = "1234";

int tentativas = 0;

bool acertou = false;

while (tentativas < 3 && !acertou)

{

Console.Write("Digite a senha: ");

string senha = Console.ReadLine();

tentativas++;

if (senha == senhaCorreta)

{

acertou = true;

Console.WriteLine("Sucesso! Acesso liberado.");

}

else if (tentativas < 3)

{

Console.WriteLine("Senha incorreta. Tente novamente.");

}

}

if (!acertou) Console.WriteLine("Senha incorreta. Número de tentativas excedido.");

}

}

E) using System;

class Program

{

static void Main()

{

int soma = 0;

Console.Write("Digite um número inteiro (negativo para parar): ");

int num = int.Parse(Console.ReadLine());

while (num >= 0)

{

soma += num;

Console.Write("Digite outro número: ");

num = int.Parse(Console.ReadLine());

}

Console.WriteLine($"Soma dos números inseridos: {soma}");

}

}

F) using System;

class Program

{

static void Main()

{

Console.Write("Digite um número inteiro positivo: ");

int limite = int.Parse(Console.ReadLine());

int i = 0;

while (i <= limite)

{

if (i % 2 == 0) Console.WriteLine(i);

i++;

}

}

}

G) using System;

class Program

{

static void Main()

{

Console.Write("Digite um número inteiro positivo: ");

int limite = int.Parse(Console.ReadLine());

int i = 0;

do

{

if (i % 2 == 0) Console.WriteLine(i);

i++;

} while (i <= limite);

}

}

H) using System;

class Program

{

static void Main()

{

Console.Write("Digite um número: ");

int num = int.Parse(Console.ReadLine());

int i = 1;

do

{

Console.WriteLine($"{num} x {i} = {num * i}");

i++;

} while (i <= 10);

}

}

I) using System;

class Program

{

static void Main()

{

int soma = 0;

int num;

do

{

Console.Write("Digite um número (ou 0 para parar): ");

num = int.Parse(Console.ReadLine());

soma += num;

} while (num != 0);

Console.WriteLine($"Soma total: {soma}");

}

}

J) using System;

class Program

{

static void Main()

{

string senhaCorreta = "1234";

int tentativas = 0;

bool acertou = false;

do

{

Console.Write("Digite a senha: ");

string senha = Console.ReadLine();

tentativas++;

if (senha == senhaCorreta)

{

acertou = true;

Console.WriteLine("Sucesso! Acesso liberado.");

}

else if (tentativas < 3)

{

Console.WriteLine("Senha incorreta. Tente novamente.");

}

} while (tentativas < 3 && !acertou);

if (!acertou) Console.WriteLine("Senha incorreta. Número de tentativas excedido.");

}

}
