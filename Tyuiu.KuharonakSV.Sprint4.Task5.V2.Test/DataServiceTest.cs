using Tyuiu.KuharonakSV.Sprint4.Task5.V2.Lib;
namespace Tyuiu.KuharonakSV.Sprint4.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 0, -2, -4, 5, -4 },
                                            { 4, -4, 5, -6, 7 },
                                            { -7, -5, 6, 6, -6 },
                                            { -6, -7, 6, 6, -4 },
                                            { -5, -6, -6, -6, -5 } };

            int wait = 7;

            var rez = ds.Calculate(matrix);

            Assert.AreEqual(wait, rez);
        }
    }
}
