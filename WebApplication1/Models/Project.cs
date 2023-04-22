
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    
    public class Project
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int AdvisorId { get; set; }
    }
}
