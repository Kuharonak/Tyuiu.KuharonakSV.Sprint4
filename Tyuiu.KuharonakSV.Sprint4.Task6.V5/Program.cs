using Tyuiu.KuharonakSV.Sprint4.Task6.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

       
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
        Console.WriteLine("* заполненный случайными значениями в диапазоне от -4 до 3.               *");
        Console.WriteLine("* Найти сумму положительных элементов.                                    *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Random rand = new Random();
        int[,] array = new int[5, 5];

        Console.WriteLine("Массив 5x5 (случайные числа от -4 до 3):");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = rand.Next(-4, 4); // от -4 до 3 
                Console.Write(array[i, j]);
                if (j < 4) Console.Write(", ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int sumPositive = ds.Calculate(array);

        Console.WriteLine("Сумма положительных элементов = " + sumPositive);

        Console.ReadKey();
    }
}