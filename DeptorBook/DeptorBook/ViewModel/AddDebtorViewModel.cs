using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DebtorBook.Model;

namespace DebtorBook.ViewModel
{
    public class AddDebtorViewModel
    {
        private Navigation _navigation;
        private int _newDebt;
        private string _newDebtor;
        private ObservableCollection<Debtor> Debtors;

        public string NewDebt
        {
            get => Convert.ToString(_newDebt);
            set
            {
                if (!(int.TryParse(value, out _newDebt)))
                {
                    MessageBoxResult s = MessageBox.Show("Not a valid number");
                }
            }
        }
        public string NewDebtor
        {
            get => _newDebtor;
            set
            {
                int local;
                if (!(int.TryParse(value, out local)))
                {
                    _newDebtor = value;
                }
                else
                {
                    MessageBoxResult s = MessageBox.Show("Cannot be numbers");
                }
            }
        }
        public AddDebtorViewModel(Navigation navigation, ObservableCollection<Debtor> debtors)
        {
            Debtors = debtors;
            _navigation = navigation;
            CloseButtonCommand = new RelayCommand(OnCloseButtonClicked);
            SaveButtonCommand  = new RelayCommand(OnSaveButtonClicked);
        }
        public RelayCommand CloseButtonCommand { get; set; }
        public RelayCommand SaveButtonCommand { get; set; }
        private void OnSaveButtonClicked()
        {
            if(_newDebtor!="")
                Debtors.Add(new Debtor(_newDebt,_newDebtor));
        }
        private void OnCloseButtonClicked()
        {
            _navigation.debtorWindow.Close();
        }
    }


}
