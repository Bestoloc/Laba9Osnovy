using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9Osnovy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод матрицы
            int[,] F = new int[5, 8];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    F[i,j] = rnd.Next(-20, 15);


            // Вывод матрицы
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write($"{F[i,j]} \t ");
                Console.WriteLine();

            }
            Console.WriteLine();



            // Поиск максимального элемента
            int Max = F[0, 0];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    if (F[i, j] > Max)
                    {
                        Max = F[i, j];
                    }
            Console.WriteLine($"Максимальный элемент матрицы {Max} \n");


            // Сумма элементов больших 7, в первом столбце матрицы
            double Summa = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 1; j++)
                    if (F[i,j] > 7)
                    {
                        Summa += F[i, j];
                    }
            Console.WriteLine($"Сумма элементов больших 7, в первом столбце матрицы {Summa} \n");


            // Одномерный массив G из количеств нулевых элементов каждой строки матрицы
            int[] G = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int NullElement = 0;
                for (int j = 0; j < 8; j++)
                    if (F[i, j] == 0)
                    {
                        NullElement++;
                    }
                G[i] = NullElement;
            }
            Console.Write("G = { "); Console.Write(String.Join(", ", G)); Console.WriteLine(" } \n");

            // Одномерный массив R из положительных элементов матрицы 

            // Поиск положительных элементов
            int C = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    if (F[i, j] > 0)
                        C++;

            // Формирование массива
            int[] R = new int[C];
            int Result = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (F[i, j] > 0)
                    {
                        R[Result] = F[i, j];
                        Result++;
                    }
                }
            Console.Write("R = { "); Console.Write(String.Join(", ", R)); Console.WriteLine(" }");






        }
    }
}
