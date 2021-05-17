﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerModel.Interfaces;

namespace TrackerModel.TestModels
{
    public class TaskModel :ITestModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string RightAnswer { get; set; }
    }
}
