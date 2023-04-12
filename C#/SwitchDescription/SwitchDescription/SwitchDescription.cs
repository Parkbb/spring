using System;

class SwitchDescription
{
    static void Main()
    {
        Console.WriteLine("정수를 입력하세요.");
        int answer = Convert.ToInt32(Console.ReadLine());


        switch (answer)
        {
            case 1:
                Console.WriteLine("1을 선택했습니다.");
                break;

            case 2:
                Console.WriteLine("2을 선택했습니다.");
                break;

            case 3:
                Console.WriteLine("3을 선택했습니다.");
                break;

            case 4:
                Console.WriteLine("4을 선택했습니다.");
                break;

            default:
                Console.WriteLine("그냥 찍었네요");
                break;
        }
    }
}