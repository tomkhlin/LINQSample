﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinSampleInWinForms
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int Credit { get; set; }
        public bool IsRequired { get; set; }
    }
}
