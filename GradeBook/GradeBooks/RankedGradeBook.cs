using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            switch (averageGrade)
            {
                case var d when d >= 80.0 : return 'A';
                case var d when d >= 60.0 : return 'B';
                case var d when d >= 40.0 : return 'C';
                case var d when d >= 20.0 : return 'D';

                default: return 'F';
            }

        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                System.Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
            else if (Students.Count >= 5)
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                System.Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
            else if (Students.Count >=5)
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}