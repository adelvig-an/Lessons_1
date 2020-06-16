using Lessons.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lessons.VM
{
    class SquareVM : PageVM
    {
        public Square Square { get; }

        public SquareVM()
        {
            Square = new Square
            {
                Width = TextWidth,
            };
            Result = new RelayCommand(_ => ResultAction(Square));
        }

        private double text;
        public double TextWidth
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        public ICommand Result { get; }
        public void ResultAction(Square square)
        {
            square.Width = TextWidth;
            OnPropertyChanged(nameof(Square));
        }
    }
}
