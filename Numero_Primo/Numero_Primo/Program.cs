// 1-) Faça um programa que leia um número e informe se este número é primo;

int primo, num;

do
{
    Console.WriteLine("\nDigite um número para verificar se é ou não primo:");
    num = int.Parse(Console.ReadLine());
    if (num == 0)
    {
        Console.WriteLine("\nInsira um valor válido, números primos são positivos\n");
    }
} while (num >0);

