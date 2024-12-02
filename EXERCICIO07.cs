using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO07
    {
        public static void Main(string[] args)
        {
            Exercicio7(); // Chama diretamente o Exercício 7
        }

        static void Exercicio7()
        {
            Console.WriteLine("Digite o valor do salário:");
            double salario = double.Parse(Console.ReadLine());

            double imposto = 0;


            switch (salario)
            {
                case double n when (n <= 1500):
                    imposto = salario * 0.05; // Imposto de 5% para salários até R$ 1.500
                    Console.WriteLine($"Imposto a pagar: R${imposto:F2} (5%)");
                    break;
                case double n when (n > 1500 && n <= 3000):
                    imposto = salario * 0.10; // Imposto de 10% para salários de R$ 1.501 a R$ 3.000
                    Console.WriteLine($"Imposto a pagar: R${imposto:F2} (10%)");
                    break;
                case double n when (n > 3000):
                    imposto = salario * 0.15; // Imposto de 15% para salários acima de R$ 3.000
                    Console.WriteLine($"Imposto a pagar: R${imposto:F2} (15%)");
                    break;
                default:
                    Console.WriteLine("Salário inválido.");
                    break;
            }
        }
    }
}
