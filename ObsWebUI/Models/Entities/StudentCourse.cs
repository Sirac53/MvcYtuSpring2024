using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class StudentCourse
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("StudentId")]
        [Required(ErrorMessage = "This is Required")]
        public int StudentId { get; set; }

        [ForeignKey("CourseId")]
        [Required(ErrorMessage = "This is Required")]
        public int CourseId { get; set; }

        [Range(1999,2030)]
        [Required(ErrorMessage = "This is Required")]
        public int Year { get; set; }


        [Required(ErrorMessage = "This is Required")]
        public string? Semester { get; set; }



    }
}
