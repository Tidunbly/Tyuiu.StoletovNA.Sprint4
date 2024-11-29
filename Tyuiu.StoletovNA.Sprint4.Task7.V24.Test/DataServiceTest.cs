using Tyuiu.StoletovNA.Sprint4.Task7.V24.Lib;
namespace Tyuiu.StoletovNA.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "651827384219648";
            int rows = 5;
            int cols = 3;
            
            var res = ds.Calculate(rows, cols, str);
            var wait = 1179648;
              


            Assert.AreEqual(wait, res);
        }
    }
}