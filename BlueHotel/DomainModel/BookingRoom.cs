﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class BookingRoom
    {
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
       
        public int RoomId { get; set; }
        public Room Rooms { get; set; }
    }
}
