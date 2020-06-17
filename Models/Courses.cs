using System;
using System.Collections.Generic;

namespace REGSTR.Models
{
    public partial class Courses
    {
        public string CourseName { get; set; }
        public string CourseId { get; set; }
        public string StudentId { get; set; }
        public decimal Fees { get; set; }

        public virtual Student Student { get; set; }
    }
}
