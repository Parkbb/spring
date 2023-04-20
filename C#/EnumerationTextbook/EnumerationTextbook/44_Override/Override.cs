using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//메서드 오버라이드
// 오버라이드 : 부모 클래스의 메서드를 자식 클래스에서 재정의, 가상 메서드
// virtual과 override
namespace EnumerationTextbook._44_Override
{
    class Parent
    {
        protected void Say() => Console.WriteLine("부모_안녕하세요.");
        protected void Run() => Console.WriteLine("부모_달리다.");
        public virtual void Walk() => Console.WriteLine("부모_달리다.");
        public virtual void Work() => Console.WriteLine("부모_프로그래머.");
    }

    class Child : Parent
    {
        public void Say() => Console.WriteLine("자식_안녕하세요.");
        public new void Run() => Console.WriteLine("자식_달리다.");
        public override void Work() => Console.WriteLine("자식_프로게이머");
        public override void Walk() => base.Walk();
    }

    class Override
    {
        static void Main()
        {
            Child child = new Child(); 
            child.Say(); // 자식이 예의가 없는 경우
            child.Run(); // 자식이 예의가 있는 경우
            child.Walk(); // 부모도 관대하고 자식도 예의가 있는 경우: virtual -> override
            child.Work();
        }
    }
}
