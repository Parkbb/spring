using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class ConditionalOperator
    {
        static void Main()
        {
            int number = 3;

            string result = (number % 2 == 0) ? "짝수" : "홀수";

            Console.WriteLine($"{number}는/은 {result} 입니다.");
        }
    }
}
