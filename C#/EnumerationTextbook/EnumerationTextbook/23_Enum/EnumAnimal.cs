using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._23_Enum
{
    class EnumAnimal
    {
        //열거형(Enumeration): 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수 집합을 정의
        enum Animal {Mouse, Cow, Tiger};

        static void Main()
        {
            Console.WriteLine(Animal.Mouse);
        }

    }
}
