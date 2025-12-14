using Tyuiu.SozonovaVA.Sprint3.Task4.V23.Lib;
class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = -5, stopValue = 5;

        Console.Title = "Спринт #3 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
        Console.WriteLine("* функции y=(cos(x)/x)+3                                                  *");
        Console.WriteLine("* При х = 0 прервать цикл. Полученные значения перемножать.               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Изначальное значение X: " + startValue);
        Console.WriteLine("Крайнее значение X: " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(startValue, stopValue));

    }
}