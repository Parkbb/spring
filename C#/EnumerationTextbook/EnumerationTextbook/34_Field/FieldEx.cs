using System;

public class Person
{
    private string name = "박용주";
    private const int m_age = 20; // 필드 == 멤버 변수, 전역 변수
    private readonly string NickName;
    private string[] websites = { "닷넷코리아", "비주얼아카데미" };
}

public class Say
{
    private string message = "반갑습니다.";
    public void Hi()
    {
        Console.WriteLine(this.message);
    }
}

public class FieldEx
{
    private static string message = "안녕하세요.";
    public static void Hi() => Console.WriteLine(message);
    public static void Main(string[] args)
    {
        int number = 1234; // 변수, 지역 변수
        Console.WriteLine(number);
        Console.WriteLine(message);
        Hi();
        Say say = new Say(); say.Hi();
    }
}
