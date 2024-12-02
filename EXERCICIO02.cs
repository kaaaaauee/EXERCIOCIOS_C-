using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador (+, -, *, /):");
            char operador = char.Parse(Console.ReadLine());

            switch (operador)
            {
                case '+':
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido. Use +, -, * ou /.");
                    break;
            }
        }
    }
}

