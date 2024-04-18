/*
 Faça um programa que leia o número inicial e um numero final, mostrando entre eles quais são os valores pares e ímpares
*/

int inicio, fim, aux;
Console.Write("Digite um número inicial: ");
inicio = int.Parse(Console.ReadLine());
do
{
    Console.Write("Digite um número final: ");
    fim = int.Parse(Console.ReadLine());
    if(fim <= inicio)
    {
        aux = inicio;
        inicio = fim;
        fim = aux;
    }
}while(fim <= inicio);
aux = inicio;

do
{
    aux++;
    if(aux < fim)
    {
        if (aux % 2 == 0)
        {
            Console.WriteLine($"O numero {aux} é par");
        }
        else
        {
            Console.WriteLine($"O numero {aux} é impar");
        }
    }
} while (aux != (fim));
