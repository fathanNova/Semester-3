using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMachine;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.Write("Masukkan Nilai A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nHasil Penambahan: " + calc.Penambahan(a, b));

            Console.ReadKey();
        }
    }
}
