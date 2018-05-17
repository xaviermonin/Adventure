using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adventure.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessengerView
    {
		public MessengerView ()
		{
			InitializeComponent();
		}

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            
            GoToLastElement();
        }

        public void GoToLastElement()
        {
            var v = ItemsSource.Cast<object>().LastOrDefault();
            ScrollTo(v, ScrollToPosition.Start, false);
        }

        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
            
            ScrollTo(child, ScrollToPosition.Start, true);
        }
    }
}
