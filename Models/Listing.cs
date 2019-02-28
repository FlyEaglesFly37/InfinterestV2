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
        public string MLSNumber {get; set;}
        public string MLSLink {get; set;}
        public string AreaOfHouseToFeature {get; set;}
        public int Price {get; set;}
        public int Zip {get; set;}
        public string ImgUrl { get; set; }

        public int BrokerId {get; set;}
        public Broker Broker {get; set;}

        public List<Event> Events {get; set;}
        
        

    }   
}