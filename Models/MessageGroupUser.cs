using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infinterest.Models
{
   public class MessageGroupUser
    {   
        public int MessageGroupUserId {get; set;}
        public User User {get; set;}
        public int UserId {get; set;}
        public MessageGroup MessageGroup {get; set;}
        public int MessageGroupId {get; set;}
    
    }   
}