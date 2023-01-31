using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int nlin = 3, ncol = 5;
            int[,] numero = new int[nlin, ncol];
            int SOMA = 0;
            int l, c;
            for (l = 0; l < nlin; l++)
            {
                for (c = 0; c < ncol; c++)
                {
                    Console.Write("Entre com o valor ");
                    numero[l, c] = int.Parse(Console.ReadLine());
                }
            }
            for (l = 0; l < nlin; l++)
            {
                for (c = 0; c < ncol; c++)
                {
                    SOMA = SOMA + numero[l, c];
                }
                Console.WriteLine("A soma da linha " + (l + 1) + " é " + SOMA);
                SOMA = 0;
            }
            Console.ReadKey();

        }
    }
}
