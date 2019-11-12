using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_II.Models
{
    public class FriendWith
    {
        public int Id { get; set; }
        public int FirstPerson { get; set; }
        public int SecondPerson { get; set; }
        public DateTime Friendaversary { get; set; }
    }
}