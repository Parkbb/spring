//[?] 주어진(지정한 범위) 데이터의 순위(등수)를 구하는 로직
// 순위 알고리즘(Rank Algorithm: 점수 데이터에 대한 순위 구하기
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class RankAlgorithm
    {
        static void Main(string[] args)
        {
            //[1] Input
            int[] scores = { 90, 87, 100, 95, 80 };
            int[] rankings = Enumerable.Repeat(1, 5).ToArray();

            //[2] Process: RANK
            for (int i = 0; i < scores.Length; i++)
            {
                rankings[i] = 1; // 1등으로 초기화, 순위 배열을 매 회전마다 1등으로 초기화
                for (int j = 0; j < scores.Length; j++)
                {
                    if (scores[i] < scores[j]) //현재(i)와 나머지들(j)를 비교
                    {
                        rankings[i]++;
                    }
                }
            }
            //[3] Output
            for (int i = 0; i < rankings.Length; i++)
            {
                Console.WriteLine($"{scores[i],3}점: {rankings[i]}등");
            }
        }
    }
}
