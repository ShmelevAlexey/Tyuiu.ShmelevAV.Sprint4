using Tyuiu.ShmelevAV.Sprint4.Task5.V23.Lib;

namespace Tyuiu.ShmelevAV.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -4, 7, 3, 5, 2 }, { -2, -1, -4, 6, 7 }, { 7, 5, 5, 8, -3 }, { 1, 8, 3, -3, 4 }, { 5, -3, 8, 2, 6 } };

            int[,] res = ds.Calculate(mas2);
            int[,] wait = { { 0, 7, 3, 5, 2 }, { 0, 0, 0, 6, 7 }, { 7, 5, 5, 8, 0 }, { 1, 8, 3, 0, 4 }, { 5, 0, 8, 2, 6 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}