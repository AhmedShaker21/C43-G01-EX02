using ExamOOP.Exam;
using ExamOOP.Question;
using System.Diagnostics;

namespace ExamOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////    Initialize Questions test    /////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Initialize Question test
            Console.WriteLine("Enter the type of exam (1 for Practical, 2 for Final):");
            int ExamType;
            while (!int.TryParse(Console.ReadLine(), out ExamType) || (ExamType != 1 && ExamType != 2))
                Console.WriteLine("Invalid choice. Please enter 1 for Practical or 2 for Final:");

            Console.WriteLine("Please enter the time for the exam (30 to 180 minutes):");
            int ExamTime;
            while (!int.TryParse(Console.ReadLine(), out ExamTime) || ExamTime < 30 || ExamTime > 180)
                Console.WriteLine("Invalid time. Please enter a value between 30 and 180:");

            Console.WriteLine("Please enter the number of questions:");
            int NumberOfQuestions;
            while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions) || NumberOfQuestions <= 0)
                Console.WriteLine("Invalid number of questions. Please enter a positive integer:");

            Console.Clear();
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////    Details Of Question Input    /////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////
    
            #region Details Of Question Input 

            List<Question.Question> UserListQuestion = new List<Question.Question>();

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Enter details for question {i + 1}:");

                QuestionType QuestionType;

                if (ExamType == (int)ExamTypeEnum.Practical)
                {
                    Console.WriteLine("Practical exams allow only MCQ questions. Setting question type to MCQ.");
                    QuestionType = QuestionType.MCQ;
                }
                else
                {
                    Console.WriteLine("Choose question type: 1 for MCQ, 2 for True/False:");
                    while (!Enum.TryParse(Console.ReadLine(), out QuestionType) || !Enum.IsDefined(typeof(QuestionType), QuestionType))
                        Console.WriteLine("Invalid question type. Please enter 1 for MCQ or 2 for True/False:");
                }

                Console.Clear();
                string QuestionBody;
                do
                {
                    Console.WriteLine("Please enter the question body:");
                    QuestionBody = Console.ReadLine()!;

                    if (string.IsNullOrWhiteSpace(QuestionBody))
                        Console.WriteLine("Invalid input. The question body cannot be empty or whitespace only. Please try again.");

                } while (string.IsNullOrWhiteSpace(QuestionBody));
                 
                Console.WriteLine("Please enter the question mark:");
                int QuestionMark;
                while (!int.TryParse(Console.ReadLine(), out QuestionMark) || QuestionMark <= 0)
                    Console.WriteLine("Invalid mark. Please enter a positive integer:");

                if (QuestionType == QuestionType.MCQ)
                {
                    #region IF He Selects MCQ Question
                    var MCQQuestion = new MCQQuestion("MCQ Question", QuestionBody, QuestionMark);

                    #region Choices of Question:
                    Console.WriteLine("Choices of Question:");
                    for (int j = 0; j < 4; j++)
                    {
                        string MyChoice;
                        do
                        {
                            Console.WriteLine($"Please enter choice number {j + 1}:");
                            MyChoice = Console.ReadLine()!;

                            if (string.IsNullOrWhiteSpace(MyChoice))
                                Console.WriteLine("Invalid input. The choice cannot be empty or whitespace. Please try again");

                        } while (string.IsNullOrWhiteSpace(MyChoice));

                        MCQQuestion.AnswerList.Add(new Answer(j + 1, MyChoice));

                    }

                    #endregion

                    #region For enter the ID of the correct answer 

                    Console.WriteLine("Please enter the ID of the correct answer (1 to 4):");
                    int CorrectAnswerId;
                    while (!int.TryParse(Console.ReadLine(), out CorrectAnswerId) || CorrectAnswerId < 1 || CorrectAnswerId > 4)
                        Console.WriteLine("Invalid answer ID. Please enter a value between 1 and 4:");
                    MCQQuestion.CorrectAnswerId = CorrectAnswerId;

                    UserListQuestion.Add(MCQQuestion);
                    #endregion 
                    #endregion

                }
                else if (QuestionType == QuestionType.TrueFalse)
                {
                    #region If He Selects True Or False Questions
                    var TrueOrFalseQuestion = new TrueOrFalseQuestion("True/False Question", QuestionBody, QuestionMark);
                    TrueOrFalseQuestion.AnswerList.Add(new Answer(1, "True"));
                    TrueOrFalseQuestion.AnswerList.Add(new Answer(2, "False"));
                   
                    //To enter the ID of the correct answer
                    Console.WriteLine("Please enter the ID of the correct answer (1 for True, 2 for False):");
                    int CorrectAnswerId;
                    while (!int.TryParse(Console.ReadLine(), out CorrectAnswerId) || (CorrectAnswerId != 1 && CorrectAnswerId != 2))
                        Console.WriteLine("Invalid answer ID. Please enter 1 for True or 2 for False:");
                    TrueOrFalseQuestion.CorrectAnswerId = CorrectAnswerId;

                    UserListQuestion.Add(TrueOrFalseQuestion);
                    #endregion
                }
                Console.Clear();
            } 
            #endregion
        
        }
    }
}
