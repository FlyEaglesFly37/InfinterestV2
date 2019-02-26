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
        public string ImgUrl { get; set; }
        public int AffiliateCode {get; set;}
        public string CustomID { get; set; }
        public string Company { get; set; }
        public string Website { get; set; }

        public User()
        {
            
        }
    }   
}