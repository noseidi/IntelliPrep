using System;
using System.Collections.Generic;
using System.Text;

namespace IntelliPrep.Core.Models
{
  public  class Test
    {
        public int Id { get; set; }
         public string Name { get; set; }

    public int TopicId { get; set; }
    public Topic Topic { get; set; }

    public ICollection<Question> Questions { get; set; }
    }
}
