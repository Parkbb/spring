using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BitNot
{
    class BitNot
    {
        static void Main()
        {
            // ~ 연산자 : 비트 NOT 연산자 (1 <-> 0 , 비트 반전)

            byte x = 0b1010; //10


            WriteLine($"~ {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x, 3}");
            WriteLine($"----------");
            WriteLine($"  {Convert.ToString((byte)~x, 2).PadLeft(8, '0')} -> {~x, 3}");
        }
    }
}
