using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AntonovDI.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startX, int endX)
        {
            int length = endX - startX + 1;
            double[] values = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startX + i;
                double denominator = Math.Cos(x) + 1;

                if (Math.Abs(denominator) < 0.000001)
                    values[i] = 0;
                else
                    values[i] = Math.Round(3 * x + 2 - x / denominator, 2, MidpointRounding.AwayFromZero);
            }

            return values;
        }
    }
}
