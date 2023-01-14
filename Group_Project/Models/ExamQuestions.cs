using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group_Project.Models
{
	public class ExamQuestions
	{
		public int Id { get; set; }
		public ExamTopics ExamTopics { get; set; }
		public Question Question {get; set;}
		public int? CandidatesAnswer { get; set;}

	}
}