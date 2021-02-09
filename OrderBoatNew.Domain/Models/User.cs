﻿using System;

namespace OrderBoatNew.Domain.Models
{
    public class User : DomainObject
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DatedJoined { get; set; }
    }
}