// 2-) Faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores de idade;

int i, idade=0, menores=0, maiores=0, maioridade = 18;
for(i=0; i<10; i++)
{
    do
    {
        Console.Write($"\nInsira a idade da {(i)+1}ª pessoa: ");
        idade = int.Parse(Console.ReadLine());
        if(idade < 0)
        {
            Console.WriteLine("\nÉ impossível existir idade negativa, insira uma correta\n");
        }
    } while(idade < 0);
    if(idade < maioridade)
    {
        menores++;
    }
    else
    {
        maiores++;
    }
}
int op;
Console.WriteLine("Digite uma opção para mostrar a quantidade das idades:\n1-) Menores de Idade;\n2-) Maiores de Idade");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        Console.WriteLine($"\n\nHá {menores} menores de idade \n\n");
        break;
    case 2:
        Console.WriteLine($"\n\nHá {maiores} maiores de idade \n\n");
        break;
    default:
        Console.WriteLine("\nInsira uma opção válida");
        break;
}
