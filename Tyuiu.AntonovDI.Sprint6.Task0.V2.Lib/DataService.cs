using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AntonovDI.Sprint6.Task0.V2.Lib
{
    public class DataService : ISprint6Task0V2
    {
        public double Calculate(int x)
        {
            double baseVal = Math.Pow(x, 2) - 2;
            if (baseVal <= 0)
                throw new ArgumentException("Подкоренное выражение должно быть больше нуля!");

            double num = 2 * Math.Pow(x, 2) - 1;
            double den = Math.Sqrt(baseVal);

            return Math.Round(num / den, 3);
        }
    }
}
