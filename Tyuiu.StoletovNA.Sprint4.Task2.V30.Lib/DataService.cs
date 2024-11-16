using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StoletovNA.Sprint4.Task2.V30.Lib
{
    public class DataService : ISprint4Task2V30 {
        public int Calculate(int[] array)
        {
            int countMult = 1;
            foreach (int numb in array)
            {
                if (numb % 2 != 0)
                {
                    countMult *= numb;
                }
                
            }
            return countMult;
        }
    }
}
