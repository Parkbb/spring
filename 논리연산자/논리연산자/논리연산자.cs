using System;

public class 논리연산자
{
    static void Main()
    {
        //논리연산자
        // && 연산자 : 둘 다 참일때에만 참, 즉, 하나라도 거짓이면 거짓
        // || 연산자 : 하나라도 참이면 참, 즉, 둘 다 거짓일때에만 거짓
        // ! 연산자 : 참이면 거지승로, 거짓이면 참으로

        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3); // r = true && true => true
        Console.WriteLine(r);

        r = (i == 4) || (j != 3); // r = false || true => true
        Console.WriteLine(r);

        r = (i == 4) || (j == 3); // r = false || false => false
        Console.WriteLine(r);

        r = (i >= 5); // r => false
        Console.WriteLine(!r);
    }

}