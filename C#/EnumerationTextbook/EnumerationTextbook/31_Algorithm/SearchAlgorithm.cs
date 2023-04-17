//[?] 정렬되어 있는 데이터를 이진 검색(이분 탐색)을 사용하여 반씩 나눠서 검색
// 검색 알고리즘(Search Algorithm): 주어진 데이터에서 특정 데이터 찾기
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class SearchAlgorithm
    {
        static void Main(string[] args)
        {
            //[1] Input
            int[] data = { 1, 3, 4, 6, 9 }; // 오름차순으로 정렬되었다고 가정
            int N = data.Length; // 의사코드
            int search = 6; // 검색할 데이터
            bool flag = false; // 플래그 변수: 찾으면 true 찾지못하면 false
            int index = -1;


            //[2] Process: 이진 검색(Binary Search): Full Scan -> Index Scan
            int low = 0; // min: 낮은 인덱스
            int high = N - 1; // max: 높은 인덱스
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (data[mid] == search)
                {
                    flag = true;
                    index = mid;
                    break; // 찾으면 플래그, 인덱스 저장 후 종료
                }
                if (data[mid] > search)
                {
                    high = mid - 1; // 찾을 데이터가 작으면 왼쪽 영역으로 이동
                }
                else
                {
                    low = mid + 1; // 찾을 데이터가 크면 오른쪽 영역으로 이동
                }
            }

            //[3] Output
            if (flag)
            {
                Console.WriteLine($"{search}을 {index} 위치에서 찾았습니다.");
            }
            else
            {
                Console.WriteLine($"{search}을 찾지 못했습니다.");
            }
           
        }
    }
}
