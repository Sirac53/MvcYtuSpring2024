using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }

       
        [Required(ErrorMessage = "This is Required")]
        public string? Name { get; set; }

        public string? DeanName { get; set; }


    }
}
