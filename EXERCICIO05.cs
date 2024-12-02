using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO05
    {
        public static void Main(string[] args)
        {
            Exercicio5(); // Chama diretamente o Exercício 5
        }

        static void Exercicio5()
        {
            Console.WriteLine("Digite a nota do aluno (0 a 10):");
            double nota = double.Parse(Console.ReadLine());

            switch (nota)
            {
                case double n when (n >= 9 && n <= 10):
                    Console.WriteLine("Classificação: A");
                    break;
                case double n when (n >= 7 && n < 9):
                    Console.WriteLine("Classificação: B");
                    break;
                case double n when (n >= 5 && n < 7):
                    Console.WriteLine("Classificação: C");
                    break;
                case double n when (n >= 3 && n < 5):
                    Console.WriteLine("Classificação: D");
                    break;
                case double n when (n >= 0 && n < 3):
                    Console.WriteLine("Classificação: F");
                    break;
                default:
                    Console.WriteLine("Nota inválida. Por favor, insira uma nota entre 0 e 10.");
                    break;
            }
        }
    }
}

