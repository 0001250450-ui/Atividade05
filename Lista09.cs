a) 
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[] { 10, 20, 30, 40, 50 };

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
b) 
using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] notas1 = new double[5];
        double[] notas2 = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nome do aluno " + (i + 1) + ": ");
            nomes[i] = Console.ReadLine();
            Console.Write("Nota 1: ");
            notas1[i] = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            notas2[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- LISTAGEM ---");
        for (int i = 0; i < 5; i++)
        {
            double media = (notas1[i] + notas2[i]) / 2.0;
            Console.WriteLine("Nome: " + nomes[i] + " | Nota 1: " + notas1[i] + " | Nota 2: " + notas2[i] + " | Média: " + media);
        }
    }
}
c) 
using System;

class Program
{
    static void Main()
    {
        double[] valores = new double[] { 5.5, 7.0, 8.5, 4.0, 9.2 };
        double soma = 0;

        for (int i = 0; i < valores.Length; i++)
        {
            soma += valores[i];
        }

        double media = soma / valores.Length;
        Console.WriteLine("Média dos valores: " + media);
    }
}
d) 
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[] { 15, 42, 8, 99, 23 };
        int maior = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.WriteLine("Maior valor: " + maior);
    }
}
e) 
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[] { 15, 42, 8, 99, 23 };
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine("Menor valor: " + menor);
    }
}
f) e g) Vetor soma de dois vetores de 5 elementos
using System;

class Program
{
    static void Main()
    {
        int[] v1 = new int[5];
        int[] v2 = new int[5];
        int[] soma = new int[5];

        Console.WriteLine("Preencha o primeiro vetor:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("V1[" + i + "]: ");
            v1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Preencha o segundo vetor:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("V2[" + i + "]: ");
            v2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            soma[i] = v1[i] + v2[i];
        }

        Console.WriteLine("\nVetor Soma:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Soma[" + i + "] = " + soma[i]);
        }
    }
}
h) 
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[] { 12, 5, 87, 1, 34 };

        Array.Sort(numeros);
        Array.Reverse(numeros);

        Console.WriteLine("Vetor em ordem decrescente:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
i) 
using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o nome " + (i + 1) + ": ");
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("\nListagem de Nomes:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(nomes[i]);
        }
    }
}
j) 
using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[40];
        int[] quantidades = new int[40];
        double[] precios = new double[40];
        bool cadastrado = false;
        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Cadastra mercadorias");
            Console.WriteLine("2. Exibe valor total em mercadorias da empresa");
            Console.WriteLine("3. Sair");
            Console.Write("OPÇÃO: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    for (int i = 0; i < 40; i++)
                    {
                        Console.WriteLine("\nCadastro da mercadoria " + (i + 1) + ":");
                        Console.Write("Nome: ");
                        nomes[i] = Console.ReadLine();
                        Console.Write("Quantidade: ");
                        quantidades[i] = int.Parse(Console.ReadLine());
                        Console.Write("Preço unitário: ");
                        precios[i] = double.Parse(Console.ReadLine());
                    }
                    cadastrado = true;
                    Console.WriteLine("\nMercadorias cadastradas com sucesso!");
                    break;

                case 2:
                    if (!cadastrado)
                    {
                        Console.WriteLine("\nNenhuma mercadoria foi cadastrada ainda.");
                    }
                    else
                    {
                        double valorTotal = 0;
                        for (int i = 0; i < 40; i++)
                        {
                            valorTotal += quantidades[i] * precios[i];
                        }
                        Console.WriteLine("\nValor total em mercadorias: R$ " + valorTotal);
                    }
                    break;

                case 3:
                    Console.WriteLine("\nSaindo...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        }
    }
}
