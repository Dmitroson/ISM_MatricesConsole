using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] FirstMatrix = new int[5, 4]
            {
                { 1, 6, 3, -12 },
                { 1, 10, -2, 1 },
                { 3, 8, 4, 5 },
                { 4, -11, 1, 4 },
                {5, 9, 11, 1 }
            };

            int[,] SecondMatrix = new int[5, 4]
            {
                { 6, 6, 1, 9 },
                { -7, 3, -2, 1 },
                { 3, -6, 1, 5 },
                { 33, 21, 3, 9 },
                { 5, 11, 6, 1 }
            };

            Maximal(FirstMatrix);
            Console.WriteLine("....................");
            Minimal(FirstMatrix);
            Console.WriteLine("....................");
            Multiplication(FirstMatrix, SecondMatrix);
            Console.ReadKey();
        }
        static void Maximal(int[,] Matrix)
        {
            int max = -1000000;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (Matrix[i, j] > max)
                    {
                        max = Matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Maximal value of First Matrix is {max}");
        }
        static void Minimal(int [,] Matrix)
        {
            for (int i = 0; i < 5; i++)
            {
                int min = 1000000;
                for (int j = 0; j < 4; j++)
                {
                    if (Matrix[i, j] < min)
                    {
                        min = Matrix[i, j];
                    }
                }
                Console.WriteLine($"Maximal value of {i+1} line is {min}");
            }
        }
        static void Multiplication(int[,] Matrix_1, int[,] Matrix_2)
        {
            int[,] MultiplicationMatrix = new int[5, 4];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    MultiplicationMatrix[i, j] = Matrix_1[i, j] * Matrix_2[i, j];
                    Console.Write($"{MultiplicationMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
