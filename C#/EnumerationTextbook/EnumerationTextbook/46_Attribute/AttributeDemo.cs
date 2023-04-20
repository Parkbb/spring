using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EnumerationTextbook._46_Attribute
{
    public class LuxuryAttribute : Attribute 
    {
        public LuxuryAttribute() => Console.WriteLine("럭셔리!!!");
    }

    [Luxury]
    class Car
    {   [Obsolete("다음 버전에 제거될 예정이니 Auto()를 사용하세요.")]
        public void Manual() => Console.WriteLine("수동");
        public void Auto() => Console.WriteLine("자동");
        [Conditional("DEBUG")]
        public void Test() => Console.WriteLine("테스트");

    }

    class AttributeDemo
    {
        static void Main()
        {
            Car car = new Car();
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);
            car.Manual();
            car.Auto();
            car.Test();
        }
    }
}
