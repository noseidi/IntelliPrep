
using System.Collections.Generic;

namespace IntelliPrep.Core.Models

{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<Option> Options { get; set; } = new List<Option>(); 
        public int TopicId { get; set; }
        public Topic Topics { get; set; }
    }
}