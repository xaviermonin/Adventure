using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Adventure.Data.Model
{
    public class Conversation
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The choices that lead to this conversation
        /// </summary>
        [InverseProperty(nameof(Choice.NextConversation))]
        public virtual ICollection<Choice> FromChoices { get; set; }

        /// <summary>
        /// The choices that can be made in this conversation
        /// </summary>
        [InverseProperty(nameof(Choice.ParentConversation))]
        public virtual ICollection<Choice> AllowedChoices { get; set; }

        /// <summary>
        /// The messages for this conversation
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; }
    }
}
