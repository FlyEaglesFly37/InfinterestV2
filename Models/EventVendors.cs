using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
    public class EventVendors : BaseEntity
    {
        public int EventVendorsId {get;set;}
        public List<Vendor> PendingVendors {get; set;}
        public List<Vendor> ConfimedVendors {get; set;}
    }
}