using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class Answer
    {
        #region Automatic Properties
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion

        #region Constructor
        public Answer(int AnswerId, string AnswerText)
        {
            this.AnswerId = AnswerId;
            this.AnswerText = AnswerText;
        }
        #endregion
    }
}
