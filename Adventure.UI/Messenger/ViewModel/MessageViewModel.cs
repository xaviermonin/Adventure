using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Adventure.UI.Messenger.ViewModel
{
    public class MessageViewModel : INotifyPropertyChanged
    {
        private string _message;
        private DateTime _date;
        private MessageOrigin _origin;

        public string Message
        {
            get => _message;
            set
            {
                if (value == _message) return;
                _message = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                if (value.Equals(_date)) return;
                _date = value;
                OnPropertyChanged();
            }
        }

        public MessageOrigin Origin
        {
            get => _origin;
            set
            {
                if (value == _origin) return;
                _origin = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
