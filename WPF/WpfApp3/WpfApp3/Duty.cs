using System.Collections.ObjectModel;

namespace WpfApp3
{
    public enum DutyType
    { 
        Inner,
        Outside
    }

    public class Duty
    {
        private string _name;
        private DutyType _dutyType;

        public Duty() { }
        public Duty(string name, DutyType dutyType)
        {
            _name = name;
            _dutyType = dutyType;
        }   

        public string DutyName
        { 
            get { return _name; }
            set { _name = value; }
        }

        public DutyType DutyType 
        {
            get { return _dutyType; }
            set { _dutyType = value; }  
        }
    }

    public class Duties : ObservableCollection<Duty>
    {
        public Duties()
        { 
            Add(new Duty("SALES", DutyType.Outside));
            Add(new Duty("LOGISTICS", DutyType.Outside));
            Add(new Duty("IT", DutyType.Inner));
            Add(new Duty("MARKETING", DutyType.Inner));
            Add(new Duty("PROPORTION", DutyType.Outside));
            Add(new Duty("HR", DutyType.Inner));
        }
    }
}
