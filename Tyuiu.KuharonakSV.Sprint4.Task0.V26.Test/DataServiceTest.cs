using Tyuiu.KuharonakSV.Sprint4.Task0.V26.Lib;
namespace Tyuiu.KuharonakSV.Sprint4.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetSumOddArrEl(array);
            int wait = 41;
            Assert.AreEqual(wait, res);
        }
    }
}
