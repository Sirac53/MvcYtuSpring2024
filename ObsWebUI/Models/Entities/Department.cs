using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("FacultyId")]
        [Required(ErrorMessage = "Faculty is Required")]
        public int FacultyId { get; set; }

       
        [Required(ErrorMessage = "Name is Required")]
        public string? Name { get; set; }


    }
}
