using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP.Exam
{
    class Exam
    {
        #region Automatic Properties
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }

        #endregion
        #region Constructor
        public Exam(int ExamTime, int NumberOfQuestions)
        {
            this.ExamTime = ExamTime;
            this.NumberOfQuestions = NumberOfQuestions;

        } 
        #endregion

    }
}
