using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint4.Task4.V16.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task4.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            //Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры в диапазоне от 3 до 7. Заменить четные элементы массива на 1.
            Console.Title = "Спринт #4 | Выполнил: Данилов А. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7.                          *");
            Console.WriteLine("* Заменить четные элементы массива на 1.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество строк = ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов = ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, columns];

            for (int i = 0; i<rows; i++)
            {
                for(int j=0; j < columns; j++)
                {
                    Console.Write("Введите элемент[{0},{1}] => ", i+1, j+1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Массив:");

            for(int i = 0; i < rows; i++)
            {
                for(int j =0; j <columns; j++)
                {
                    Console.Write("|  " + array[i, j] + "  |  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] resArray = ds.Calculate(array);

            Console.WriteLine("Ответ:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("|  " + resArray[i, j] + "  |  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
