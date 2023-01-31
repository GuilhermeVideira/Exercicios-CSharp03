using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int nl = 3, nc = 10;
            float[,] nota = new float[nl, nc];
            string[] nome = new string[10];
            float[] media = new float[10];
            float soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nome do {0}º aluno: ", i + 1);
                nome[i] = Console.ReadLine();
                for (int l = 0; l < nl; l++)
                {
                    Console.Write("{0}ª nota desse aluno: ", l + 1);
                    nota[l, i] = float.Parse(Console.ReadLine());
                    soma = soma + nota[l, i];
                }
                media[i] = soma / 3;
                soma = 0;
                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine("Aluno Notas Média");
            for (int i = 0; i < 10; i++)
            {
                if(media[i] >= 7){
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(nome[i] + " - ");
                for (int l = 0; l < nl; l++)
                {
                    Console.Write(nota[l, i] + " ");
                }
                Console.WriteLine(" - " + media[i]);
                Console.WriteLine("---------------------------------");
            }
            Console.ReadKey();

        }
    }
}
