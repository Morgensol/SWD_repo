using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DebtorBook.Model;
using DebtorBook.ViewModel;

namespace DebtorBook.ViewModel
{
    public class MainWindowViewModel
    {
        private Navigation _navigation;
        private ObservableCollection<Debtor> _debtors;
        public ObservableCollection<Debtor> Debtors
        {
            get => _debtors;
            set
            {
                _debtors = value;
            }
        }
        private Debtor _selectedDebtor;

        public Debtor SelectedDebtor
        {
            get => _selectedDebtor;
            set
            {
                if (_selectedDebtor == value) return;
                _selectedDebtor = value;
                OnListItemClicked(_selectedDebtor);
            }

        }
        public RelayCommand AddButtonClickedCommand { get; private set; }
        public RelayCommand ListItemClickedCommand { get; private set; }
        public MainWindowViewModel(Navigation navigation)
        {
            Debtors = new ObservableCollection<Debtor>();
            _navigation = navigation;
            AddButtonClickedCommand = new RelayCommand(OnAddButtonClicked);
        }
        
        private void OnAddButtonClicked()
        {
            _navigation.Show(new AddDebtorViewModel(_navigation,Debtors));
        }

        private void OnListItemClicked(Debtor debtor)
        {
            _navigation.Show(new DebtorHistoryViewModel(debtor, _navigation));
        }
    }
}
