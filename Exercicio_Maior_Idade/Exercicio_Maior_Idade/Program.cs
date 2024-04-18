using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Maior_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            do
            {
                Console.Write("Insira sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if(idade < 0)
                {
                    Console.WriteLine("\nIdade negativa é impossível :)\n");
                }
            }while(idade < 0);
            if(idade >0)
            {
                if (idade >= 18)
                {
                    Console.WriteLine($"\nCom {idade} anos você é maior de idade\n");
                }
                else
                {
                    Console.WriteLine($"\nCom {idade} anos você é menor de idade\n");
                }
            }
        }
    }
}
