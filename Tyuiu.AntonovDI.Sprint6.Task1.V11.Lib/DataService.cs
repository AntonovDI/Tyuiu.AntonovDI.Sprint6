using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AntonovDI.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
        public double[] GetMassFunction(int start, int stop)
        {
            int len = stop - start + 1;
            var arr = new double[len];

            for (int i = 0; i < len; i++)
            {
                double x = start + i;
                double d = Math.Sin(x) + 3;

                if (Math.Abs(d) < 0.000001)
                    arr[i] = 0;
                else
                    arr[i] = Math.Round((5 * x + 2.5) / d + 2 * x + Math.Cos(x), 2);
            }

            return arr;
        }
    }
}
