using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KuharonakSV.Sprint4.Task5.V2.Lib
{
    public class DataService : ISprint4Task5V2
    {
        public int Calculate(int[,] matrix)
        {
            int cnt = 0;

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                        cnt++;
                }
            }
            return cnt;
        }
    }
}
