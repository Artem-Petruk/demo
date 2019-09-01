using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.  
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
среднее арифметическое всех элементов, вывести все нечетные значения.
*/

    class ArrayTask
    {

        public void ShowArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine();
        }
        public int SumElements(int[] array)
        {
            int result = 0;
            foreach (int num in array)
            {
                result += num;
            }
            return result;
        }
        public int AverageElements(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }

        public List<int> OddNumbers(int[] array)
        {
            List<int> oddNumbers = new List<int>();
            foreach (int num in array)
            {
                if (num % 2 != 0 && num != 0)
                    oddNumbers.Add(num);
            }
            return oddNumbers;
        }
        public int MaxValue(int[] array)
        {
            int maxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
            }
            return maxValue;
        }
        public int MinValue(int[] array)
        {
            int minValue = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                    minValue = array[i];
            }
            return minValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 262, 48, 59, 20, 121 };

            ArrayTask arrTask = new ArrayTask();

            Console.Write("All numbers in array: ");
            arrTask.ShowArray(array);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("\n");

            Console.Write($"The maximum value of array is: {arrTask.MaxValue(array)}");
            Console.WriteLine("\n");

            Console.Write($"The minimum value of array is: {arrTask.MinValue(array)}");
            Console.WriteLine("\n");

            Console.Write($"The sum of elements in array: {arrTask.SumElements(array)}");
            Console.WriteLine("\n");

            Console.Write($"The average value of elements in array: {arrTask.AverageElements(array)}");
            Console.WriteLine("\n");

            Console.Write($"Odd numbers of elements in array: ");
            foreach (var item in arrTask.OddNumbers(array))
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
