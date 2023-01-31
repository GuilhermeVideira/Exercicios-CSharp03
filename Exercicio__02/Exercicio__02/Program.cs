using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle, linha = 2;
            string[] nomeProd = new string[10];
            double[] precoProd = new double[10];
            double valorBase = 0;
            Console.Title = "CURSO C#";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 0);
            Console.Write("EXERCÍCIO 2 - Cadastro Produtos");
            for (controle = 0; controle < 10; controle++)
            {
                Console.SetCursorPosition(5, linha);
                Console.Write("Digite nome produto: ");
                nomeProd[controle] = Console.ReadLine();
                Console.SetCursorPosition(45, linha);
                Console.Write("Digite preço produto: ");
                precoProd[controle] = Convert.ToDouble(Console.ReadLine());
                linha++;
            }
            Console.SetCursorPosition(5, 13);
            Console.Write("Informe um valor para pesquisa nos vetores: ");
            valorBase = Convert.ToDouble(Console.ReadLine());
            linha = 14;
            for (controle = 0; controle < 10; controle++)
            {
                if (precoProd[controle] <= valorBase)
                {
                    Console.SetCursorPosition(5, linha);
                    Console.Write("Vetor {0}, Valor{1:c}", controle, precoProd[controle]);
                    linha++;
                }
            }
            Console.ReadKey();
        }

    }
}

