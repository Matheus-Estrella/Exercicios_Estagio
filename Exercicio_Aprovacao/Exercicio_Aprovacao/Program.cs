using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aprovacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2;
            Console.Write("Insira o valor da primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("\nInsira o valor da segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());
            float media;
            media = (nota1 + nota2)/2;
            if (media > 5)
            {
                Console.WriteLine($"\nAluno Aprovado, com média {media}\n");
            }
            else if(media >3)
            {
                Console.WriteLine($"\nAluno em Exame, com média {media}\n");
            }else
            {
                Console.WriteLine($"\nAluno Reprovado, com média {media}\n");
            }
        }
    }
}
