﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Homereview__Events.Models
{
    public class Order
    {

        public int Id { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();

        [DisplayFormat(DataFormatString = "{0:C}")]
        [NotMapped]
        public double TotalPrice
        {
            get
            {
                if (Tickets == null)
                {
                    return 0;
                }
                return Tickets.Sum(s => s.PurchasedPrice);
            }
        }

    }
}