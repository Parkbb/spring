using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._25_String
{
    class StringStudy
    {
        // String 클래스와 StringBuilder 클래스를 사용하여 문자열 다루기
        // 문자열 관련 주요 함수

        static void Main(string[] args)
        {
            string message = "hello world";

            Console.WriteLine(message.ToUpper()); // 대문자
            Console.WriteLine(message.ToLower()); // 소문자

            Console.WriteLine(
                message.Replace("hello","안녕하세요").Replace("world", "월드"));

        }

        

    }
}
