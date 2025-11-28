using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KuharonakSV.Sprint4.Task6.V5.Lib
{
    public class DataService : ISprint4Task6V5
    {
        public int Calculate(string[] array)
        {
            string[] filtered = Array.FindAll(array, s => s.Length == 5);
            return filtered.Length;
        }
    }
}
