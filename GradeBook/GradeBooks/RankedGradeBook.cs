using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
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
    }
}