// 4-) Faça um programa que leia dois valores de cateto e calcule a hipotenusa;
double cat_oposto, cat_adjacente, hipotenusa;

do
{
    Console.WriteLine("\nDigite o valor do cateto oposto\n");
    cat_oposto = double.Parse(Console.ReadLine());
    if (cat_oposto <= 0)
    {
        Console.WriteLine("\nNão existe medida nula ou negativa\n");
    }
} while (cat_oposto <= 0);
do
{
    Console.WriteLine("\nDigite o valor do cateto adjacente\n");
    cat_adjacente = double.Parse(Console.ReadLine());
    if (cat_adjacente <= 0)
    {
        Console.WriteLine("\nNão existe medida nula ou negativa\n");
    }
} while (cat_adjacente <= 0);
hipotenusa = Math.Sqrt((cat_adjacente* cat_adjacente) + (cat_oposto* cat_oposto));
Console.WriteLine($"\n\nO valor da hipotenusa é {hipotenusa}\n\n");
