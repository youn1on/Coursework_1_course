using System;

namespace Labyrinths.View
{
    public class OutputOperations
    {
        public static void PrintLabyrinth(char[][] labyrinth)
        {
            for (int i = 0; i < labyrinth.Length; i++)
            {
                for (int j = 0; j < labyrinth[0].Length; j++)
                {
                    Console.Write(" "+labyrinth[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}