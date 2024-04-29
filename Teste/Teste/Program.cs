
const int size = 15;
int[] vetor1 = new int[size];
int[] vetor2 = new int[size];
int j = 0, i;
int aux = 0;

for(i = 0; i < size; i++)
{
    vetor1[i] = new Random().Next(0,100);
    Console.Write($"{vetor1[i]}  ");
    vetor2[i] = vetor1[i];
}

for(i = 0; i < size; i++)
{
    for (j = 0; j < (size-1); j++)
    {
        if (vetor2[j] > vetor2[(j+1)])
        {
            aux = vetor2[(1 + j)];
            vetor2[(1 + j)] = vetor2[j];
            vetor2[j] = aux;
        }
    }
}

Console.Write($"\n\n");

for (i=0;i<size;i++)
{
    Console.Write($"{vetor2[i]} ");
}
Console.WriteLine();
