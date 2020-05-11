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
        Figures square = new Square(5);

        Figures rectangle = new Rectangle(7, 4);

        Figures triangle = new Triangle(4, 4, 5);
        
    }
}
