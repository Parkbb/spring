using System;

public class Car
{
    private string _name;
    public Car()
    {
        //기본 생성자, 생성자 메서드
        //Console.WriteLine("자동차 개체를 생성합니다. 조립, 시동걸기");
        _name = "기본자동차";
    }
    public Car(string name)
    {
        _name = name;
    }
    public void Go() => Console.WriteLine($"{_name} 달리다.");
}

class ConstructorEx
{
    static void Main(string[] args)
    {
        Car car = new Car(); car.Go();
        Car my = new Car("좋은자동차"); my.Go();
    }
}

