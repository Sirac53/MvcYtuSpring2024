﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObsWebUI.Models.Entities
{
    public class Exam
    {

        [Key]
        public int Id { get; set; }



        [ForeignKey("CourseId")]
        [Required(ErrorMessage = "This is Required")]
        public int CourseId { get; set; }


        [Required(ErrorMessage = "This is Required")]
        public DateTime ExamDate { get; set; }



    }
}
