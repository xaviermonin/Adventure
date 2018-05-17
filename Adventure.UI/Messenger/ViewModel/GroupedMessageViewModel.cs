using Adventure.Helper;
using Xamarin.Forms;

namespace Adventure.UI.Messenger.ViewModel
{
    public enum MessageOrigin { From, To };

    public class GroupedMessageViewModel : ObservableCollectionWithItemNotify<MessageViewModel>
    {
        public MessageOrigin Origin { get; set; }
        public string Author { get; set; }
        public ImageSource ProfileImageUri { get; set; }
    }
}
