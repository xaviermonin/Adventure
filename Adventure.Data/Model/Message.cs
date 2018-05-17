using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Adventure.Data.Model
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Choice> RequiredChoices { get; set; }

        public Conversation ParentConversation { get; set; }
    }
}
