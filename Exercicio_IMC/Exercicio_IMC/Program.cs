// 6-) Faça um programa que leia o peso, altura e sexo de uma pessoa,
// e calcule o seu IMC informando a situação da pessoa;

string sexo = "", classificacao ="";
float altura =0 , IMC = 0, peso = 0;

Console.Write("\nEscreva o seu sexo: ");
sexo = Console.ReadLine();
do
{
    Console.Write("\nDigite sua altura: \n");
    altura = float.Parse(Console.ReadLine());
    if (altura <= 0)
    {
        Console.WriteLine("\nNão existe medida nula ou negativa\n");
    }
    if(altura > 2.51)
    {
        Console.WriteLine("\nVocê é mais alto que a pessoa mais alta do mundo?\nProcure um médico, pois o IMC não será adequado a você\n");
    }
} while ((altura > 2.51)||(altura <= 0));
do
{
    Console.Write("\nDigite seu peso: \n");
    peso = float.Parse(Console.ReadLine());
    if (peso <= 0)
    {
        Console.WriteLine("\nNão existe massa nula ou negativa\n");
    }
    if (peso > 444)
    {
        Console.WriteLine("\nVocê esta com o maior peso humano do mundo?\nProcure um médico, pois o IMC não será adequado a você\n");
    }
} while ((peso > 444)||(peso <= 0));
IMC = ((peso)/(altura*altura));
if (IMC < 16)
{
    classificacao = "Magreza Grau III";
}
if ((IMC >= 16) && (IMC <= 16.9))
{
    classificacao = "Magreza Grau II";
}
if ((IMC >= 17) && (IMC <= 18.4))
{
    classificacao = "Magreza Grau I";
}
if ((IMC >= 18.5) && (IMC <= 24.9))
{
    classificacao = "Eutrofia";
}
if ((IMC >= 25) && (IMC <= 29.9))
{
    classificacao = "Pré-Obesidade";
}
if ((IMC >= 25) && (IMC <= 34.9))
{
    classificacao = "Obesidade Grau I";
}
if ((IMC >= 35) && (IMC <= 39.9))
{
    classificacao = "Obesidade Grau II";
}
if (IMC > 40 )
{
    classificacao = "Obesidade Grau III";
}
Console.WriteLine($"\n\nVocê se identifica como {sexo}, possui IMC = {IMC},logo esta classificado como: {classificacao}");