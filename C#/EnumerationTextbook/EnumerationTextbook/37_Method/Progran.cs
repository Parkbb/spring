using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ch37
{
    public class Car
    {
        public void Map(string title) => Console.WriteLine($"[2] {title}");
    }

    class MethodAndParameter
    {
        static void Main(string[] args)
        {
            string title = "복사"; Console.WriteLine($"[1] {title}");
            var car = new Car(); car.Map(title);
            Console.WriteLine($"[3] {title}");
        }
    }
}


