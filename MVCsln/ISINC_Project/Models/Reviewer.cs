using System.ComponentModel.DataAnnotations;

namespace ISINC_Project.Models
{
    public class Reviewer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}