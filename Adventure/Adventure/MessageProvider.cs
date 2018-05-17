using System;
using System.Collections.ObjectModel;
using Adventure.UI.Messenger.ViewModel;

namespace Adventure
{
    public static class MessageProvider
    {
        static MessageProvider()
        {
            Messages = new ObservableCollection<GroupedMessageViewModel>()
            {
                new GroupedMessageViewModel()
                {
                    Author = "Mike",
                    Origin = MessageOrigin.From,
                    ProfileImageUri = new Uri("https://us.v-cdn.net/5019960/uploads/userpics/228/nQGB4IS0EHV5R.jpg"),
                },
                new GroupedMessageViewModel()
                {
                    Author = "Xydion",
                    Origin = MessageOrigin.To,
                    ProfileImageUri = new Uri("http://image.jeuxvideo.com/avatar-md/default.jpg"),
                }
            };

            Messages[0].Add(new MessageViewModel()
            {
                Date = DateTime.Now,
                Message = "Bonjour Xydion",
                Origin = MessageOrigin.From
            });
            Messages[0].Add(new MessageViewModel()
            {
                Date = DateTime.Now,
                Message = "Comment ça va ?",
                Origin = MessageOrigin.From
            });

            Messages[1].Add(new MessageViewModel()
            {
                Date = DateTime.Now,
                Message = "Salut Mike !",
                Origin = MessageOrigin.To
            });
            Messages[1].Add(new MessageViewModel()
            {
                Date = DateTime.Now,
                Message = "Bien et toi ?",
                Origin = MessageOrigin.To
            });
        }

        public static ObservableCollection<GroupedMessageViewModel> Messages { get; }
    }
}
