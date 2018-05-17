
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adventure.UI.Messenger.Template
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FromMessageWritingTemplate : ViewCell
	{
		public FromMessageWritingTemplate()
		{
			InitializeComponent ();

		    imgThreeDots.Source = ImageSource.FromResource("Adventure.UI.Messenger.Resource.animated-dot.gif");
		}
	}
}