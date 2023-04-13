using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._25_String
{
    class StringConcat
    {
        static void Main()
        {
            // 문자열 연결 : 더하기 연산자, String.Concat() 메서드

            string s1 = "안녕" + "하세요.";
            string s2 = String.Concat("반갑", "습니다.");
            Console.WriteLine($"{s1}, {s2}");

            Console.WriteLine("---------------");

            // 문자열의 길이 : String.Length 속성

            string s3 = "Hola";
            string s4 = "안녕하세요.";
            Console.WriteLine(s3.Length + "," + s4.Length);

            Console.WriteLine("---------------");

            // ToCharArray() 메서드로 문자열을 문자 배열로 변환하기

            string s = "안녕하세요.";
            char[] ch = s.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }

            Console.WriteLine("---------------");

            // 문자열 묶는 3가지 표현 방법 정리

            var displayName = "";
            var firstName = "길동";
            var lastName = "홍";

            // 더하기(+) 연산자
            displayName = lastName + firstName;
            Console.WriteLine(displayName);
            // string.Format(), String.Format() 메서드 사용
            displayName = string.Format("이름: {0}{1}", lastName, firstName);
            Console.WriteLine(displayName);
            // 문자열 보간법 사용
            displayName = $"이름: {lastName}{firstName}";
            Console.WriteLine(displayName);

            Console.WriteLine("---------------");
            
            string userName = "RedPlus";
            string userNameInput = "redplus";

            if (userName.ToLower() == userNameInput)
            {
                Console.WriteLine("같습니다.");
            }

            if (string.Equals(userName, userNameInput, 
                StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("같숩니다.");
            }

            Console.WriteLine("---------------");
            // 문자열 값 비교: 대소문자 비교

            string a1 = "Gilbut";
            string a2 = "gilbut";

            //[1] 문자열의 값의 대소문자를 구분
            if (s1 == s2)
            {
                Console.WriteLine("같");
            }
            else
            {
                Console.WriteLine("다름1");
            }

            //[2] 문자열의 대소문자를 구분하지 않고 비교
            if (a1.Equals(a2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("같음2");
            }
            else
            {
                Console.WriteLine("다름2");
            }
        }
    }
}
