using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("DepartmentId")]
        [Required(ErrorMessage = "This is Required")]
        public int DepartmentId { get; set; }


        [Required(ErrorMessage = "This is Required")]
        public string? Name { get; set; }



    }
}
