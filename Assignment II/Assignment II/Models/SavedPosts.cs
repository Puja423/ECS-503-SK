using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment_II.Models
{
    public class SavedPosts
    {
        public int Id { get; set; }
        
        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}