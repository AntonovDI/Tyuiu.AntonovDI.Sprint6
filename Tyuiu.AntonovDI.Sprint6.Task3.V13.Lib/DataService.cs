using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AntonovDI.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int[,] result = (int[,])matrix.Clone();

            int[] col2 = new int[rows];
            for (int i = 0; i < rows; i++)
                col2[i] = result[i, 1];

            Array.Sort(col2);

            for (int i = 0; i < rows; i++)
                result[i, 1] = col2[i];

            return result;
        }
    }
}
