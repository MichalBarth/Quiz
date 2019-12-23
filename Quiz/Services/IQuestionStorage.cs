using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz.Models;

namespace Quiz.Services
{
    public interface IQuestionStorage
    {
        List<Question> Questions { get; set; }

        public Question PickQuestion()
        {
            Random r = new Random();
            int pickedOne = r.Next(0, Questions.Count());
            return Questions[pickedOne];
        }
    }
}
