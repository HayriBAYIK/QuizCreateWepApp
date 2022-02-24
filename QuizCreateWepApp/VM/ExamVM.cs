using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreateWepApp.VM
{
    public class ExamVM
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "1) ")]
        public string Question1{ get; set; }
        [Display(Name = "A) ")]
        public string Answer1a { get; set; }
        [Display(Name = "B) ")]
        public string Answer1b { get; set; }
        [Display(Name = "C) ")]
        public string Answer1c { get; set; }
        [Display(Name = "D) ")]
        public string Answer1d { get; set; }
        public string CorrectAnswerQ1 { get; set; }

        [Display(Name = "2) ")]
        public string Question2 { get; set; }
        [Display(Name = "A) ")]
        public string Answer2a { get; set; }
        [Display(Name = "B) ")]
        public string Answer2b { get; set; }
        [Display(Name = "C) ")]
        public string Answer2c { get; set; }
        [Display(Name = "D) ")]
        public string Answer2d { get; set; }
        public string CorrectAnswerQ2 { get; set; }

        [Display(Name = "3) ")]
        public string Question3 { get; set; }
        [Display(Name = "A) ")]
        public string Answer3a { get; set; }
        [Display(Name = "B) ")]
        public string Answer3b { get; set; }
        [Display(Name = "C) ")]
        public string Answer3c { get; set; }
        [Display(Name = "D) ")]
        public string Answer3d { get; set; }
        public string CorrectAnswerQ3 { get; set; }

        
        [Display(Name = "4) ")]
        public string Question4 { get; set; }
        [Display(Name = "A) ")]
        public string Answer4a { get; set; }
        [Display(Name = "B) ")]
        public string Answer4b { get; set; }
        [Display(Name = "C) ")]
        public string Answer4c { get; set; }
        [Display(Name = "D) ")]
        public string Answer4d { get; set; }
        public string CorrectAnswerQ4 { get; set; }


    }
}
