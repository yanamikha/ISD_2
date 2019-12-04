using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("white");

            NewColor newColor = new NewColor();

            newColor.Print("blue");

            Printer p = newColor;
            p.Print("blue");

        }
    }
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
        }
    }
    class NewColor : Printer
    {
        public override void Print(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(str);
        }
    }
}

