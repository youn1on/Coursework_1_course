﻿using System;
using System.Collections.Generic;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public class LabyrinthGenerator
    {
        public static int[][] GetEmptyLabyrinth(int sizeX, int sizeY)
        {
            int[][] labyrinth = new int[sizeX][];
            for (int ctr = 0; ctr < labyrinth.Length; ctr++)
            {
                labyrinth[ctr] = new int[sizeY];
                for (int ctr2 = 0; ctr2 < sizeY; ctr2++)
                {
                    labyrinth[ctr][ctr2] = 1;
                }
            }

            return labyrinth;
        }

        public static int[][] GenerateLabyrinth(int sizeX, int sizeY)
        {
            int[][] labyrinth = GetEmptyLabyrinth(sizeX, sizeY);
            Random rand = new Random();
            Structures.Stack<System.Collections.Generic.KeyValuePair<int, int>> stack =
                new Structures.Stack<System.Collections.Generic.KeyValuePair<int, int>>();
            int i = rand.Next((labyrinth.Length - 1) / 2) * 2 + 1;
            int j = rand.Next((labyrinth[0].Length - 1) / 2) * 2 + 1;
            labyrinth[i][j] = 0;
            stack.Push(new(i, j));
            while (stack.Count > 0)
            {
                (i, j) = stack.Pop();
                KeyValuePair<int, int> newPoint = FindNeighbour(labyrinth, i, j);
                if (newPoint.Key != -1)
                {
                    stack.Push(new(i, j));
                    labyrinth[newPoint.Key][newPoint.Value] = 0;
                    labyrinth[(newPoint.Key + i) / 2][(newPoint.Value + j) / 2] = 0;
                    stack.Push(newPoint);
                }
            }
            return labyrinth;
        }

        public static int[][] GenerateDeadEndLabyrinth(int sizeX, int sizeY)
        {
            Random rand = new Random();
            int[][] labyrinth = GenerateLabyrinth(sizeX, sizeY);
            int deadEndCount = rand.Next(1, (labyrinth.Length + labyrinth[0].Length) / 2);
            int x, y;
            for (int i = 0; i < deadEndCount; i++)
            {
                (x, y) = GetRandomTunnel(labyrinth);
                labyrinth[x][y] = 1;
            }

            return labyrinth;
        }

        private static (int, int) GetRandomTunnel(int[][] labyrinth)
        {
            Random rand = new();
            int[] coordinates = new int[2];
            while (true)
            {
                coordinates[0] = rand.Next(1, (labyrinth.Length - 1) / 2) * 2;
                coordinates[1] = rand.Next(1, (labyrinth[0].Length - 1) / 2) * 2;
                coordinates[rand.Next(2)] += 1;
                if (labyrinth[coordinates[0]][coordinates[1]] == 0) return (coordinates[0], coordinates[1]);
            }
        }

        private static KeyValuePair<int, int> FindNeighbour(int[][] labyrinth, int i, int j)
        {
            List<KeyValuePair<int, int>> neighbours = new List<KeyValuePair<int, int>>();
            if (i - 2 > 0 && labyrinth[i - 2][j] == 1) neighbours.Add(new(i - 2, j));
            if (i + 2 < labyrinth.Length - 1 && labyrinth[i + 2][j] == 1) neighbours.Add(new(i + 2, j));
            if (j - 2 > 0 && labyrinth[i][j - 2] == 1) neighbours.Add(new(i, j - 2));
            if (j + 2 < labyrinth[0].Length - 1 && labyrinth[i][j + 2] == 1) neighbours.Add(new(i, j + 2));
            if (neighbours.Count == 0) return new(-1, -1);
            Random rand = new Random();
            return neighbours[rand.Next(neighbours.Count)];
        }


        public static string[] ToStringArray(int[][] labyrinth)
        {
            string[] stringLabyrinth = new string[labyrinth.Length];
            for (int i = 0; i < labyrinth.Length; i++)
            {
                stringLabyrinth[i] = "";
                for (int j = 0; j < labyrinth[0].Length; j++)
                {
                    stringLabyrinth[i] += labyrinth[i][j] == 1 ? "X " : "  ";
                }
            }

            return stringLabyrinth;
        }
    }
}