using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//[1] 네임스페이스: 클래스명 충돌 방지
namespace EnumerationTextbook._47_OOP
{
    //[2] 인터페이스: 표준, 다중상속
    interface IStandard { void Run(); }

    // [3] 클래스: 설계도
    class Car : IStandard
    {   

        // 캡슐화
        #region [4] 필드: Private Member Variables
        private string name; // 필드: 부품
        private string[] names; // 배열형 필드
        private readonly int _Length; // 읽기전용 필드
        #endregion

        #region [5] 생성자: Constructors
        public Car()
        {
            this.name = "좋은차"; // 필드를 기본값으로 초기화
        }
        public Car(string name) // 생성자: 시동, 필드 초기화
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.Name = "좋은차";
            _Length = length; // 읽기전용 필드는 생성자에 의해서 초기화 가능
            names = new string[length]; // 넘겨온 값으로 요소 생성
        }
        #endregion
        #region [6] 메서드: Public Methods
        // 메서드 : 기능/동작
        public void Run() => Console.WriteLine($"{name} 자동차가 달립니다.");
        #endregion

        #region [7] 속성: Public Properties
        public string Name // 속성 : private 필드 -> 외부공개
        {
            get { return name; }
            set { name = value; }
        }
        public int Length { get { return _Length; } }
        #endregion

        #region [8] 소멸자: Destructor
        ~Car() // 소멸자 : 폐차, 만들어진 객체 소멸될 때
        {
            Console.WriteLine($"{name} 자동차가 폐차됨");
        }
        #endregion

        #region [9] 인덱서: Indexer
        public string this[int index] // 인덱서:카탈로그 화
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region [10] 이터레이터 : Iterators
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region [11] 대리자: Public Delegates
        public delegate void EventHandler(); // 대리자: 다중메서드호출
        #endregion

        #region [12] 이벤트: Public Events
        public event EventHandler Click; // 이벤트
        #endregion

        #region [13] 이벤트 처리기: Event Handlers
        public void Onclick() // 이벤트 핸들러
        {
            if (Click != null)
            {
                Click();
            }
        }
        #endregion

    }

    class CarRepair
    {
        public CarRepair(IStandard car) => car.Run();
    }

    class CarWorld
    {
        static void Main()
        {

        }
    }
}
