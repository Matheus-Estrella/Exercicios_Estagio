int count=1, primo=0, num;

do
{
    Console.WriteLine("Digite um numero para verificar se é ou não primo: ");
    num = int.Parse(Console.ReadLine());
    if (num <= 1)
    {
        Console.WriteLine("\nOs numeros primos são maiores que 1\n");
    }
} while (num <= 1);

while ((primo <= 2)||(count != num))
{
    if(num % count == 0)
    {
        primo++;
        if((count == num)&& primo == 2)
        {
            Console.WriteLine($"\nO número {num} é primo\n");
        }
        else if((count != 1)&&((num % count == 0)&&((num+2) % count == 0))) 
        {
            Console.WriteLine($"\nO número {num} não é primo\n");
        }
    }
    count++;
}