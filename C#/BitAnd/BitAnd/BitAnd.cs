using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitAnd
{
    class BitAnd
    {
        static void Main()
        {
            // & 연산자 : 비트 AND 연산자 (둘 다 1일때만 1)

            byte x = 0b1010; //10
            byte y = 0b1100; //12
            

            Console.WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
            Console.WriteLine($"& {Convert.ToString(y, 2)} -> {y}");
            Console.WriteLine($"------");
            Console.WriteLine($"  {Convert.ToString(x & y, 2)} -> {x & y, 2}");
        }
    }
}
