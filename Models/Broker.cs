using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
   public class Broker : BaseEntity
    {   
        public int BrokerId {get; set;}
        public int AffiliateCode {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
        public List<VendorReview> VendorReviews {get; set;}
        public List<BrokerReview> BrokerReviews {get; set;}
        public List<Listing> Listings {get; set;}

        public Broker()
        {
            VendorReviews = new List<VendorReview>();
            BrokerReviews = new List<BrokerReview>();
            Listings = new List<Listing>();
        }
        

    }   
}