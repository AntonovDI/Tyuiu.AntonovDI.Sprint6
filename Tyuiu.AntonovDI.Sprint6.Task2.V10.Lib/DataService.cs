
using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AntonovDI.Sprint6.Task2.V10.Lib
{
    public class DataService : ISprint6Task2V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
                double d = Math.Sin(x) + 1;

                if (Math.Abs(d) < 0.000001)
                    arr[i] = 0;
                else
                {
                    double f = (2 * x - 1) / d;
                    double result = 2 * x - 4 + f;
                    arr[i] = Math.Round(result, 2);
                }
            }
            return arr;
        }
    }
}
