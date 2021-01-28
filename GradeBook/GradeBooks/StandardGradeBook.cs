using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            this.Name = name;
            Type = Enums.GradeBookType.Standard;
            this.IsWeighted = IsWeighted;
        }
    }
}
