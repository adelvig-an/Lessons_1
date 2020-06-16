using Lessons.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lessons.VM
{
    class RectangleVM : PageVM
    {
        public Rectangle Rectangle { get; }

        public RectangleVM()
        {
            Rectangle = new Rectangle
            {
                Width = TextWidth,
                Height = TextHeight
            };
            Result = new RelayCommand(_ => ResultAction(Rectangle));
        }

        private double text;
        public double TextWidth
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        public double TextHeight
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        public ICommand Result { get; }
        public void ResultAction(Rectangle rectangle)
        {
            rectangle.Width = TextWidth;
            rectangle.Height = TextHeight;
            OnPropertyChanged(nameof(Rectangle));
        }
    }
}
