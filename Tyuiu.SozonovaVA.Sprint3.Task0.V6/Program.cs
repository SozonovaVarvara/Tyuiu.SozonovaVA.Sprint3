using Tyuiu.SozonovaVA.Sprint3.Task0.V6.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("*************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                     *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры C#                                                      *");
        Console.WriteLine("* Задание #0                                                                                    *");
        Console.WriteLine("* Вариант #6                                                                                    *");
        Console.WriteLine("* Выполнилa: Созонова Варвара Андреевна | АСОиУб-25-1                                           *");
        Console.WriteLine("*************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение ряда по формуле         *");
        Console.WriteLine("*                                                                                               *");
        Console.WriteLine("*************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
        Console.WriteLine("*************************************************************************************************");

        double value = 5;
        int startValue = 1;
        int stopValue = 15;

        Console.WriteLine("Переменная X = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("*************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
        Console.WriteLine("*************************************************************************************************");
        Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(startValue, stopValue));
        Console.ReadKey();
    }
}