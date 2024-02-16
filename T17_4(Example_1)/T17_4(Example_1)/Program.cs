using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_4_Example_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DerivedClass derivedClass = new DerivedClass();
                derivedClass.Method1();
                derivedClass.Method2();
                derivedClass.Method3();
                derivedClass.Method4();
                WriteLine();
                AClass aClass = new DerivedClass();
                aClass.Method1();
                aClass.Method2();
                aClass.Method3();
                aClass.Method4();
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
