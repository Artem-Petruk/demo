using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Задание 3 
    Используя Visual Studio, создайте проект по шаблону Console Application.  
    Требуется:  
    Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера 
    с возможностью изменения числа строк и столбцов.
    Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. 
    */

    class MyMatrix
    {
        public int[,] GetMatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(1, 999);
                }
            }
            return matrix;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("==> Enjoy with Matrix Program! <==\n");
            int count = 1;
            MyMatrix matrX = new MyMatrix();
            while (count < 4)
            {
                Console.Write("Please, enter the weight of Matrix: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("\nPlease, enter the height of Matrix: ");
                int m = int.Parse(Console.ReadLine());

                int[,] matrix = matrX.GetMatrix(n, m);
                Console.WriteLine("\nYour Matrix is:");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                count++;
            }
            Console.WriteLine("==> Matrix Program has done! <==");
            Console.ReadKey();
        }
    }
}
