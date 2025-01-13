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
        //i change access modifier to Protected Bec when inherit it inherited as Private
        protected string QuestionHeader { get; set; }
        protected string QuestionBody { get; set; }
        protected int QuestionMark { get; set; }
        public List<Answer> AnswerList { get; set; } = new List<Answer>();
        #endregion

        #region Constructor
        public Question(string QuestionHeader, string QuestionBody, int QuestionMark)
        {
            this.QuestionHeader = QuestionHeader;
            this.QuestionBody = QuestionBody;
            this.QuestionMark = QuestionMark;
        }
        #endregion

        #region Abstract Question Function
        public abstract void DisplayQuestionDetails(); 
        #endregion

        public override string ToString()
            => $"The Question Header: {QuestionHeader}\nThe Question Body: {QuestionBody}\nThe Question Mark {QuestionMark}";
    }
}
