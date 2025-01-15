using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP.Exam
{
    class PracticalExam : Exam
    {
        public PracticalExam(int ExamTime, int NumberOfQuestions) : base(ExamTime, NumberOfQuestions)
        {
        }
        public override void ExamResult(TimeSpan ExamTime)
        {
            Console.WriteLine("Practical Exam");
            ProcessExam();
            Console.Clear();
            Console.WriteLine("Practical Exam Results:");
            int QuestionNumber = 1;
            foreach (var (Question, IdOfStudent) in StudentAnswer)
            {
                Console.WriteLine($"Question {QuestionNumber}: {Question.QuestionBody}");

                Console.WriteLine($"Your Answer => {Question.AnswerList[IdOfStudent - 1].AnswerText}");
                Console.WriteLine($"Correct Answer => {Question.AnswerList[Question.CorrectAnswerId - 1].AnswerText}\n");
                QuestionNumber++;
            }

            Console.WriteLine($"Your Grade is {Grade} from {Question.Count * Question[0].QuestionMark}");
            Console.WriteLine($"Time = {ExamTime}");
            Console.WriteLine("Thank you");
        }
    }
}

