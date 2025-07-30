using System;
using System.Collections.Generic;
using System.Text;

namespace IntelliPrep.Core.Models
{
  public  class Test
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public List<Question> Questions { get; set; }
    }
}
