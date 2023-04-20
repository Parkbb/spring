using System;

namespace EventAndDelegate
{   
    // 게시자(Publisher)
    class Car
    {
        private int _fuelPercent;
        public Car()
        {
            _fuelPercent = 25; //25%
        }
        public int FuelPercent
        {
            get { return _fuelPercent; }
            set 
            { 
                _fuelPercent = value;
                OnFuelEmptyReached();

            }
        }
        public void Go()
        { 
            Console.WriteLine("운전");
            FuelPercent -= 5;
        }
        //public delegate void FuelEmptyNotification();
        //public event FuelEmptyNotification FuelEmptyReached;
        public event Action FuelEmptyReached;
        public void OnFuelEmptyReached()
        {
            Console.WriteLine($"연료 상태: {_fuelPercent}%");
            if (_fuelPercent < 20)
            {
                if (FuelEmptyReached != null)
                {
                    //FuelEmptyReached();
                    FuelEmptyReached?.Invoke();
                } 
            }
        }
    }
}