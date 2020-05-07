using System;

namespace LatihanPolymorphism
{
    public class PrinterWindows
    {

        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("display dimension");
        }
        public virtual void Print()
        {
            Console.WriteLine("printer printing...");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            PrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomer Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();

        }
    }

    public class Epson : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Epson printer....");
        }
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
    }
    public class Canon : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Cannon printer....");
        }
        public override void Show()
        {
            Console.WriteLine("Cannon display dimension : 9.5*12");
        }
    }
    public class LaserJet : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Laserjet printer....");
        }
        public override void Show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }
    }
}

