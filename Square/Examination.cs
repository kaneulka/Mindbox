using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class Examination
    {
        //Проверка на существование треугольника
        public static bool IsTriangleExist(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
                return true;
            else
                return false;
        }

        //Является ли треугольник прямоугольный
        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) return true;
            if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)) return true;
            if (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2)) return true;
            return false;
        }
    }
}
