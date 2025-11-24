using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KuharonakSV.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int minValue = array[0, 3]; // Инициализируем минимальное значение элементом из 4-го столбца первой строки

            for (int i = 1; i < array.GetLength(0); i++) // Проходим по всем строкам для 4-го столбца
            {
                if (array[i, 3] < minValue)
                {
                    minValue = array[i, 3]; // Обновляем минимальное значение, если найден меньший элемент
                }
            }

            return minValue;
        }
    }
}
