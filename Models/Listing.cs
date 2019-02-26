using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
    public class Listing : BaseEntity
    {   
        public int ListingId {get; set;}
        public string MLSLink {get; set;}
        public DateTime OpenHouseDate {get; set;}
        public string AreaOfHouseToFeature {get; set;}
        public int Price {get; set;}
        public int Zip {get; set;}
        public int BrokerId {get; set;}
        public Broker Broker {get; set;}

        public List<VendorReview> VendorReviews {get; set;}
        public List<BrokerReview> BrokerReviews {get; set;}
        public List<VendorListing> Vendors {get; set;}

        public Listing()
        {
            VendorReviews = new List<VendorReview>();
            BrokerReviews = new List<BrokerReview>();
            Vendors = new List<VendorListing>();
        }
        

    }   
}