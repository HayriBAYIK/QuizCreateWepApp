using QuizCreateWepApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreateWepApp.VM
{
    public class CreateExamVM
    {
        public List<WiredItem> drpTitles { get; set; }

        public string Title { get; set; }

        public List<WiredItem> Descriptions { get; set; }
        public string Description { get; set; }



        [Display(Name = "1st Question")]
        [Required(ErrorMessage = "1st Question field is required.")]
        public string Q1 { get; set; }

        [Display(Name = "Answer A")]
        [Required(ErrorMessage = "Question 1 Answer A field is required.")]
        public string answer1a { get; set; }

        [Display(Name = "Answer B")]
        [Required(ErrorMessage = "Question 1 Answer B field is required.")]
        public string answer1b { get; set; }

        [Display(Name = "Answer C")]
        [Required(ErrorMessage = "Question 1 Answer C field is required.")]
        public string answer1c { get; set; }

        [Display(Name = "Answer D")]
        [Required(ErrorMessage = "Question 1 Answer D field is required.")]
        public string answer1d { get; set; }



        [Display(Name = "2st Question")]
        [Required(ErrorMessage = "2st Question field is required.")]
        public string Q2 { get; set; }

        [Display(Name = "Answer A")]
        [Required(ErrorMessage = "Question 2 Answer A field is required.")]
        public string answer2a { get; set; }

        [Display(Name = "Answer B")]
        [Required(ErrorMessage = "Question 2 Answer B field is required.")]
        public string answer2b { get; set; }

        [Display(Name = "Answer C")]
        [Required(ErrorMessage = "Question 2 Answer C field is required.")]
        public string answer2c { get; set; }

        [Display(Name = "Answer D")]
        [Required(ErrorMessage = "Question 2 Answer D field is required.")]
        public string answer2d { get; set; }



        [Display(Name = "3st Question")]
        [Required(ErrorMessage = "3st Question field is required.")]
        public string Q3 { get; set; }

        [Display(Name = "Answer A")]
        [Required(ErrorMessage = "Question 3 Answer A field is required.")]
        public string answer3a { get; set; }

        [Display(Name = "Answer B")]
        [Required(ErrorMessage = "Question 3 Answer B field is required.")]
        public string answer3b { get; set; }

        [Display(Name = "Answer C")]
        [Required(ErrorMessage = "Question 3 Answer C field is required.")]
        public string answer3c { get; set; }

        [Display(Name = "Answer D")]
        [Required(ErrorMessage = "Question 3 Answer D field is required.")]
        public string answer3d { get; set; }



        [Display(Name = "4st Question")]
        [Required(ErrorMessage = "4st Question field is required.")]
        public string Q4 { get; set; }

        [Display(Name = "Answer A")]
        [Required(ErrorMessage = "Question 4 Answer A field is required.")]
        public string answer4a { get; set; }

        [Display(Name = "Answer B")]
        [Required(ErrorMessage = "Question 4 Answer B field is required.")]
        public string answer4b { get; set; }

        [Display(Name = "Answer C")]
        [Required(ErrorMessage = "Question 4 Answer C field is required.")]
        public string answer4c { get; set; }

        [Display(Name = "Answer D")]
        [Required(ErrorMessage = "Question 4 Answer D field is required.")]
        public string answer4d { get; set; }


        [Display(Name = "1st Question correct answer")]
        [Required(ErrorMessage = "Question 1 Correct Answer field is required.")]
        public string correctAnswerQ1 { get; set; }

        [Display(Name = "2st Question correct answer")]
        [Required(ErrorMessage = "Question 2 Correct Answer field is required.")]
        public string correctAnswerQ2 { get; set; }

        [Display(Name = "3st Question correct answer")]
        [Required(ErrorMessage = "Question 3 Correct Answer field is required.")]
        public string correctAnswerQ3 { get; set; }

        [Display(Name = "4st Question correct answer")]
        [Required(ErrorMessage = "Question 4 Correct Answer field is required.")]
        public string correctAnswerQ4 { get; set; }




    }
}
