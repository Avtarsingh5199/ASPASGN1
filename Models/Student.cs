using System;
using System.Collections.Generic;

namespace REGSTR.Models
{
    public partial class Student
    {
        public Student()
        {
            Courses = new HashSet<Courses>();
        }

        public string Name { get; set; }
        public string StudentId { get; set; }
        public byte Grade { get; set; }
        public byte? Age { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}
