using Adventure.UI.Messenger.Template;
using System;
using Adventure.UI.Messenger.ViewModel;
using Xamarin.Forms;

namespace Adventure.UI.Messenger.Logic
{
    class MessageDataTemplateSelector : DataTemplateSelector
    {
        private DataTemplate fromMessageTemplate = new DataTemplate(typeof(FromMessageTemplate));
        private DataTemplate toMessageTemplate = new DataTemplate(typeof(ToMessageTemplate));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (!(item is MessageViewModel message))
                throw new ArgumentException("Not a message");

            if (message.Origin == MessageOrigin.From)
                return fromMessageTemplate;
            else
                return toMessageTemplate;
        }
    }
}
