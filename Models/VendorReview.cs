using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
   public class VendorReview : BaseEntity
    { 
        public int VendorReviewId {get; set;}
        public string Content {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
        public int BrokerId {get; set;}
        public Broker Broker {get; set;}
        public int VendorId {get; set;}
        public Vendor Vendor {get; set;}
    }   
}