using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Adventure.UI.Messenger.Template;
using Adventure.UI.Messenger.ViewModel;
using Xamarin.Forms;

namespace Adventure.UI.Messenger.Logic
{
    class GroupedMessageDataTemplateSelector : DataTemplateSelector
    {
        private DataTemplate fromGroupedDataTemplate = new DataTemplate(typeof(FromGroupedMessageTemplate));
        private DataTemplate toGroupedDataTemplate = new DataTemplate(typeof(ToGroupedMessageTemplate));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (!(item is GroupedMessageViewModel groupedMessage))
                return fromGroupedDataTemplate;

            if (groupedMessage.Origin == MessageOrigin.From)
                return fromGroupedDataTemplate;
            else
                return toGroupedDataTemplate;
        }
    }
}
