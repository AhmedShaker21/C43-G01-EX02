using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP.Question
{
    internal class MCQQuestion : Question
    {
        #region Constructor
        public MCQQuestion(string QuestionHeader, string QuestionBody, int QuestionMark) : base(QuestionHeader, QuestionBody, QuestionMark)
        { }
        #endregion

        #region Implemented Functions
        public override void DisplayQuestionDetails()
        {
            Console.WriteLine($"MCQ Question:\tMark {QuestionMark}");
            for (int i = 0; i < AnswerList.Count; i++)
                Console.WriteLine($"{i + 1}- {AnswerList[i].AnswerText}");
            
        }
        #endregion
    }
}
