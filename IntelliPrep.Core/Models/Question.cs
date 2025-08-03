
using System.Collections.Generic;

namespace IntelliPrep.Core.Models

{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }

    public int TestId { get; set; }
    public Test Test { get; set; }
    }
}