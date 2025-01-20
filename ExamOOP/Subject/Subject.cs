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

        public Subject(int SubjectId, string SubjectName)
        {
            this.SubjectName = SubjectName;
            this.SubjectId = SubjectId;
        }

        public void CreateExam(Exam.Exam exam)
        {
            Exam = exam;
        }

        public object Clone()
            => new Subject(SubjectId, SubjectName) { Exam = Exam };

        public int CompareTo(Subject other)
            => SubjectName.CompareTo(other.SubjectName);

        public override string ToString()
            => $"Subject: {SubjectName}\nID: {SubjectId}";
    }
}