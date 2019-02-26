using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infinterest.Models
{
   public class Message : BaseEntity
    {   
        public int MessageId {get; set;}
        public string Content {get; set;}
        //UserId is Sender
        public int UserId {get; set;}
        public User User {get; set;}
        public int MessageGroupId {get; set;}
        public MessageGroup MessageGroup {get; set;}

    }   
}