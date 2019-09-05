using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    class Program
    {
        static int SIZE = 3;

        static void PrintGame(char[,] game)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write(game[i,j]);
                }
                Console.WriteLine();
            }
        }

        static bool CheckEnd(char[,] game)
        {

        }

        static bool CheckWin(char[,] game, char player)
        {

        }

        static bool CheckStep(char[,] game, int x, int y)
        {

        }

        static void Main(string[] args)
        {
            char[,] game = new char[SIZE, SIZE];
            char player = 'X';

            do
            {
                Console.WriteLine($"Ходит {player}");

                //запрашиваем ход

                //переписать через тернарный оператор
                if (player == 'X')
                    player = 'O';
                else
                    player = 'X';
            }
            while (true);
        }
    }
}
