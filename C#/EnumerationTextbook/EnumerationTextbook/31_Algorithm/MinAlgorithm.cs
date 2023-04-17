//[?] 주어진 데이터 중에서 가장 작은 값
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class MinAlgorithm
    {
        static void Main(string[] args)
        {
            //[1] Initialize

            //[2] Input
            int[] numbers = { -2, -5, -3, -7, -1 };
            int minNum = int.MaxValue;
            //[3] Process: MAX
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
            }

            //[4] Output
            Console.WriteLine($"최솟값: {minNum}");
        }
    }
}
