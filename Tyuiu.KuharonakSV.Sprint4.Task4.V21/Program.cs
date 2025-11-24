using Tyuiu.KuharonakSV.Sprint4.Task4.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8. Найдите сумму            *");
        Console.WriteLine("* четных элементов массива.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите количество строк в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов в массиве: ");
        int colums = Convert.ToInt32(Console.ReadLine());

        int[,] mtrx = new int[rows, colums];

        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"Введите {i}, {j} элемент массива: ");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(mtrx);

        Console.WriteLine("Сумма четных элементов массива = " + res);
        Console.ReadKey();
    }
}