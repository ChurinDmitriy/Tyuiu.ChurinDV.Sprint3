using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChurinDV.Sprint3.TaskReview.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;
            int len = (stopValue - startValue) + 1;
            array = new double[len];
            int count = 0;
            double y = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 == 0)
                {
                    array[count] = 0;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) / (x + 1.2)) - Math.Sin(x) * 2 - 2 * x, 2);
                    array[count] = y;
                    count++;
                }
            }
            return array;
        }
    }
}
