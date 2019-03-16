using System;

namespace DebtorBook.Model
{
    public class Expenses
    {
        private int _dept;
        private DateTime _time;
        public int Dept
        {
            get => _dept;
            set
            {
                if (_dept == value) return;
                _dept = value;
            }
        }

        public DateTime Time
        {
            get => _time;
            set
            {
                if (_time == value) return;
                _time = value;
            }
        }

        public Expenses(DateTime time, int dept)
        {
            Dept = dept;
            Time = time;
        }
    }
}