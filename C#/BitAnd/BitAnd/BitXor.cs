using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BitXor
{
    class BitXor
    {
        static void Main()
        {
            // ^ 연산자 : 비트 XOR 연산자 (서로 다르면 1)

            byte x = 0b1010; //10
            byte y = 0b1100; //12


            WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
            WriteLine($"^ {Convert.ToString(y, 2)} -> {y}");
            WriteLine($"------");
            WriteLine($"  {Convert.ToString(x ^ y, 2).PadLeft(4,'0')} -> {x ^ y,2}");
        }
    }
}
