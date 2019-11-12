﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment_II.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public List<FriendWith> FriendsWith { get; set; }
    }
}