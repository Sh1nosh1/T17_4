using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_4_Example_2
{
    class DClass : CCLass
    {
        /// <summary>
        /// Переопределение Method1
        /// </summary>
        public override void Method1()
        {
            WriteLine("Переопределение Method1 класса AClass в DClass");
        }
        /// <summary>
        /// Переопределение метода из AClass
        /// </summary>
        /// <param name="x">1 число</param>
        /// <param name="y">2 число</param>
        /// <returns></returns>
        public override int Sum(int x, int y) => x + y;
        public override void Hello(string hi)
        {
            WriteLine(hi);
        }
        public void Hi(string hi)
        {
            WriteLine(hi);
        }
    }
}
