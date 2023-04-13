using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._26_Exception
{
    class TryCatch
    {
        static void Main()
        {

            try
            {
                int[] arr = new int[2];
                arr[100] = 1234; //예외 발생: System.IndexOutOfRangeException

            }
            catch 
            {
                Console.WriteLine("에러가 발생");
                
            }


            try
            {
                int[] arr = new int[2];
                arr[100] = 1234; //예외 발생: System.IndexOutOfRangeException

            }
            catch(Exception e) // 변수에는 예외에 대한상세 정보가 담김
            {
                Console.WriteLine(e.Message);

            }


            string inputNumber = "3.14";
            int number = 0;

            try
            {
                number = Convert.ToInt32(inputNumber);
                Console.WriteLine($"입력한 값: {number}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"에러 발생: {fe.Message}");
                Console.WriteLine($"{inputNumber}는 정수여야 합니다.");
            }


            Console.WriteLine("[1] 시작");

            //[!] 에러 발생할만한 코드 들어오는 영역
            try
            {
                Console.WriteLine("[2] 실행");
                throw new Exception(); // 무작정 에러 발생
            }
            //[!] try절에서 에러가 발생하던 안하던 반드시 실행
            finally 
            {

                Console.WriteLine("[3] 종료");
            }

        }
    }
}
