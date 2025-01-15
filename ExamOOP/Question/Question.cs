using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamOOP;
namespace ExamOOP.Question
{
    //I will make Class Abstract Bec i want MCQ and T/F Questions Implement and inherirt Display Func 
    public abstract class Question
    {
        /// Design a Class to represent the Question Object,
        #region Automatic Properties
        //By Default Properties Access Modifier Public 
        public string QuestionHeader { get; set; }
        public string QuestionBody { get; set; }
        public int QuestionMark { get; set; }
        public QuestionType Type { get; set; }
        public List<Answer> AnswerList { get; set; } = new List<Answer>();
        public int CorrectAnswerId { get; set; }

        #endregion

        #region Constructor
        public Question(string QuestionHeader, string QuestionBody, int QuestionMark, QuestionType Type)
        {
            this.QuestionHeader = QuestionHeader;
            this.QuestionBody = QuestionBody;
            this.QuestionMark = QuestionMark;
            this.Type = Type;
        }
        #endregion

        #region Abstract Question Function
        public abstract void DisplayQuestionDetails();
        #endregion

        public override string ToString()
            => $"{QuestionBody}";
    }
}
