using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Assignment_II.Models
{
    public class Reaction
    {
        public int Id { get; set; }
        
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        
        [ForeignKey("CommentId")]
        public Comments Comments { get; set; }
        
        [ForeignKey("ImageId")]
        public PostImages PostImages { get; set; }
        
        public DateTime ReactionDate { get; set; }
        
        [ForeignKey("ReactionTp")]
        public ReactionType ReactionType { get; set; }
    }
}