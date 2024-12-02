using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO08
    {
        public static void Main(string[] args)
        {
            Exercicio8(); // Chama diretamente o Exercício 8
        }

        static void Exercicio8()
        {
            Console.WriteLine("Escolha a conversão de temperatura:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.Write("Digite o número da opção desejada: ");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Celsius:");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"{celsius}°C é igual a {fahrenheit:F2}°F");
                    break;

                case 2:
                    Console.WriteLine("Digite a temperatura em Fahrenheit:");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit}°F é igual a {celsius:F2}°C");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Escolha 1 ou 2.");
                    break;
            }
        }
    }
}
