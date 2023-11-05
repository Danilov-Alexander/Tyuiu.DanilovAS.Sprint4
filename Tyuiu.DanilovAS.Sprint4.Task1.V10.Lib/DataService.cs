using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DanilovAS.Sprint4.Task1.V10.Lib
{
    public class DataService : ISprint4Task1V10
    {
        public int Calculate(int[] array)
        {
            int count = 1;

            for(int i = 1; i <=8; i++)
            {
                if(array[i]%2 != 0)
                {
                    count *= array[i];
                }

            }
            return count;
        }
    }
}
