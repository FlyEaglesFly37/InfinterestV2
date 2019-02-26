using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infinterest.Models
{
   public class User : BaseEntity
    {   
        public int UserId {get; set;}
        public string UserType {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact {get; set;}
        public string Bio {get; set;}
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Broker Broker {get; set;}
        public virtual Vendor Vendor {get; set;}
        public List<Message> Messages {get; set;}
        public List<MessageGroupUser> MessageGroupUsers {get; set;}

        public User()
        {
            MessageGroupUsers = new List<MessageGroupUser>();
            Messages = new List<Message>();
        }
    }   
}