using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChurinDV.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                MultiplySeries = MultiplySeries * (Math.Pow(value, k) + (1 / k + 1));
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}