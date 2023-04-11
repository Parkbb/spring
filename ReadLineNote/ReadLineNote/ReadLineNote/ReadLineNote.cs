using System;

class ReadLineDemo
{
    static void Main()
    {
        Console.ReadLine(); // <- 이 시점에서 대기하는 효과

        Console.Write("이름:_______\b\b\b\b");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}님 안녕하세요.");

        int x = Console.Read();

        Console.WriteLine(x); // 아스키코드(ASCII)

        Console.WriteLine(Convert.ToChar(x)); // 실제 문자

        int number = 10;
        
        string str = Convert.ToString(number, 2);

        string str2 = Convert.ToString(number, 2).PadLeft(8, '0');

        string str3 = Convert.ToString(number, 2).PadLeft(8, '_');

        Console.WriteLine(str);
        Console.WriteLine(str2);
        Console.WriteLine(str3);


        Convert.ToInt32("00001010", 2);

        //[?] var 키워드: 암시적으로 형식화된 로컬 변수

        // 연산자 (Operator): 데이터와 변수를 가지고 더하기(+), 빼기(-)와 같은 연산 작업을 수행

        var num = 1000;

        var number2 = num + 1234;

        // [?] 단항 연산자(Unary Operator): +, -

        var value = 0;
        value = 8;
        // 8
        value = +value;
        // 8
        value = -value;
        // -8
        value = -value;
        // 8

        var number3 = 3.14;


        // 할당 연산자와 증감 연산자 사용하기
        



    }

}