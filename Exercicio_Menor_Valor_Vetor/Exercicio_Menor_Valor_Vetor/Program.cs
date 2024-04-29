const int MAX = 5;
float[] numeros = new float[MAX];
int i;
for (i = 0; i < MAX; i++)
{
    Console.Write($"\nDigite o {(i + 1)}º número: ");
    numeros[i] = float.Parse(Console.ReadLine());
}
float menor = numeros[0];
for (i=0; i < MAX; i++)
{
    if(menor >= numeros[i])
    {
        menor = numeros[i];
    }
}
Console.Write($"\n O menor número é: {menor}\n");