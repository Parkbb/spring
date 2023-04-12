
using System;

class BreakDemo
{
    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 5)
            {
                break; // i == 5 일때 for문 종료
            }
            Console.Write($"{(i+1)}번 반복\t");
        }
        Console.WriteLine();

        int j = 0;
        while (true)
        {
            if (j == 5)
            {
                break;
            }
            Console.Write($"{(j + 1)}번 반복\t");
            j++;
        }
        Console.WriteLine();
    }
}