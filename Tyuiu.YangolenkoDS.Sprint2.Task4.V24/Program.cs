using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint2.Task4.V24.Lib;

namespace Tyuiu.YangolenkoDS.Sprint2.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Тернарный оператор                                                          *");
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #24                                                                       *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("*                                          x        2         2                     *");
            Console.WriteLine("*                                 ( y + 1 )        y  + cos(x)  + 9                 *");
            Console.WriteLine("* Если x + 2 > y + 24, то z = x * ( ----- ), иначе -----------------                *");
            Console.WriteLine("*                                 ( x + 2 )         2        2                      *");
            Console.WriteLine("*                                                  x  - sin(y)  + 12                *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            double x, y;

            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            double z = Math.Round(ds.Calculate(x, y), 3);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
