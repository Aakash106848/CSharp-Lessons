using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCApp.Models
{
    public class CreateEmp
    {
        [Key]
        public int eno { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 characters")]
        public string name { get; set; } = string.Empty;
        [Required]
        public decimal salary {  get; set; }
        public string city { get; set; } = string.Empty;
    }
}
