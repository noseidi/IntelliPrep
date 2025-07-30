﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IntelliPrep.Core.Models
{
   public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } = "";
        public List<string> Options { get; set; } 
        public int CorrectOptionIndex { get; set; }
    }
}
