using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DanilovAS.Sprint4.Task7.V14.Lib;

namespace Tyuiu.DanilovAS.Sprint4.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Данилов А. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"458712659137\". Преобразуйте ее в   *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows = 3;
            int columns = 4;
            int[,] array = new int[rows, columns];

            string str = "458712659137";          
            int index = 0;

            Console.WriteLine("\nМассив:");
            for(int i = 0; i<rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]}\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows,columns,str);
            Console.WriteLine("Количество нечётных элементов = " + res);
            Console.ReadLine();
        }
    }
}
