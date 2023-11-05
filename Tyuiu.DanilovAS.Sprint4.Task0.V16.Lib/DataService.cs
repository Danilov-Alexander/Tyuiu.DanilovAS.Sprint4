using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DanilovAS.Sprint4.Task0.V16.Lib
{
    public class DataService : ISprint4Task0V16
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int count = 1;

            for(int i = 0; i < array.Length; i++)
            {
                if(i % 2 == 0)
                {
                    count *= array[i];
                }

            }
            return count;
        }
    }
}
