/*
 
 1-) Faça um programa que leia 10 números inteiros e imprima os seguintes itens: 
 a) somente os valores pares, 
 b) somente valores ímpares,
 c) somente a primeira e a última posição.

*/
int num=0, op=0, i=0;
int[] pares = new int[10];
int[] impares = new int[10];
int LIFO = 0,OFIL = 0;

for (i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {(i+1)}º número: ");
    num = int.Parse(Console.ReadLine());
    if(i == 0)
    {
        LIFO = num;
    }
    if( i == 9)
    {
        OFIL = num;
    }
    if ( i% 2 == 0)
    {
        pares[i] = num;
 
    }
    else
    {
        impares[i] = num;
    }
}
Console.Write("Digite a opção desejada: \n1-) Imprimir Pares;\n2-) Imprimir Impares;\n3-) Imprimir Extremidades\n: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        Console.Write("\nOs números pares são: ");
        for (i = 0; i<10; i++)
        {
            if(pares[i] != 0)
            {
                Console.Write($"{pares[i]} - ");
            }
        }
        break;
    case 2:
        Console.Write("\nOs números ímpares são: ");
        for (i = 0; i < 10; i++)
        {
            if (impares[i] != 0)
            {
                Console.Write($"{impares[i]} - ");
            }
        }
        break;
    case 3:
        Console.WriteLine($"O primeiro valor inserido é {LIFO}, enquanto o último é {OFIL}");
        break;
    default:
        Console.WriteLine("Digite um valor válido");
        break;
}