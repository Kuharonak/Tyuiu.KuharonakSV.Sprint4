using Tyuiu.KuharonakSV.Sprint4.Task2.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая подсчитывает произведение четных элементов  *");
        Console.WriteLine("* в массиве из случайных чисел                                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Random rnd = new Random();
        DataService ds = new DataService();

        int len = 13;

        int[] Array = new int[len];

        for (int i = 0; i < len - 1; i++)
        {
            Array[i] = rnd.Next(2, 7);
        }
        Console.WriteLine("Массив:");

        for (int i = 0; i < len - 1; i++)
        {
            Console.Write(Array[i] + "\t");
        }

        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма чётных элементов массива = " + ds.Calculate(Array));
        Console.ReadKey();
    
}
}