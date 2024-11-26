﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StoletovNA.Sprint4.Task5.V26.Lib
{
    public class DataService : ISprint4Task5V26 {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }
    }
}
