using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Evaluations
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string? JuryId { get; set; }
        public bool IsFinal { get; set; }
        public float Criteria1 { get; set; }
        public float Criteria2 { get; set; }
        public float Criteria3 { get; set; }

        [ForeignKey("ProjectId")]
        public Project? Project { get; set; }

        [ForeignKey("JuryId")]
        public IdentityUser? Jury { get; set; }


    }
}
