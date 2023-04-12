using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BitOr
{
    class BitOr
    {
        static void Main()
        {
            // | 연산자 : 비트 OR 연산자 (둘 중 하나라도 1인 경우 1)

            byte x = 0b1010; //10
            byte y = 0b1100; //12


            WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
            WriteLine($"| {Convert.ToString(y, 2)} -> {y}");
            WriteLine($"------");
            WriteLine($"  {Convert.ToString(x | y, 2)} -> {x | y,2}");
        }
    }
}
