using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adventure.Data.Model
{
    public class Choice
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        /// <summary>
        /// The next <see cref="Conversation"/> given by this choice
        /// </summary>
        public Conversation NextConversation { get; set; }

        /// <summary>
        /// The <see cref="Conversation"/> of this choice
        /// </summary>
        public Conversation ParentConversation { get; set; }
    }
}
