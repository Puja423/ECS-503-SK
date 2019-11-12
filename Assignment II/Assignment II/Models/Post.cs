using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment_II.Models
{
    public class Post
    {
        public int Id { get; set; }
        
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
        
        public string PostContent { get; set; }
        public DateTime PostDate { get; set; }
        
        [ForeignKey("_Location")]
        public Location Location { get; set; }
    }
}