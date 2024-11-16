using Tyuiu.StoletovNA.Sprint4.Task2.V30.Lib;
namespace Tyuiu.StoletovNA.Sprint4.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 7, 5, 8, 3, 4, 5, 2, 4, 7, 3, 8, 5 };
            int wait = 55125;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);

        }
    }
}