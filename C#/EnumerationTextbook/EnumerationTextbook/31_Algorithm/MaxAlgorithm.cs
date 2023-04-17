//[?] 주어진 데이터 중에서 가장 큰 값
// 최댓값 알고리즘: (주어진 범위 + 주어진 조건)의 자료들의 가장 큰 값
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class MaxAlgorithm
    {
        static void Main()
        {
            //[1] Initialize

            //[2] Input
            int[] numbers = { -2, -5, -3, -7, -1 };
            int maxNum = int.MinValue;
            //[3] Process: MAX
            for (int i = 0; i < numbers.Length; i++)
            {
                if ( numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
            }

            //[4] Output
            Console.WriteLine($"최댓값: {maxNum}");
        }
    }
}
