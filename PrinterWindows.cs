using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismInterface
{
    class PrinterWindows : IPrinterWindows 
    {
        public void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }

        public void Print()
        {
            Console.WriteLine("Printer Windows printing... ");
        }
    }
}
