using Lessons.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lessons.VM
{
    public class FirstPageVM : PageVM
    {
        public Square Square { get; }
        public Rectangle Rectangle { get; }
        public IEnumerable<string> TypeFigure { get; }
        public FirstPageVM()
        {
            Square = new Square
            {
                Width = 5,
            };

            Rectangle = new Rectangle
            {
                Width = 7,
                Height= 4
            };
            TypeFigure = LocalStorage.ListFigure;
        }
    }
}
