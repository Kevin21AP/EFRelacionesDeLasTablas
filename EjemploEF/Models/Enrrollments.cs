using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EjemploEF.Models
{
    public class Enrrollments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrrollmentId { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public Course Course { get; set; }   
        
        public Students Student { get; set; }
    }
}
