using Tyuiu.SozonovaVA.Sprint3.Task0.V6.Lib;
namespace Tyuiu.SozonovaVA.Sprint3.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 9.103;
            Assert.AreEqual(wait, res);
        }
    }
}
