using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EnumerationTextbook._27_Collection
{
    class CollectionEx
    {
        static void Main()
        {
            string[] colors = { "red", "green", "blue" };

            foreach (var color in colors)
            {
                Console.Write(color + ",");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------");

            Array.Sort(colors);

            foreach (var color in colors)
            {
                Console.Write(color + ",");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------");

            Array.Reverse(colors);

            foreach (var color in colors)
            {
                Console.Write(color + ",");
            }
            Console.WriteLine();

            //LIFO : Last In, First Out 구조
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            Console.WriteLine(stack.Pop()); // 200이 먼저 나옴
            Console.WriteLine(stack.Pop()); // 100이 나옴
            //Console.WriteLine(stack.Pop()); // 오류 발생


            //FIFO : First In, First Out 구조
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);

            Console.WriteLine(queue.Dequeue()); // 100이 먼저 아모
            Console.WriteLine(queue.Dequeue()); // 200이 나옴


            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add(100);
            list.RemoveAt(1);
            list.Add(200);

            list.Insert(0, 50);

            foreach (var item in list)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();




        }
    }
}
