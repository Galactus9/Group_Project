namespace Group_Project.Models
{
	public class CandidateExamQuestions
	{
		public int Id { get; set; }
		public ExamQuestions ExamQuestion { get; set; }
		public int ExamAnswer { get; set; }
		public CandidateExam CandidateExam { get; set; }
	}
}
