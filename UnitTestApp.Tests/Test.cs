using App.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestApp.Tests
{
    public class Test
    {
        //Проверка на нахождение площади круга
        [Fact]
        public void CircleSquareTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.CircleSquare(11.5);

            // Assert
            Assert.IsType<double>(result);
        }

        //Проверка на нахождение площади треугольника
        [Fact]
        public void TriangleSquareTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            double? result = controller.TriangleSquare(4, 5, 7.8);

            // Assert
            Assert.NotNull(result);
        }

        //Проверка на несуществующий треугольник
        [Fact]
        public void TriangleSquareNotExistTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            double? result = controller.TriangleSquare(100, 2, 3);

            // Assert
            Assert.Null(result);
        }

        //Проверка на прямоугольный треугольник
        [Fact]
        public void TriangleSquareRightTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            bool result = controller.IsRightTriangle(3,4,5);

            // Assert
            Assert.True(result);
        }

        //Проверка на не прямоугольный треугольник
        [Fact]
        public void TriangleSquareNotRightTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            bool result = controller.IsRightTriangle(5, 5, 5);

            // Assert
            Assert.False(result);
        }
    }
}
