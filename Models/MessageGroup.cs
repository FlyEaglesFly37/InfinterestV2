using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infinterest.Models
{
   public class MessageGroup
    {   
        public int MessageGroupId {get; set;}
        public List<Message> Messages {get; set;}
        public List<MessageGroupUser> MessageGroupUsers {get; set;}
        public MessageGroup()
        {
            MessageGroupUsers = new List<MessageGroupUser>();
            Messages = new List<Message>();
        }
    
    }   
}