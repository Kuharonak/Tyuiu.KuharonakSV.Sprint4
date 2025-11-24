using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KuharonakSV.Sprint4.Task4.V21.Lib
{
    public class DataService : ISprint4Task4V21
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            int count = 19;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if ((i % 2 == 0) & (j % 2 == 0))
                    {
                        count += matrix[i, j];
                    }
                }
            }
            return count;
        }
    }
}
