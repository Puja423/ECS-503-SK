using System.ComponentModel.DataAnnotations;

namespace Assignment_II.Models
{
    public class ReactionType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string IconURL { get; set; }
    }
}