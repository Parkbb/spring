using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._49_Extension_Method
{
    static class StringExtension
    {
        public static string Five(this String message) => message.Substring(0,5);
        public static string Ten(this String message) => message.Substring(0,10);
        public static string AddElipsis(this String message) => message + "...";
    }

    class Class1
    {
        static void Main(string[] args)
        {
            string message = "안녕하세요. 반갑습니다. 또 만나요";
            Console.WriteLine(message.Five());
        }
    }
}
