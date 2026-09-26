a)
using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 100; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
b) 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int limite = int.Parse(Console.ReadLine());

        for (int i = 0; i <= limite; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
c) 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        for (int i = 0; i < palavra.Length; i++)
        {
            Console.WriteLine(palavra[i]);
        }
    }
}
d) 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int limite = int.Parse(Console.ReadLine());
        int soma = 0;

        for (int i = 1; i <= limite; i++)
        {
            soma += i;
        }

        Console.WriteLine("Soma: " + soma);
    }
}
e) 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());
        int divisores = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            Console.WriteLine("É primo.");
        }
        else
        {
            Console.WriteLine("Não é primo.");
        }
    }
}
f) 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos números deseja inserir? ");
        int quantidade = int.Parse(Console.ReadLine());

        int maior = int.MinValue;

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite o número " + (i + 1) + ": ");
            int num = int.Parse(Console.ReadLine());

            if (num > maior)
            {
                maior = num;
            }
        }

        Console.WriteLine("O maior número inserido foi: " + maior);
    }
}
g) 
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("5 x " + i + " = " + (5 * i));
        }
    }
}
h) 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Divisores de " + num + ":");
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
i)
using System;

class Program
{
    static void Main()
    {
        for (int num = 1; num <= 100; num++)
        {
            int divisores = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
j)
using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        for (int i = 2; i <= 100; i += 2)
        {
            soma += i;
        }

        Console.WriteLine("Soma dos pares de 1 a 100: " + soma);
    }
}
