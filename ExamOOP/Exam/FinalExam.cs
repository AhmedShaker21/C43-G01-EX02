using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamOOP.Question;

namespace ExamOOP.Exam
{
    class FinalExam : Exam
    {
        public FinalExam(int ExamTime, int NumberOfQuestions) : base(ExamTime, NumberOfQuestions)
        {
        }
        public override void ExamResult(TimeSpan ExamTime)
        {
            Console.WriteLine("Final Exam");
            ProcessExam();
            Console.Clear();
            Console.WriteLine("Final Exam Results:");
            foreach (var (Question, IdOfStudent) in StudentAnswer)
            {
                Question.DisplayQuestionDetails();
                Console.WriteLine($"Your Answer => {Question.AnswerList[IdOfStudent - 1].AnswerText}");
                Console.WriteLine($"Correct Answer => {Question.AnswerList[Question.CorrectAnswerId - 1].AnswerText}\n");
            }

            Console.WriteLine($"Your Grade is {Grade} from {Question.Count * Question[0].QuestionMark}");
            Console.WriteLine($"Time = {ExamTime}");
            Console.WriteLine("Thank you");
        }
    }
}
