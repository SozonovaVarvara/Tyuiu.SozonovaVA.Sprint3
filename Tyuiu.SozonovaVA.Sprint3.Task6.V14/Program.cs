using Tyuiu.SozonovaVA.Sprint3.Task6.V14.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт  #3                                                               *");
        Console.WriteLine("* Задание #6                                                            *");
        Console.WriteLine("* Вариант #14                                                          *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                   *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [7, 16] количество всех делителей больше 5");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
        Console.WriteLine();

        DataService ds = new DataService();


        int startValue = 7;
        int stopValue = 16;



        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
    }
}