﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimetableApp.Business.DTO
{
    public class BellDTO
    {

        public int BellID { get; set; }
        public TimeSpan LessonStartTime { get; set; }
        public TimeSpan LessonEndTime { get; set; }
    }
}
