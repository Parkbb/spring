﻿namespace WpfOracleTest3
{
    public class EmpViewModel
    {
        int empno = 0;
        string ename = string.Empty;
        string job = string.Empty;

        //public 프로퍼티
        public int Empno
        { 
            get { return empno; }
            set { this.empno = value; }
        }

        public string Ename
        {
            get { return ename; }
            set { this.ename = value; }
        }

        public string Job
        {
            get { return job; }
            set { this.job = value; }
        }
    }
}
