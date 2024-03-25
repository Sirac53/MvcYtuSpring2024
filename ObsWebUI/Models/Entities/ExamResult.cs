using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class ExamResult
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ExamId")]
        [Required(ErrorMessage = "This is Required")]
        public int ExamId { get; set; }

        [ForeignKey("StudentId")]
        [Required(ErrorMessage = "This is Required")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "This Required")]
        [Range(0,100,ErrorMessage ="The Value Should be between 0 to 100")]
        public double Grade { get; set; }

    }
}
