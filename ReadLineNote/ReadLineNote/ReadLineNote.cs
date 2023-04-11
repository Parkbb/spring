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


    }

}