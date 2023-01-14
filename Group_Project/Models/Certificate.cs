using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group_Project.Models
{
    public class Certificate

    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
        private int PossibleMarks { get; set; } // = Topics.Question.Count // Topic.SubjectWeight.Sum()

    }
}