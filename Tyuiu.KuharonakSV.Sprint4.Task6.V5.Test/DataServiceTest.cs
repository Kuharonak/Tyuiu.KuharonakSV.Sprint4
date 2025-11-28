using Tyuiu.KuharonakSV.Sprint4.Task6.V5.Lib;
namespace Tyuiu.KuharonakSV.Sprint4.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] array = { "Меркурий", "Венера", "Gachi", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };

            int result = ds.Calculate(array);
            int expected = 1;

            Assert.AreEqual(expected, result);
        }
    }
}
