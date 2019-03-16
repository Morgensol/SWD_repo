using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DebtorBook.Model;

namespace DebtorBook.ViewModel
{
    public class DebtorHistoryViewModel
    {
        private Navigation _navigation;
        private Debtor _debtor;
        private int _localValue;
        public string LocalValue
        {
            get => Convert.ToString(_localValue);
            set
            {
                if (!(int.TryParse(value, out _localValue)))
                {
                    MessageBoxResult s = MessageBox.Show("Not a valid number");
                }
            }
        }
        public DebtorHistoryViewModel(Debtor debtor, Navigation navigation)
        {
            _navigation = navigation;
            SelectedDebtor = debtor;
            AddValueButtonCommand = new RelayCommand(OnAddValueButtonClicked);
            CloseButtonCommand = new RelayCommand(OnCloseButtonClicked);

        }
        
        public Debtor SelectedDebtor
        {
            get => _debtor;
            set
            {
                if (_debtor == value) return;
                _debtor = value;
            }
        }

        public RelayCommand AddValueButtonCommand { get; set; }
        public RelayCommand CloseButtonCommand { get; set; }
        private void OnAddValueButtonClicked()
        {
            if (_localValue == 0) return;
            SelectedDebtor.Debt = _localValue;
            
        }

        private void OnCloseButtonClicked()
        { 
            _navigation.historyWindow.Close();
        }
    }
}
