using Adventure.UI.Choicer.ModelView;
using System.Threading.Tasks;
using Adventure.UI.Messenger.ViewModel;
using Xamarin.Forms;

namespace Adventure
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    protected override async void OnAppearing()
	    {
	        Choicer.FillChoiceButtons(new ChoiceButton[]
	        {
	            new ChoiceButton() { Text = "Au revoir !"},
	            new ChoiceButton() { Text = "Merci" },
	            new ChoiceButton() { Text = "Merci" },
	            new ChoiceButton() { Text = "Et si ce texte était long ?", Clicked = (sender, args) => DisplayAlert("Wow", "En effet il est très long", "OK")},
	        });

	        await Task.Delay(15000);

	        MessageProvider.Messages[0][0].Message = "<Message supprimé>";
	        var conversation = new GroupedMessageViewModel()
	        {
                Author = "Xydion",
                Origin = MessageOrigin.To,
	        };
            conversation.Add(new MessageViewModel()
	        {
                Origin = MessageOrigin.To,
                Message = "Ceci est un test très long !"
	        });
	        conversation.Add(new MessageViewModel()
	        {
	            Origin = MessageOrigin.To,
	            Message = "Ceci est un test très long !"
	        });
	        conversation.Add(new MessageViewModel()
	        {
	            Origin = MessageOrigin.To,
	            Message = "Ceci est un test très long !"
	        });
	        conversation.Add(new MessageViewModel()
	        {
	            Origin = MessageOrigin.To,
	            Message = "Ceci est un test très long !"
	        });
	        conversation.Add(new MessageViewModel()
	        {
	            Origin = MessageOrigin.To,
	            Message = "Ceci est un test très long !"
	        });

            MessageProvider.Messages.Add(conversation);
        }
	}
}
