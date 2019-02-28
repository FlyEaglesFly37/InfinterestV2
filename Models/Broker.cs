using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
public class Broker : User
    {
        public List<Listing> Listings {get; set;}
        public List<Event> Events {get; set;}
        

    }   
}