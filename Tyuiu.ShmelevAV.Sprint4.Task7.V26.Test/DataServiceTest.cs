using Tyuiu.ShmelevAV.Sprint4.Task7.V26.Lib;

namespace Tyuiu.ShmelevAV.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "351268459614723";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 18432;
            Assert.AreEqual(wait, res);
        }
    }
}