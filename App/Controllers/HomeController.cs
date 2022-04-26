using Microsoft.AspNetCore.Mvc;
using Functions;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public double CircleSquare(double radius)
        {
            return SquareLiberary.Square(radius);
        }
        public double? TriangleSquare(double a, double b, double c)
        {
            return SquareLiberary.Square(a,b,c);
        }
        public bool IsRightTriangle(double a, double b, double c)
        {
            return Examination.IsRightTriangle(a,b,c);
        }
    }
}
