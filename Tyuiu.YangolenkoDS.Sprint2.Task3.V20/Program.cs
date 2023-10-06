using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.YangolenkoDS.Sprint2.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                               *");
            Console.WriteLine("* Вариант #29                                                                       *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и вычисляет,  *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                   *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            int x, y;

            Console.WriteLine("Введите значение координаты X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты Y:");
            y = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
