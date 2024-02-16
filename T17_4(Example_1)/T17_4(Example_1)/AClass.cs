using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_4_Example_1_
{
    /// <summary>
    /// Abstract class
    /// </summary>
    abstract class AClass
    {
        public void Method1()
        {
            WriteLine("Объявление метода Method1 из абстрактного класса AClass");
        }
        public virtual void Method2()
        {
            WriteLine("Объявление метода Method2 из абстрактного класса AClass");
        }
        public abstract void Method3();
        public abstract void Method4();
    }
}
