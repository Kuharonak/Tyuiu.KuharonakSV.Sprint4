using Tyuiu.KuharonakSV.Sprint4.Task7.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                                  *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
        Console.WriteLine("* Задание #7                                                                                                 *");
        Console.WriteLine("* Вариант #14                                                                                                *");
        Console.WriteLine("**************************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
        Console.WriteLine("* Дана строка из одноразрядных цифр 458712659137. Преобразуйте ее в матрицу 3 на 4                           *");
        Console.WriteLine("* и подсчитайте сумму нечетных чисел.                                                                        *");
        Console.WriteLine("*                                                                                                            *");
        Console.WriteLine("**************************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
        Console.WriteLine("**************************************************************************************************************");

        int rows = 3;
        int columns = 4;
        int index = 0;
        string str = "458712659137";
        int[,] array = new int[rows, columns];
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("**************************************************************************************************************");
        Console.WriteLine("* Результат:                                                                                                 *");
        Console.WriteLine("**************************************************************************************************************");
        Console.WriteLine("Сумма нечетных элементов массива: ");
        int res = ds.Calculate(rows, columns, str);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}