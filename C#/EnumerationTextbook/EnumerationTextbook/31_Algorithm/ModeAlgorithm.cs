//[?] 주어진 데이터에서 가장 많이 나타난 값
// 최빈값 알고리즘(Mode Algorithm): 점수 인덱스(0~n)의 개수(COUNT)의 최댓값(MAX)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class ModeAlgorithm
    {
        static void Main(string[] args)
        {
            //[1] Input
            int[] scores = { 1, 3, 4, 3, 5 }; //0~5 까지만 들어온다고 가정
            int[] indexes = new int[5 + 1]; // 0~5 까지 점수 인덱스의 개수 저장
            int max = int.MinValue; // MAX 알고리즘 적용
            int mode = 0; // 최빈값이 담길 그릇

            //[2] Process: Data -> Index -> Count -> Max -> Mode
            for (int i = 0; i < scores.Length; i++)
            {
                indexes[scores[i]]++; // COUNT
            }

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] > max)
                {
                    max = indexes[i];
                    mode = i;
                }
            }

            //[3] Output
            Console.WriteLine($"최빈값: {mode}, 등장횟수: {max}");
        }
    }
}
