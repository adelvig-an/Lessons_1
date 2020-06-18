using Lessons.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace Lessons.VM
{
    public class FirstPageVM : PageVM
    {
        public IEnumerable<string> TypeFigure { get; }
        public FirstPageVM()
        {
            TypeFigure = LocalStorage.ListFigure;
        }

        private PageVM figure;
        public PageVM Figure
        {
            get => figure;
            set => SetProperty(ref figure, value);
        }

        private string isTypeFigure;
        public string IsTypeFigure
        {
            get => isTypeFigure;
            set
            {
                SetProperty(ref isTypeFigure, value);
                if (value == "Квадрат")
                {
                    Figure = new SquareVM();
                }
                else if (value == "Прямоугольник")
                {
                    Figure = new RectangleVM();
                }
            }
        }

    }
}
