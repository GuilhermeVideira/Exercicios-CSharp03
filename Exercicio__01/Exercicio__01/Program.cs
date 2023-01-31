using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] numero = new int[n];
            numero = inserirVetor(n);
            mostrarVetor(numero);
            mostrarVetorPar(numero);
        }

        private static int[] inserirVetor(int n)
        {
            int[] numero = new int[n];
            for (int x = 0; x < numero.Length; x++)
            {
                telaInicial();
                Console.SetCursorPosition(9, 3);
                numero[x] = int.Parse(Console.ReadLine());
            }
            return numero;
        }

        private static void mostrarVetor(int[] numero)
        {
            int linha = 3, cont = 0, coluna = 4;
            telaNumero();
            for (int x = 0; x < numero.Length; x++)
            {
                Console.SetCursorPosition(coluna, linha);
                Console.WriteLine(numero[x]);
                if (cont < 4)
                {
                    coluna = coluna + 7;
                    cont++;
                }

                else
                {
                    linha = linha + 2;
                    coluna = 4;
                    cont = 0;
                }
            }
            Console.ReadKey();
        }

        private static void mostrarVetorPar(int[] numero)
        {
            int linha = 3, cont = 0, coluna = 4;
            telaNumeroPar();
            for (int x = 0; x < numero.Length; x++)
            {
                if ((x % 2) == 0)
                {
                    Console.SetCursorPosition(coluna, linha);
                    Console.WriteLine(numero[x]);
                    if (cont < 4)
                    {
                        coluna = coluna + 7;
                        cont++;
                    }
                    else
                    {
                        linha = linha + 2;
                        coluna = 4;
                        cont = 0;
                    }
                }
            }
            Console.ReadKey();
        }

        private static void telaInicial()
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("| Vetor de Números |");
            Console.WriteLine("==============================");
            Console.WriteLine("|Número: |");
            Console.WriteLine("==============================");
        }

        private static void telaNumero()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("| Vetor de Números |");
            Console.WriteLine("====================================");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("====================================");
        }

        private static void telaNumeroPar()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("| Vetor de Números Pares |");
            Console.WriteLine("====================================");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("====================================");

        }
    }
}
