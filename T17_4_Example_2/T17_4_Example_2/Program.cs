using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_4_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DClass d = new DClass();
                d.Method1();
                WriteLine($"{d.Sum(3,6)}");
                d.Hello("HELLOOOO!!!");
                d.Hi("HI!");
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
