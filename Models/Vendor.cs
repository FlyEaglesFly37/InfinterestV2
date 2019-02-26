using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
public class Vendor : User
    {   
        public string AreaOfHouse {get; set;}
        public string BusinessCategory {get; set;}
        public List<Event> PendingEvents {get; set;}
        public List<Event> ConfimedEvents {get; set;}

        public Vendor()
        {
            PendingEvents = new List<Event>();
            ConfimedEvents = new List<Event>();
        }
        

    }   
}