using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCEFApp.Models
{
    public class Appoinment
    {
        [Key]
        [Column("Appoinmentno")]
        public int Id { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public int DoctorId {  get; set; }
        [Required]
        public DateTime DateofAppoinment { get; set; }
        [Required]
        public bool Status { get; set; }    
    }
}
