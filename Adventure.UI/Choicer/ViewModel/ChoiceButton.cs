using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.UI.Choicer.ModelView
{
    public class ChoiceButton
    {
        public string Text { get; set; }
        public EventHandler Clicked { get; set; }
    }
}
