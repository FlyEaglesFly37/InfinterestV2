using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
    public class Event : BaseEntity
    {   
        public int ListingID {get; set;}
        public DateTime OpenHouseDate {get; set;}
        public List<Vendor> PendingVendors {get; set;}
        public List<Vendor> ConfimedVendors {get; set;}

        public Event()
        {
            PendingVendors = new List<Vendor>();
            ConfimedVendors = new List<Vendor>();
        }
    }
}