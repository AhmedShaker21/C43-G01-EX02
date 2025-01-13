using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamOOP.Question;
namespace ExamOOP.Exam
{
    public abstract class Exam
    {
        #region Automatic Properties
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public int Grade { get; set; }
        public List<Question.Question> Question { get; set; } = new List<Question.Question>();

        public List<(Question.Question, int)> StudentAnswer { get; set; } = new List<(Question.Question, int)>();

        #endregion
        #region Constructor
        public Exam(int ExamTime, int NumberOfQuestions)
        {
            this.ExamTime = ExamTime;
            this.NumberOfQuestions = NumberOfQuestions;
        }
        #endregion

        protected void ProcessExam()
        {
            int StudentId;
            bool Flag;
            foreach (var Question in Question)
            {
                Question.DisplayQuestionDetails();
                do
                {
                    Console.WriteLine("Enter your answer ID:");
                    Flag = int.TryParse(Console.ReadLine(), out StudentId);
                    if (Flag && StudentId > 0 && StudentId <= Question.AnswerList.Count)
                        Flag = true;
                    else
                    {
                        Console.WriteLine("Invalid Answer ID. Please Enter a Valid Answer Id within the Available O3ptions. ");
                        Flag = false;
                    }

                } while (!Flag);
                StudentAnswer.Add((Question, StudentId));
                if (StudentId == Question.CorrectAnswerId)
                    Grade += Question.QuestionMark;
            }
        }
        #region Abstract Function
        public abstract void ExamResult(TimeSpan ExamTime);

        #endregion

    }
}
