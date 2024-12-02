using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO03
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade:");
            int idade = int.Parse(Console.ReadLine());

            switch (idade)
            {
                case int n when (n >= 0 && n <= 12):
                    Console.WriteLine("Classificação: Criança");
                    break;
                case int n when (n >= 13 && n <= 17):
                    Console.WriteLine("Classificação: Adolescente");
                    break;
                case int n when (n >= 18 && n <= 59):
                    Console.WriteLine("Classificação: Adulto");
                    break;
                case int n when (n >= 60):
                    Console.WriteLine("Classificação: Idoso");
                    break;
                default:
                    Console.WriteLine("Idade inválida.");
                    break;
            }
        }
    }
}

