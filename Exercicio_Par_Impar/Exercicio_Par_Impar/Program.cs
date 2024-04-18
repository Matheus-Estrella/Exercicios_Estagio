using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num;
            Console.Write("Insira um número: ");
            num = float.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"O número {num} é par");
            }
            else
            {
                Console.WriteLine($"O número {num} é impar");
            }
        }
    }
}
