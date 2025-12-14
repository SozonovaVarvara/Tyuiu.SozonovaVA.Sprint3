using Tyuiu.SozonovaVA.Sprint3.Task2.V29.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
        Console.WriteLine("* Задание: 2                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
        Console.WriteLine("* сумму ряда по формуле.                                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double Value = 0.5;
        int startValue = 1, stopValue = 18;
        Console.WriteLine($"Переменная X = {Value}");
        Console.WriteLine($"Старт шага = {startValue}");
        Console.WriteLine($"Конец шага = {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Сумма ряда = {ds.GetSumSeries(Value, startValue, stopValue)}");
        Console.ReadKey();
    }
}