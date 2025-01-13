using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    class Question
    {
        /// Design a Class to represent the Question Object,
        #region Automatic Properties
        //By Default Properties Access Modifier Public
        string QuestionHeader { get; set; }
        string QuestionBody { get; set; }
        int QuestionMark { get; set; } 
        #endregion

        #region Constructor
        public Question(string QuestionHeader, string QuestionBody, int QuestionMark)
        {
            this.QuestionHeader = QuestionHeader;   
            this.QuestionBody = QuestionBody;
            this.QuestionMark = QuestionMark;
        }
        #endregion

        public override string ToString()
            => $"The Question Header: {QuestionHeader}\nThe Question Body: {QuestionBody}\nThe Question Mark {QuestionMark}";
    }
}
