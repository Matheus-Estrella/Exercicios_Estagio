// 3-) Faça um programa que leia os três lados de um triângulo e informe o tipo de triângulos (dentre os três tipos);

float ladoA = 0, ladoB = 0, ladoC = 0, soma;
string tipo="";

do
{
    Console.WriteLine("\nDigite o número do lado A: \n");
    ladoA = float.Parse(Console.ReadLine());
    if (ladoA <= 0)
    {
        Console.WriteLine("\nNão existe medida nula ou negativa\n");
    }
} while (ladoA <= 0);
do
{
    Console.WriteLine("\nDigite o número do lado B: \n");
    ladoB = float.Parse(Console.ReadLine());
    if (ladoB <= 0)
    {
        Console.WriteLine("\nNão existe medida nula ou negativa\n");
    }
} while (ladoB <= 0);
do
{
    Console.WriteLine("\nDigite o número do lado C: \n");
    ladoC = float.Parse(Console.ReadLine());
    if (ladoC <= 0)
    {
        Console.WriteLine("\nNão existe medida nula ou negativa\n");
    }
} while (ladoC <= 0);
if ((ladoA < (ladoB + ladoC))&& (ladoB < (ladoA + ladoC))&& (ladoC < (ladoB + ladoA)))
{
    if ((ladoA == ladoB) && (ladoB == ladoC))
    {
        tipo = "equilátero";
    }
    if ((ladoA != ladoB) && (ladoB != ladoC) && (ladoA != ladoC))
    {
        tipo = "escaleno";
    }
    if (((ladoA == ladoB)&&(ladoC != ladoA))||((ladoA == ladoC) && (ladoB != ladoA)) ||((ladoC == ladoB) && (ladoC != ladoA)))
    {
        tipo = "isóceles";
    }
    Console.WriteLine($"\nO triângulo é {tipo}\n");
}
else
{
    Console.WriteLine("\nOs valores inseridos não formam um triângulo\n");
}
