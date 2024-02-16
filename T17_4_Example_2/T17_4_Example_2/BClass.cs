using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_4_Example_2
{
    abstract class BClass : AClass
    {
        /// <summary>
        /// Sum of x and y
        /// </summary>
        /// <param name="x">First num</param>
        /// <param name="y">Second num</param>
        /// <returns></returns>
        public abstract int Sum(int x, int y);
    }
}
