using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StoletovNA.Sprint4.Task1.V13.Lib
{
    public class DataService : ISprint4Task1V13 {
        public int Calculate(int[] array)
        {
            int countSum = 0;

            foreach (int numb in array)
            {
                if (numb % 2 == 0)
                {
                    countSum += numb;
                }
            }
            return countSum;
        }
    }
}
