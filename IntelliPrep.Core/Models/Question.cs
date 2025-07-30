
using System.Collections.Generic;

namespace IntelliPrep.Core.Models

{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<string> Options { get; set; } = new List<string>(); 
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}