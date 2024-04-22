//Crie um programa que guarde 5 numeros em um vetor de inteiros

char letra;
char[] palavra = new char[5];
for( int i = 0; i<5; i++)
{
    palavra[i] = char.Parse(Console.ReadLine());
}
for( int i = 0;i<5; i++)
{
    Console.WriteLine($"{palavra[i]}[{i}]");
}
