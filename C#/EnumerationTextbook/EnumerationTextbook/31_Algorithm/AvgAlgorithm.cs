//[?] n명의 점수 중에서 80점 이상 95점 이하인 점수의 평균
// 평균 알고리즘(Average Algorithm): 주어진 범위에 주어진 조건에 해당하는 자료들의 평균
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class AvgAlgorithm
    {
        static void Main(string[] args)
        {
            //[1] Input: n명의 성적
            int[] data = { 90, 65, 78, 50, 95 };
            int sum = 0;
            int count = 0;

            //[2] Process:
            for (int i = 0; i < data.Length; i++)
            {
                if ( data[i] >= 80 && data[i] <= 95 )
                {
                    sum += data[i];
                    count++;
                }
            }

            Console.WriteLine($"80점 이상 95점 이하의 평균은 {(double)sum/count}");
        }
    }
}
