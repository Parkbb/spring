//[?] 원본 데이터 중에서 대상 데이터와 가장 가까운 값
//[?] 근삿값 알고리즘: 차잇값의 절댓값의 최솟값
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class NearAlgorithm
    {
        static void Main(string[] args)
        {
            //[0] 절댓값 구하기 로컬 함수: Math.Abs() 함수와 동일한 기능을 구현해 봄
            int Abs(int num) => (num < 0) ? -num : num;

            //[1] Initialize
            int min = int.MaxValue; // 차잇값의 절댓값의 최솟값이 담길 그릇

            //[2] Input
            int[] numbers = { 10, 20, 30, 27, 17};
            int target = 25;
            int near = default;

            //[3] Process
            for (int i = 0; i < numbers.Length; i++)
            {
                int abs = Abs(numbers[i] - target);
                if (abs < min)
                {
                    min = abs;
                    near = numbers[i];
                }
            }


            //[4] Output
            var minimum = numbers.Min(m => Math.Abs(m - target));
            var closest = numbers.First(n => Math.Abs(n - target) == minimum);
            Console.WriteLine($"{target}와 가장 가까운 값: {closest}(차이: {minimum})");
            Console.WriteLine($"{target}와 가장 가까운 값: {near}(차이: {min})");
        }
    }
}
