﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH_LTWebLab04_05_06.Models;

namespace TH_LTWebLab04_05_06.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}