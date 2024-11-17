using Tyuiu.StoletovNA.Sprint4.Task3.V9.Lib;
namespace Tyuiu.StoletovNA.Sprint4.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { 9, 6, 4, 5, 3 }, 
                             { 7, 4, 7, 5, 3 }, 
                             { 8, 5, 9, 9, 3 }, 
                             { 7, 8, 7, 9, 3 }, 
                             { 3, 7, 3, 7, 7 } };
            int wait = 30;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);

        }
    }
}