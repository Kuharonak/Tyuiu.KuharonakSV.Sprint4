using Tyuiu.KuharonakSV.Sprint4.Task3.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mtrx = new int[5, 5] { { 5, 4, 9, 8, 5 },
                                          { 4, 6, 6, 9, 9 },
                                          { 9, 8, 4, 8, 8 },
                                          { 6, 8, 6, 8, 9 },
                                          { 9, 4, 6, 6, 7 } };

        int rows = mtrx.GetUpperBound(0) + 1;
        int colums = mtrx.Length / rows;




        DataService ds = new DataService();

       
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Найдите минимальный      *");
        Console.WriteLine("* элемент в четвертом столбце массива.                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = {
    {5, 4, 9, 8, 5},
    {4, 6, 6, 9, 9},
    {9, 8, 4, 8, 8},
    {6, 8, 6, 8, 9},
    {9, 4, 6, 6, 7}
};

        int minInFourthColumn = ds.Calculate(array);

        Console.WriteLine($"Минимальный элемент в четвертом столбце: {minInFourthColumn}");
        Console.WriteLine("************************************************************************");
        Console.ReadLine();
    }
}