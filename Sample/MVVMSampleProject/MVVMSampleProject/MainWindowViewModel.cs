using System.ComponentModel;

namespace MVVMSampleProject
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly Navigation _navigation;

        private string _title = nameof(Title);

        public MainWindowViewModel(Navigation navigation)
        {
            _navigation = navigation;
            ChangeTitleCommand = new RelayCommand(OnChangeTitle);
        }

        private void OnChangeTitle()
        {
            Title = "Changed Title";
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { }; // Delegate makes sure it is not at any point
        public RelayCommand ChangeTitleCommand { get; private set; }

        public string Title
        {
            get => _title;
            set
            {
                if(_title == value) return;
                _title = value;
                ChangeTitleCommand.RaiseCanExecuteChanged();
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }
    }
}