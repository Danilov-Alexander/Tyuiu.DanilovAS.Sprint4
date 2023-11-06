using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DanilovAS.Sprint4.Task4.V16.Lib
{
    public class DataService : ISprint4Task4V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;// Кол-во строк
            int columns = matrix.Length / rows; //Кол-во столбцов

            for(int i =0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(matrix[i,j]%2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

           return matrix;
        }
    }
}
