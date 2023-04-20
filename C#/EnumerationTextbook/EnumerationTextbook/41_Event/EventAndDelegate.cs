using System;

namespace EventAndDelegate
{
    // 이벤트 구독자(Subscriber)
    class EventAndDelegate
    {
        static void Main()
        {
            Car car = new Car();
            car.FuelEmptyReached += Car_FuelEmptyReached;
            car.FuelEmptyReached -= Car_FuelEmptyReached;
            car.FuelEmptyReached += () =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("연 료 부 족!!");
                Console.ResetColor();
            };
            car.Go();
            car.Go();
            //car.OnFuelEmptyReached();

        }
        
        // 이벤트 처리기(핸들러): Handler
        private static void Car_FuelEmptyReached()
        {
            System.Console.WriteLine("연료 부족");
        }
    } 
}