using System;

class MyClass
{
    static void Main()
    {
        int number = 1_234;
        Console.WriteLine("{0}", number);

        int min = Int32.MinValue; //정수형의 최소값
        int max = Int32.MaxValue; //정수형의 최댓값

        Console.WriteLine("int 뱐수의 최솟값 : {0}", min);
        Console.WriteLine("int 뱐수의 최댓값 : {0}", max);

        sbyte sb = 127;
        short st = 32767;
        int i = Int32.MaxValue;
        long l = Int64.MaxValue;

        Console.WriteLine("{0} {1} {2} {3}", sb, st, i, l);

        // 부호 없는 정수 데이터 형식: byte, ushort, uint, ulong
        // double 키워드 : 실수형 데이터 형식(64비트 부동 소수점 숫자)
        // float 키워드: 실수형 데이터 형식(32비트 부동 소수점 숫자)
        // decimal 키워드: 실수형 데이터 형식(128비트 10진수) m,M
        // int?, long?, float?, double?, decimal? null 허용 형식


        // 숫자 이외의 데이터 형식(bool, char, string)
        // 숫자 이외의 데이터 형식: bool, char, string 등의 키워드로 숫자 이외의 데이터 저장


        // char 키워드 : 문자 데이터 형식 변수를 선언
        char es = '\n';
        char kor = '가';

        String hi = "안녕하세요.";

        String multiLines = @"
            안녕하세요.
            반갑습니다.
        ";

        Console.WriteLine(multiLines);

        // StringInterpolation
        // 문자열 보간법(보간된 문자열)
        Console.WriteLine("{0},{1}", "Hello", "World");


        int dice = 3;
        string result = "홀수";
        Console.WriteLine($"{number}는 {result}입니다.");

        // PlaceHolder
        // "Hello" + "," + "World"

        // String.Format() 메서드 : 문자열 연결 관련 주요 기능 제공
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요");
        Console.WriteLine(msg);

        string name = "C#";
        string version = "8.0";

        //[1] WriteLine() 메서드의 기본 제공 기능 사용
        Console.WriteLine("{0} {1}", name, version);

        //[2] String.Format() 메서드 사용
        string result2 = String.Format("{0} {1}", name, version);
        Console.WriteLine(result2);

        //[3] 문자열 보간법 사용
        Console.WriteLine($"{name} {version}");



    }
}