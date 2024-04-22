/*
3-)  Faça um programa que leia caracteres de 10 posições e converta as vogais de minúsculo para maiúsculo
*/

char[] letras = new char[10];
int i;

for (i = 0; i < 10; i++)
{
    Console.Write($"Digite a {(i + 1)}ª letra: ");
    letras[i] = char.Parse(Console.ReadLine());
    switch (letras[i])
    {
        case 'a':
            letras[i] = 'A';
            break;
        case 'e':
            letras[i] = 'E';
            break;
        case 'i':
            letras[i] = 'I';
            break;
        case 'o':
            letras[i] = 'O';
            break;
        case 'u':
            letras[i] = 'U';
            break;
        default:
            break;
    }
}

Console.WriteLine("\nPalavra digitada: ");
for (i = 0; i < 10; i++)
{
    Console.Write(letras[i]);
}
Console.WriteLine();
