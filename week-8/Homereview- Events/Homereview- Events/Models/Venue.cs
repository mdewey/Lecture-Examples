﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homereview__Events.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<EventModel> Events { get; set; } = new HashSet<EventModel>();

    }
}