﻿using System;

class ForSumEven
{
    static void Main()
    {
        int n = 5;
        int sum = 0;

        for (int i = 0; i <= n; i++) // n == 5 이므로 i가 0, 1, 2, 3, 4일 때
        {
            if (i % 2 ==0)
            {
                sum += i; // 짝수 0, 2, 4 더하기
            }
        }

        Console.WriteLine($"1부터 {n}까지 짝수의 합 : {sum}");
    }
}