using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int linha = 5, coluna = 5;
            int[,] matriz = new int[linha, coluna];
            matriz = inserirMatriz(linha, coluna);
            mostrarMatriz(matriz);
        }

        private static int[,] inserirMatriz(int l, int c)
        {
            int linha = 7, cont = 0, coluna = 3;
            telaInicial();
            int[,] matriz = new int[l, c];
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    Console.SetCursorPosition(coluna, linha);
                    matriz[x, y] = int.Parse(Console.ReadLine());
                    if (cont < 4)
                    {
                        coluna = coluna + 7;
                        cont++;
                    }
                    else
                    {
                        linha = linha + 2;
                        coluna = 3;
                        cont = 0;
                    }
                }
            }
            Console.ReadKey();
            return matriz;
        }

        private static int[,] mostrarMatriz(int[,] matriz)
        {
            int linha = 7, cont = 0, coluna = 3;
            int l = 0, c = 4;
            telaInicial();
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (l == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(coluna, linha);
                        Console.WriteLine(matriz[x, y]);
                    }
                    if (c == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(coluna, linha);
                        Console.WriteLine(matriz[x, y]);
                    }
                    if (cont < 4)
                    {
                        coluna = coluna + 7;
                        cont++;
                    }
                    else
                    {
                        linha = linha + 2;
                        coluna = 3;
                        cont = 0;
                    }
                }
                l++;
                c--;
            }
            Console.ReadKey();
            return matriz;
        }

        private static void telaInicial()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("| Matriz de Números |");
            Console.WriteLine("====================================");
            Console.WriteLine("| Colunas |");
            Console.WriteLine("====================================");
            Console.WriteLine("| 1º | 2º | 3º | 4º | 5º |");
            Console.WriteLine("====================================");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("| | | | | |");
            Console.WriteLine("====================================");

        }
    }
}
