using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment_II.Models
{
    public class Comments
    {
        public int Id { get; set; }
        
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        
        public int ParentCommentId { get; set; }
        public DateTime DatePosted { get; set; }

        [ForeignKey("PostedBy")]
        public Person Person { get; set; }
        
        public List<Comments> Commentses { get; set; }
    }
}