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
            ////////////////////////////    Initialize Question test    //////////////////////////////////////////
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

        }
    }
}
