using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP.Question
{
    class TrueOrFalseQuestion:Question
    {
        #region Constructor
        public TrueOrFalseQuestion(string QuestionHeader, string QuestionBody, int QuestionMark) : base(QuestionHeader, QuestionBody, QuestionMark, QuestionType.TrueFalse)
        { } 
        #endregion

        #region Implemented Functions
        public override void DisplayQuestionDetails()
        {
            Console.WriteLine($"True | False Question:\tMark {QuestionMark}");
            Console.WriteLine($"{QuestionHeader}: {QuestionBody})");
            Console.WriteLine("1- True");
            Console.WriteLine("2- False");
        } 
        #endregion
    }
}
