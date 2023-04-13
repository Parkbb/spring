using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._29_Null
{
    class NullEx
    {
        static void Main(string[] args)
        {
            // Nullable<T> 구조체를 사용하여 널 가능 형식 변수 만들기
            Nullable<bool> bln = null;
            Console.WriteLine(bln);

            bln = true;
            Console.WriteLine(bln.HasValue);

            // Nullable 형식: null(값이 없음을 의미)이 할당될 수 있는 형식
            // 참조 형식: null 할당 가능

            string s = null;

            //int i = null; // 에러 안됨
            int? i = null;

            // System.Nullable<T> 제네릭 클래스: int? double? 사용 권장

            // ?? 연산자(널 병합 연산자(Null Coalescing Operator))
            string nullValue = null;
            string message = "";

            //[1] if 구문으로 null 값 비교
            if (nullValue == null)
            {
                message = "[1] null이면 새로운 값으로 초기화합니다.";
            }

            Console.WriteLine(message);

            //[2] ?? 연산자로 null 값 비교
            nullValue = null;
            message = nullValue ?? "[2] null이면 새로운 값으로 초기화합니다.";

            Console.WriteLine(message);

            int? value = null; // null 가능 형식에 null로 초기화
            int defalutValue = value ?? -1; // value가 null 이면 -1 대입

            int? x = null;
            int y = x ?? 100; // x가 null 이면 100으로 초기화
            int z = x ?? default(int); // 정수형의 기본값인 0으로 초기화

            // Null 조건부 연산자(Null Conditional)

            double? d = null;
            Console.WriteLine(d?.ToString());
            d = 3.15;
            Console.WriteLine(d?.ToString());

            // ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성값 반환
            // ?. 연산자는 엘비스의 머리 모양과 비슷하다고 하여 Elvis 연산자라고도 함

            List<string> list = null;
            int? numberOflist;

            numberOflist = list?.Count;

            Console.WriteLine(numberOflist);

            list = new List<string>();
            list.Add("안녕하세요"); list.Add("반갑습니다.");

            numberOflist = list?.Count;

            Console.WriteLine(numberOflist);

            // Null 병합 연산자와 Null 조건부 연산자 함께 사용하기
            // ?? 연산자: 컬렉션이 null이 아니면 해당값 반환, null이면 뒤에 지정한 값 반환
            // ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환

            int num;
            List<string> list2;

            // [1] 컬렉션 리스트가 null이면 Count를 읽을 수 없기에 0으로 초기화
            list2 = null;
            num = list?.Count ?? 0; // null이면 0

            // [2] 컬렉션 리스트가 null이 아니면 count 속성의 값을 사용
            list2 = new List<string>(); list2.Add("반갑");
            num = list?.Count ?? 0; // null이 아니기 때문에 왼쪽 값 사용
        }
    }
}
