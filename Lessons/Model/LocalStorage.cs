using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Model
{
    public static class LocalStorage
    {
        public static IEnumerable<string> ListFigure =>
            new string[]
            {
                "Квадрат",
                "Прямоугольник",
                "Треугольник"
            };
    }
}
