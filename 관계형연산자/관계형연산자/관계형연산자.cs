using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 관계형연산자
{
    class 관계형연산자
    {
        static void Main()
        {
            //관계형 연산자: < 작음, <= 작거나 같음, >큼, >= 크거나 같음, == 같음, != 다름
            //논리 연산자: &&논리곱, ||논리합, !논리부정

            int firstNum = 10;
            int secondNum = 5;
            bool r = false;

            Console.WriteLine(firstNum > secondNum); //true

            r = (firstNum <= secondNum); //flase
            Console.WriteLine(r);

            r = (firstNum == secondNum); // C Family : ==, VB Family : =
            Console.WriteLine(r);

            r = (firstNum != secondNum);
            Console.WriteLine(r);
        }
    }
}
