using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz.Models;
using Quiz.Services;

namespace Quiz.Pages
{
    public class QuizModel : PageModel
    {
        private IQuestionStorage _q;

        public QuizModel(IQuestionStorage q)
        {
            _q = q;
        }

        public List<Question> Questions { get; set; }

        public void OnGet()
        {
            Questions = _q.Questions;
        }
    }
}