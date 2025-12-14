using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SozonovaVA.Sprint3.Task5.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries += Math.Cos(k) + x * x;
                }
            }
            return Math.Round(sumSeries, 3);
        }

        public double GetSumSumSeries(int v1, int v2, int v3, int v4, int v5)
        {
            throw new NotImplementedException();
        }
    }
}
