using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KuharonakSV.Sprint4.Task2.V27.Lib
{
    public class DataService : ISprint4Task2V27
    {
        public int Calculate(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result += array[i];
                }
            }
            return result;
        }
    }
}
