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
        public IEnumerable<string> TypeFigure { get; }
        public FirstPageVM()
        {
            if (IsTypeFigure == "Квадрат")
            {
                new Square();
            }
            else if (IsTypeFigure == "Прямоугольник")
            {
                new Rectangle();
            }
            OnPropertyChanged(nameof(FirstPageVM));
            TypeFigure = LocalStorage.ListFigure;

        }
        private string isTypeFigure;
        public string IsTypeFigure
        {
            get => isTypeFigure;
            set
            {
                SetProperty(ref isTypeFigure, value);
            }
        }

    }
}
