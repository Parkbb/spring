// 클래스에서 반드시 구현해야 하는 관련 기능에 대한 정의가 포함된 개념
// [?] 인터페이스: 특정 멤버가 반드시 구현되어야 함을 보증
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._45_Interface
{
    public interface IStandard
    {
        void Left();
    }
    abstract class KS
    {
        public abstract void Back();
    }

    partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }

    partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("우회전");
    }

    sealed class Car : MyCar, IStandard
    {
        public void Left() => Console.WriteLine("좌회전");

        public void Run() => Console.WriteLine("직진");
    }

    //class SpyCar : Car { }

    class Class1
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run(); car.Right(); car.Back(); car.Left();
            //SpyCar spy = new SpyCar(); spy.Run();
        }
    }
}
