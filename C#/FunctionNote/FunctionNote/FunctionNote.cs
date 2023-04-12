using System;

class FunctionNote
{   
    // 선언
    static int Sum(int first, int second)
    {
        return first + second;
    }

    // 아래처럼도 표현 가능
    //static void Sum2() => Console.WriteLine("합계");

    // 호출: DotNet.exe 3 5
    static void Main(string[] args)
    {
        //호출
        //FunctionNote.Sum();
        int first = Convert.ToInt32(args[0]);
        int second = Convert.ToInt32(args[1]);

        Console.WriteLine(Sum(first, second));
        
    }
}