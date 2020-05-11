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
        public Figures Figures { get; }
        public IEnumerable<string> ListFigure { get; }

        public FirstPageVM()
        {
            Figures = new Figures
            {
                Width = 0,
                Height = 0,
                SideA = 0,
                SideB = 0,
                SideC = 0,
                Area = 0
            };
            
            ListFigure = LocalStorage.ListFigure;
            Result = new RelayCommand(_ => ResultAction());
        }

        public ICommand Result { get; }
        public void ResultAction()
        {
            Figures.Area = Figures.Width * Figures.Height;
        }

    }
}
