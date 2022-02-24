using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreateWepApp.Entities
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        public int Id { get; set; }

  
        public string Title { get; set; }
        public string Description { get; set; }

        public string Question1 { get; set; }

        public string Question2 { get; set; }

        public string Question3 { get; set; }

        public string Question4 { get; set; }

        public string Answer1a { get; set; }

        public string Answer1b { get; set; }

        public string Answer1c { get; set; }

        public string Answer1d { get; set; }

        public string Answer2a { get; set; }

        public string Answer2b { get; set; }

        public string Answer2c { get; set; }

        public string Answer2d { get; set; }


        public string Answer3a { get; set; }

        public string Answer3b { get; set; }

        public string Answer3c { get; set; }

        public string Answer3d { get; set; }


        public string Answer4a { get; set; }

        public string Answer4b { get; set; }

        public string Answer4c { get; set; }

        public string Answer4d { get; set; }


        
        public string CorrectAnswerQ1 { get; set; }

        public string CorrectAnswerQ2 { get; set; }

        public string CorrectAnswerQ3 { get; set; }

        public string CorrectAnswerQ4 { get; set; }

        public string AddDate { get; set; } = DateTime.Now.ToString("dd.MM.yyyy");








    }
}
