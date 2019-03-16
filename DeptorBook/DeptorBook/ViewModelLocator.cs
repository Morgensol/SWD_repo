using DebtorBook.ViewModel;
namespace DebtorBook
{
    public class ViewModelLocator
    {
        private readonly Navigation _navigation = new Navigation(); // Inject navigation into view models

        public MainWindowViewModel MainWindowViewModel => new MainWindowViewModel(_navigation);
    }
}
