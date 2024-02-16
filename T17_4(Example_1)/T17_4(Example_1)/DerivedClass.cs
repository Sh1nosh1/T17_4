using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_4_Example_1_
{
    class DerivedClass :AClass
    {
        /// <summary>
        /// Переобределение метода Method2
        /// </summary>
        public override void Method2()
        {
            base.Method2();
            WriteLine("Вызов Method2 из класса ACladss реализованный в DerivedClass");

        }
        /// <summary>
        /// Переопределение абстрактного метода Method3
        /// </summary>
        public override void Method3() => WriteLine("Вызов Method3 из класса ACladss реализованный в DerivedClass");
        /// <summary>
        /// Переопределение абстрактного метода Method4
        /// </summary>
        public override void Method4() => WriteLine("Вызов Method4 из класса ACladss реализованный в DerivedClass");
        

    }
}
