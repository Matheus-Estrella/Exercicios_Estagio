using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Tetra_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBEM VINDO A CALCULADORA TETRAOPERACIONAL\n" +
                "Escolha qual operação matematica deseja realizar (quatro vezes)\n\n" +
                "1-) Soma" +
                "\n2-) Subtração" +
                "\n3-) Multiplicação" +
                "\n4-) Divisão\n\n");
            int op;
            float num1, num2, num3, num4, result;
            op = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o terceiro número: ");
            num3 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o quarto número: ");
            num4 = float.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    result = num1 + num2 + num3 + num4;
                    Console.WriteLine($"\n{num1} + {num2} + {num3} + {num4} = {result} \n");
                    break;
                case 2:
                    result = num1 - num2 - num3 - num4;
                    Console.WriteLine($"\n{num1} - {num2} - {num3} - {num4} = {result} \n");
                    break;
                case 3:
                    result = num1 * num2 * num3 * num4;
                    Console.WriteLine($"\n{num1} * {num2} * {num3} * {num4} = {result} \n");
                    break;
                case 4:
                    if((num2 != 0)&& (num3 != 0)&& (num4 != 0))
                    {
                        result = num1/num2 /num3/num4;
                        Console.WriteLine($"\n{num1} / {num2} / {num3} / {num4} = {result} \n");
                    }
                    else
                    {
                        Console.WriteLine("\nNão é possível dividir por zero\n");
                    }
                    break;
            }
        }
    }
}
