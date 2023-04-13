using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnumerationTextbook._28_Generic
{
    class GenericEx
    {
        static void Main()
        {
            // 제네릭: Cup<T>을 Cup of T로 발음하여 형식 매개 변수인 T에 따른 Cup 클래스의 개체 생성
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(100);
            numbers.Add(80);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("green");
            colors.Insert(0, "blue");


            List<int> numbers2 = new List<int>();

            numbers2.AddRange(Enumerable.Range(1, 10));

            foreach (var number in numbers2)
            {
                Console.WriteLine(number);
            }



        }
    }
}
