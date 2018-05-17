using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Vapolia.Lib.Ui;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adventure.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExpandableView : ContentView
    {
        private bool _isExpanded;

		public ExpandableView()
		{
			InitializeComponent();
		    InitializeGesture();

            CollapseExpandImage.Source = ImageSource.FromResource("Adventure.UI.Choicer.Resource.collapse.png");
		    IsExpanded = true;
		}

        private void InitializeGesture()
        {
            Gesture.SetSwipeTopCommand(MainStackLayout, new Command(() => IsExpanded = true));
            Gesture.SetSwipeBottomCommand(MainStackLayout, new Command(() => IsExpanded = false));
            Gesture.SetTapCommand(CollapseExpandImage, new Command(() => IsExpanded = !IsExpanded));
        }

        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                _isExpanded = value;
                ExpandOrCollapse();
            }
        }

        private void ExpandOrCollapse()
        {
            if (IsExpanded)
            {
                // Expand the content view

                ContentView.IsVisible = true;
                CollapseExpandImage.RotateTo(180);
            }
            else
            {
                // Collapse the content view

                ContentView.IsVisible = false;
                CollapseExpandImage.RotateTo(0);
            }
        }

        public virtual View ExpandableContent
	    {
	        get => ContentView.Content;
	        set
	        {
	            ContentView.Content = value;
                OnPropertyChanged(nameof(ExpandableContent));
	        }
	    }
    }
}