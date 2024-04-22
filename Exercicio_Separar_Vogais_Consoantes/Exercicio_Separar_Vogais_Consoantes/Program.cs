/*
 2-) Faça um vetor de caracteres de 10 posições e imprima os seguintes itens: a) somente as vogais, b) somente as consoantes
*/

char[] vogais = new char[10];
char[] consoantes = new char[10];
char[] letras = new char[10];
int i;

for(i = 0; i < 10; i++)
{
    Console.Write($"Digite a {(i+1)}ª letra: ");
    letras[i] = char.Parse(Console.ReadLine());
    if((letras[i] == 'a') || (letras[i] == 'e') || (letras[i] == 'i') || (letras[i] == 'o') || (letras[i] == 'u'))
    {
        vogais[i] = letras[i];
    }
    else
    {
        consoantes[i] = letras[i];
    }
}
Console.Write("\n\nVogais: ");
for (i = 0; i < 10; i++)
{
    if (letras[i] == vogais[i])
    {
        Console.Write($"{letras[i]} ");
    }
}
Console.Write("\n\nConsoantes: ");
for (i = 0; i < 10; i++)
{
    if (letras[i] == consoantes[i])
    {
        Console.Write($"{letras[i]} ");
    }
}
Console.WriteLine();