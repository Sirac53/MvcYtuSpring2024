using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("DepartmentId")]
        [Required(ErrorMessage = "Department is Required")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage ="Course Name is Required")]
        public string? Name { get; set; }

    }
}
