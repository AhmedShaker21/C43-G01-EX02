using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP.Subject
{
    public class Subject : ICloneable, IComparable<Subject>
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam.Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam(Exam.Exam exam)
        {
            Exam = exam;
        }

        public object Clone()
        {
            return new Subject(SubjectId, SubjectName) { Exam = Exam };
        }

        public int CompareTo(Subject other)
        {
            return SubjectName.CompareTo(other.SubjectName);
        }

        public override string ToString()
        {
            return $"Subject: {SubjectName}, ID: {SubjectId}";
        }
    }
}
