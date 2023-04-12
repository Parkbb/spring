using System;

class GoToDemo
{
    static void Main()
    {   
        //goto문 : 지정한 레이블로 이동하는 구문
        Console.WriteLine("시작");
        Start:
        Console.WriteLine("0,1,2 중 하나를 입력: _\b");
        int chapter = Convert.ToInt32(Console.ReadLine());

        if (chapter == 1)
        {
            goto chapter1;
        }
        else if (chapter == 2)
        {
            goto chapter2
        }
        else 
        {
            goto End;
        }

        chapter1:
        Console.WriteLine("1장입니다.");
     chapter2:
        Console.WriteLine("2장입니다.");

        goto Start;
        End:
        Console.WriteLine("종료");
    }
}