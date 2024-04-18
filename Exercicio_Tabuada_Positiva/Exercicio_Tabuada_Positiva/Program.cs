Console.Write("Digite um número para saber sua tabuada: ");
int num, res;
do
{
    num = int.Parse(Console.ReadLine());
    if (num <= 0)
    {
        Console.WriteLine("Digite um numero positivo");
    }
} while(num <= 0);
for(int i = 0; i <= 10; i++){

    res = i * num;
    Console.WriteLine($"{num} x {i} = {res}");
}