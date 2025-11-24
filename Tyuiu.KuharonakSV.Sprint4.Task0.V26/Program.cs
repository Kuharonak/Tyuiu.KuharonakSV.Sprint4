using Tyuiu.KuharonakSV.Sprint4.Task0.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
        Console.WriteLine("* элементов                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] x = new int[10] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
        Console.WriteLine("{9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int res = ds.GetSumOddArrEl(x);
        Console.WriteLine("Сумма нечетных элементов массива = " + res);
        Console.ReadKey();
    }
}