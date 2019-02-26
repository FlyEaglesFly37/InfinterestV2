using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
   public class VendorListing
    { 
        public int VendorListingId {get; set;}
        
        public int UserId {get; set;}
        public User User {get; set;}
        public int ListingId {get; set;}
        public Listing Listing {get; set;}
        public int VendorId {get; set;}
        public Vendor Vendor {get; set;}
    }   
}