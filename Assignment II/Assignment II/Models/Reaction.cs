using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        public int ReactionType { get; set; }
    }
}