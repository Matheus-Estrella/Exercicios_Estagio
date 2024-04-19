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
            int op;
            float num1, num2, num3, num4, result;

            do
            {
                Console.WriteLine("\nBEM VINDO A CALCULADORA TETRAOPERACIONAL\n" +
                "Escolha qual operação matematica deseja realizar (quatro vezes)\n\n" +
                "1-) Soma" +
                "\n2-) Subtração" +
                "\n3-) Multiplicação" +
                "\n4-) Divisão" +
                "\n5-) Sair\n\n");
                do
                {
                    op = int.Parse(Console.ReadLine());
                    if ((op < 0) && (op > 5))
                    {
                        Console.WriteLine("\nEscolha uma opção válida\n");
                    }
                } while ((op < 0) && (op > 5));
                if ((op != 5))
                {
                    Console.Write("\nDigite o primeiro número: ");
                    num1 = float.Parse(Console.ReadLine()); do
                    {
                        Console.Write("\nDigite o segundo número: ");
                        num2 = float.Parse(Console.ReadLine());
                        if ((num2 == 0))
                        {
                            Console.WriteLine("O valor deve ser diferente de zero");
                        }
                    } while ((num2 == 0) && (op != 5));
                    do
                    {
                        Console.Write("\nDigite o terceiro número: ");
                        num3 = float.Parse(Console.ReadLine());
                        if ((num3 == 0))
                        {
                            Console.WriteLine("O valor deve ser diferente de zero");
                        }
                    } while ((num3 == 0) && (op != 5));
                    do
                    {
                        Console.Write("\nDigite o quarto número: ");
                        num4 = float.Parse(Console.ReadLine());
                        if ((num4 == 0))
                        {
                            Console.WriteLine("O valor deve ser diferente de zero");
                        }
                    } while ((num4 == 0) && (op != 5));

                }
                else { num1 = 0; num2 = 0; num3 = 0; num4 = 0; }

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
                        result = num1 / num2 / num3 / num4;
                        Console.WriteLine($"\n{num1} / {num2} / {num3} / {num4} = {result} \n");
                        break;
                    case 5:
                        Console.WriteLine("\n\nSaindo.....\n\n");
                        break;
                }
            } while (op != 5);
        }
    }
}

