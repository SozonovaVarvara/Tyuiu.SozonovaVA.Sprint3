using Tyuiu.SozonovaVA.Sprint3.Task2.V29.Lib;
namespace Tyuiu.SozonovaVA.Sprint3.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1, stopValue = 18;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(-0.186, res);
        }
    }
}
