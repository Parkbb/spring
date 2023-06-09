﻿//다중 스레딩: 동시에 여러 작업을 수행하여 앱의 응답성을 높이고, 다중 코어에서 처리량 향상
//스레드(Thread): 작업자 한명, 스레드(사람들)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnumerationTextbook._55_Thread
{
    class Restaurant
    {
        public void MakeFood()
        {
            Console.WriteLine($"요리 시작");
            DateTime start = DateTime.Now;


            void Egg()
            {
                Thread.Sleep(3000); Console.WriteLine("달걀 3초");
            }
            Thread t1 = new Thread(new ThreadStart(Egg));

            void Soup()
            {
                Thread.Sleep(5000); Console.WriteLine("국 5초");
            }
            Thread t2 = new Thread(Soup);


            Thread t3 = new Thread(() =>
            {
                Thread.Sleep(8000); Console.WriteLine("밥 7초");
            });

            t1.Start();
            t2.Start();
            t3.Start(); // async

            t1.Join();
            t2.Join();
            t3.Join(); // await

            Console.WriteLine($"요리 종료: {(DateTime.Now - start).TotalSeconds}");
            Console.WriteLine($"식사 시작");
            SinglePro();
            //MultiPro();

            Console.WriteLine($"식사 종료: {(DateTime.Now - start).TotalSeconds}");
        }

        private void SinglePro()
        {
            for (int i = 0; i < 20_000; i++)
            {
                Console.WriteLine("수다");
            }
        }
        private void MultiPro()
        {
            Parallel.For(0, 20000, (i) => { Console.WriteLine("수다"); });
        }

    }

    class ThreadEx
    {
        static void Main() => (new Restaurant()).MakeFood();

    }
}
