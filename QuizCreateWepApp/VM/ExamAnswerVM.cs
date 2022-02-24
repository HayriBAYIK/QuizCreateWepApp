using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreateWepApp.VM
{
    public class ExamAnswerVM
    {
        public int Id { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }

        public int ResultAnswer1 { get; set; } = 0;
        public int ResultAnswer2 { get; set; } = 0;
        public int ResultAnswer3 { get; set; } = 0;
        public int ResultAnswer4 { get; set; } = 0;

        public string CorrectAnswer1 { get; set; }
        public string CorrectAnswer2 { get; set; }
        public string CorrectAnswer3 { get; set; }
        public string CorrectAnswer4 { get; set; }


    }
}
