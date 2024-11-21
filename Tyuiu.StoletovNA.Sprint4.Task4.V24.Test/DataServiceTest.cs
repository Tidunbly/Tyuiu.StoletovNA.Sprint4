using Tyuiu.StoletovNA.Sprint4.Task4.V24.Lib;
namespace Tyuiu.StoletovNA.Sprint4.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { { 7, 9, 7, 6, 7 }, { 9, 9, 8, 6, 7 }, { 8, 6, 5, 6, 7 }, { 9, 9, 7, 8, 7 }, { 5, 9, 9, 8, 9 } };
            int[,] waitMatrix = { { 7, 9, 7, 1, 7 }, { 9, 9, 1, 1, 7 }, { 1, 1, 5, 1, 7 }, { 9, 9, 7, 1, 7 }, { 5, 9, 9, 1, 9 } };
            int[,] resMatrix = ds.Calculate(matrix);
            CollectionAssert.AreEqual(resMatrix, waitMatrix);
            

        }   
    }
}