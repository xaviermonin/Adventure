using System.Collections.Generic;
using System.Linq;
using Adventure.UI.Choicer.ModelView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adventure.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoicerView : ExpandableView
    {
        private const int ColumnsNumber = 2;

        public ChoicerView()
        {
            InitializeComponent();

            for (var i = 0; i < ColumnsNumber; ++i)
                ChoiceGrid.ColumnDefinitions.Add(new ColumnDefinition());
        }

        public IEnumerable<ChoiceButton> ChoiceButtons { get; set; }

        public void FillChoiceButtons(IEnumerable<ChoiceButton> choiceButtons)
        {
            var choiceButtonArray = choiceButtons as ChoiceButton[] ?? choiceButtons.ToArray();

            var buttonsNumber = choiceButtonArray.Count();
            var rowsNumber = buttonsNumber / ColumnsNumber == 0 ? 1 : buttonsNumber / ColumnsNumber;

            ChoiceGrid.RowDefinitions.Clear();

            for (var i = 0; i < rowsNumber; ++i)
                ChoiceGrid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = 50
                });

            ChoiceGrid.Children.Clear();

            for (var i = 0; i < choiceButtonArray.Length; ++i)
            {
                var button = choiceButtonArray[i];

                var x = i % ColumnsNumber;
                var y = i / ColumnsNumber == 0 ? 0 : i / ColumnsNumber;

                var buttonUi = new Button
                {
                    Font = Font.SystemFontOfSize(NamedSize.Micro),
                    Text = button.Text
                };

                if (button.Clicked != null)
                    buttonUi.Clicked += button.Clicked;

                ChoiceGrid.Children.Add(buttonUi, x, y);
            }
        }
    }
}