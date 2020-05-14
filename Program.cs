using System;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama\t: Ivan Nur Ilham Syah");
            Console.WriteLine("NIM\t: 19.11.2742");
            Console.WriteLine("Kelas\t: 19 IF 03");

            Console.WriteLine();

            Console.WriteLine("Pilih Printer: \n1. Epson\n2. Canon\n3. LaserJet");

            Console.Write("\nNomor Printer [1 ... 3] : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            IPrinterWindows printer = new PrinterWindows();

            if (pilihPrinter > 0 && pilihPrinter < 4)
            {
                if (pilihPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (pilihPrinter == 2)
                {
                    printer = new Canon();
                }
                else
                {
                    printer = new LaserJet();
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid \n");
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
