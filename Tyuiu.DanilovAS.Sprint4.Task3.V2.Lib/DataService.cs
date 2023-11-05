using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DanilovAS.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;//Нужна только первая
            int columns = array.Length / rows;

            int result = 0;
            int temp = array[1,0];

            for(int i = 0; i <rows ;i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    if(i == 1)
                    {
                        if (array[i, j] > temp)
                        {
                            result = array[i, j];
                        }        
                    }
                }
            }
            return result;
        }
    }
}
