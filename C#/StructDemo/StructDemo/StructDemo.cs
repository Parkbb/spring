//[?] 구조체: 하나 이상의 변수 또는 배열을 묶어서 관리
using System;

struct Point
{
    public int X; //public 공용
    public int Y;
    private int Z; //private 전용
}

class StructDemo
{
    static void Main()
    {
        Point point;
        point.X = 100;
        point.Y = 200;

        Console.WriteLine($"X: {point.X}, Y: {point.Y}");
    }
}