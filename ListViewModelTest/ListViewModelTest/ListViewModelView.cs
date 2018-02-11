using System.ComponentModel;

namespace ListViewModelTest
{
    public class ListViewModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
            }
        }

        public ListViewModelView(string title) 
        {
            Title = title;
        }
    }
}