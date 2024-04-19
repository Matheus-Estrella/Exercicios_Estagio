// 5-) Faça um programa que leia o valor atual do salário de uma pessoa
// e o valor, com acrescimo, e informe a porcentagem de acréscimo que foi dada;

float salario=0, acrescimo=0, porcentagem=0;
do
{
    Console.Write("\nDigite o valor do seu salário: ");
    salario = float.Parse(Console.ReadLine());
    if (salario <= 0)
    {
        Console.WriteLine("\nIsso não é salário, é trabalho escravo viu !!!\n Digite um salário positivo\n");
    }
} while (salario <= 0);
do
{
    Console.Write("\nDigite o valor do seu salário: ");
    acrescimo = float.Parse(Console.ReadLine());
    if (acrescimo <= 0)
    {
        Console.WriteLine("\nIsso não é aumento, você foi tapeado !!!\n Digite um aumento positivo\n");
    }
} while (acrescimo <= 0);
porcentagem = (((salario + acrescimo) / salario)-1)*100;
Console.WriteLine($"\nSeu salário de {salario} reais foi acrescido em {porcentagem}% com o aumento de {acrescimo} reais, seu salário atual é {salario+acrescimo} reais\n");