//[?] 2개의 정수 배열 합치기: 단, 2개의 배열은 오름차순으로 정렬되어 있다고 가정
// 병합 알고리즘(Merge Algorithm): 오름차순으로 정렬되어 있는 정수 배열을 하나로 병합
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class MergeAlgorithm
    {
        static void Main(string[] args)
        {
            //[1] Input
            int[] first = { 1, 3, 5 };
            int[] second = { 2, 4 };
            int M = first.Length; int N = second.Length; // M:N 관행
            int[] merge = new int[M + N]; //병합된 배열 담을 그릇
            int i = 0; 
            int j = 0; 
            int k = 0;



            //[2] Process
            while (i < M && j < N)
            {
                if (first[i] <= second[j]) // 더 작은 값을 merge 배열에 저장
                {
                    merge[k++] = first[i++];
                }
                else
                {
                    merge[k++] = second[j++];
                }
            }
            
            while (i < M) // 첫 번째 배열이 끝까지 도달할 때까지
            {
                merge[k++] = first[i++];
            }

            while (j < N) // 첫 번째 배열이 끝까지 도달할 때까지
            {
                merge[k++] = first[j++];
            }

            //[3] Output
            foreach (var m in merge)
            {
                Console.Write($"{m}\t");
            }
            Console.WriteLine();

        }
    }
}
