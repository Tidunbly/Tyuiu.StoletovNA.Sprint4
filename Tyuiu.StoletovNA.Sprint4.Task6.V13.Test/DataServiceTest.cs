using Tyuiu.StoletovNA.Sprint4.Task6.V13.Lib;
namespace Tyuiu.StoletovNA.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var cars = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int wait = 4;
            int res = ds.Calculate(cars);

            Assert.AreEqual(wait, res);

        }
    }
}