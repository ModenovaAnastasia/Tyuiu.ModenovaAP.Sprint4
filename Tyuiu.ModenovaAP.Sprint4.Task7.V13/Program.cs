using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ModenovaAP.Sprint4.Task7.V13.Lib;

namespace Tyuiu.ModenovaAP.Sprint4.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "159357246";
            Console.Title = "Спринт #4 | Выполнила: Моденова А. П. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнила: Моденова Анастасия Павловна | ИИПб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Преобразовать 159357246 в матрицу 3 на 3 и подсчитать количество        *");
            Console.WriteLine("* четных чисел.                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, value);

            Console.WriteLine("Сумма всех четных элементов массива равна: " + res);
            Console.ReadKey();
        }
    }
}
