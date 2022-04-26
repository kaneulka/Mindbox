using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class SquareLiberary
    {
        //Площадь круга
        public static double Square(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //Площадь треугольника по 3 сторонам
        public static double? Square(double a, double b, double c)
        {
            if (!Examination.IsTriangleExist(a, b, c)) return null;
                double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //Новые фигуры можно добавлять делая перегрузку функции и выполняя проверку на существование объекта
    }
}
