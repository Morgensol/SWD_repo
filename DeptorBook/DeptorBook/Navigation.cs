using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DebtorBook.View;
using DebtorBook.View;

namespace DebtorBook
{
    public class Navigation
    {
        private const string AddDebtorViewModel     = "DebtorBook.ViewModel.AddDebtorViewModel";
        private const string DebtorHistoryViewModel = "DebtorBook.ViewModel.DebtorHistoryViewModel";
        public Window debtorWindow  = new AddDebtorWindow();
        public Window historyWindow = new DebtorHistoryWindow();
        public Navigation()
        {

        }

        public void Show(object viewModel)
        {
        
            switch (viewModel.GetType().FullName)
            {
                case AddDebtorViewModel:
                    debtorWindow = new AddDebtorWindow();
                    debtorWindow.DataContext = viewModel;
                    debtorWindow.Show();
                    break;
                case DebtorHistoryViewModel:
                    historyWindow = new DebtorHistoryWindow();
                    historyWindow.DataContext = viewModel;
                    historyWindow.Show();
                    historyWindow.Topmost = true;
                    break;
                default:
                    break;
            }
        }
    }
}
