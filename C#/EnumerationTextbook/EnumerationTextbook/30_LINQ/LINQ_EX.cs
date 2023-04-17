using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._30_LINQ
{
    class LINQ_EX
    {
        static void Main(string[] args)
        {
            // LINQ : C# 언어에 직접 쿼리(Query) 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Where(n => n % 2 == 0).Sum());

            Console.WriteLine(numbers.Select(x => { return x * 2; }).Sum());

            /*
             var q = from n in numbers
                     where n % 2 == 0
                     select n;

            var qq = numbers.Where(n => n % 2 == 0);

            LINQ 표현방식만 다르고 동일한 결과가 나옴
             */
        }
    }
}
