using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] matriz = new String[3, 3];
            String vencedor = "";
            //Desenha o tabuleiro 
            Console.WriteLine("");
            Console.WriteLine(" -|-|-");
            Console.WriteLine(" -|-|-");
            Console.WriteLine(" -|-|-");
            String jogador = "X";
            Boolean Continua = true;
            int acertos = 0;
            do
            {
                int l, c; 
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Vez do {0} ", jogador);
                Console.Write("Digite a linha: "); l = int.Parse(Console.ReadLine());
                Console.Write("Digite a coluna: "); c = int.Parse(Console.ReadLine());
                if (l >= 1 && l <= 3 && c >= 1 && c <= 3)
                {
                    if (matriz[l - 1, c - 1] == null)
                    {
                        if (c == 1) { Console.SetCursorPosition(c, l); }
                        else if (c == 2) { Console.SetCursorPosition(c + 1, l); }
                        else if(c == 3) { Console.SetCursorPosition(c + 2, l); }
                        Console.Write("{0}", jogador);
                        acertos++;
                        matriz[l - 1, c - 1] = jogador;
                        if (jogador.Equals("X"))
                        {
                            jogador = "O";
                        }
                        else
                        {
                            jogador = "X";
                        }
                    }
                    else
                    {
                        Console.Write("Posição já marcada!");
                    }
                }
                else
                {
                    Console.Write("Posição incorreta!");
                    Console.ReadKey();
                }
                Console.SetCursorPosition(0, 8);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                //Testa linhas 
                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2] && matriz[0, 0] != null)
                {
                    Continua = false;
                    vencedor = matriz[0, 0];
                }
                else if(matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2] && matriz[1, 0] != null)
            {
                    Continua = false;
                    vencedor = matriz[1, 0];
                }
                else if(matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2] && matriz[2, 0] != null)
            {
                    Continua = false;
                    vencedor = matriz[2, 0];
                }
                //Testa colunas 
                else if(matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0] && matriz[0, 0] != null)
            {
                    Continua = false;
                    vencedor = matriz[0, 0];
                }
                else if(matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1] && matriz[0, 1] != null)
            {
                    Continua = false;
                    vencedor = matriz[0, 1];
                }
                else if(matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2] && matriz[0, 2] != null)
            {
                    Continua = false;
                    vencedor = matriz[0, 2];
                }
                //Testa diagonais
                else if(matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2] && matriz[0, 0] != null)
            {
                    Continua = false;
                    vencedor = matriz[0, 0];
                }
                else if(matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0] && matriz[0, 2] != null)
            {
                    Continua = false;
                    vencedor = matriz[0, 2];
                }
                else if(acertos == 9)
            {
                    Continua = false;
                    vencedor = "não houve vencedor!";
                }
            } while (Continua);
            Console.WriteLine("O vencedor é: {0}", vencedor);
            Console.ReadKey();

        }
    }
}
