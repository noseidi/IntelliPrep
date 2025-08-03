using System.Collections.Generic;

namespace IntelliPrep.Core.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
            public ICollection<Test> Tests { get; set; }
    }
}