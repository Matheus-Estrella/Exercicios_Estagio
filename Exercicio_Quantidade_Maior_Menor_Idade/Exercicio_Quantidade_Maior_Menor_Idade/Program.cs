// 2-) Faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores de idade;

int i, idade=0, menores=0, maiores=0, maioridade = 18;
for(i=0; i<10; i++)
{
    do
    {
        Console.WriteLine($"\nInsira a idade da {(i)+1}ª pessoa");
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
Console.WriteLine($"\n\nHá {menores} menores e {maiores} maiores de idade \n\n");
