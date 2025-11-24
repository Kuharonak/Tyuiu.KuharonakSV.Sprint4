using Tyuiu.KuharonakSV.Sprint4.Task2.V27.Lib;
namespace Tyuiu.KuharonakSV.Sprint4.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] Array = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };
            int wait = 20, res = ds.Calculate(Array);
            Assert.AreEqual(wait, res);
        }
    }
}
