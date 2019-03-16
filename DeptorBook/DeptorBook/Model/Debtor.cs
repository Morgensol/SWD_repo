using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DebtorBook.Model
{
    public class Debtor :INotifyPropertyChanged
    {
        private int _debt=0;
        private string _name = "";
        public ObservableCollection<Expenses> Transactions { get; set; }
        public Debtor(int d, string n)
        {
            _name = n;
            Transactions = new ObservableCollection<Expenses>();
            if (d != 0)
                Debt = d;
            else
                _debt = d;
        }
        public int Debt
        {
            get => _debt;
            set
            {
                if (_debt == value) return;
                Transactions.Add(new Expenses(DateTime.Now, value));
                _debt = 0;
                foreach (var i in Transactions)
                {
                    _debt += i.Dept;
                }
                NotifyPropertyChanged(nameof(Debt));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if(_name==value) return;
                _name = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged( String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
