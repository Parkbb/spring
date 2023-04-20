// 상속: 부모 클래스에 정의된 기능을 다시 사용, 확장 및 수정하여 자식 클래스로 만들기
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._43_Inheritance
{
    public enum CarType { 전기, 내연 }

    public abstract class CarBase
    {
        public abstract void Left(); // 추상 클래스의 추상 메서드, 본문x, 시그니처 o => 표준(강제) => 인터페이스
        public void Back() => Console.WriteLine("띠리리리");
    }

    public class Car : CarBase
    {
        public void Go() => Console.WriteLine("부릉부릉");

        public override void Left() => Console.WriteLine("좌회전"); // 실제 코드 구현, 재정의

        public CarType Style { get; private set; }

        public Car(CarType carType)
        {
            this.Style = carType;
        }
    }

    public class Benz : Car // Sub : Base
    {
        public Benz() : this(CarType.내연) { }
        public Benz(CarType carType) : base(carType) { }

    }

    public class Tesla : Car // Child : Parent
    {
        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType carType) : base(carType) { }
        
        
    }
    
    // 봉인(최종) 클래스
    public sealed class Future : Car
    {
        public Future(CarType carType) : base(carType) { }

        public Future() : this(CarType.전기) { }

        public new void Go()
        {
            base.Go(); Console.WriteLine("날다.");
        }
    }



    class InheritanceDemo : Object
    {
        static void Main(string[] args)
        {
            Benz benz = new Benz(CarType.전기); benz.Go(); Console.WriteLine($"{benz.Style}"); benz.Back();
            Tesla tesla = new Tesla(); tesla.Go(); Console.WriteLine($"{tesla.Style}"); tesla.Back();
        }
    }
}
