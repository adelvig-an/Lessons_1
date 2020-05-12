﻿using Lessons.Model;
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
                Width = TextWidth,
            };

            Rectangle = new Rectangle
            {
                Width = TextWidth,
                Height = TextHeight
            };
            TypeFigure = LocalStorage.ListFigure;
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

        private string isTypeFigure;
        public string IsTypeFigure
        {
            get => isTypeFigure;
            set
            {
                SetProperty(ref isTypeFigure, value);
                if (value == "Квадрат")
                {
                    new Square();
                }
                else if (value == "Прямоугольник")
                {
                    new Rectangle();
                }
                OnPropertyChanged(nameof(Rectangle));
            }
        }

    }
}
