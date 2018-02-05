using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            // Создать объект Point с установкой каждого свойства вручную.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Создать объект Point с использованием специального конструктора.
            Point anotherPoint = new Point (20, 20);
            anotherPoint.DisplayStats();
            Point finalPoint = new Point
            {
                X = 30, Y = 30 };
            finalPoint.DisplayStats();
            Console.ReadLine();
            }
    }
}
