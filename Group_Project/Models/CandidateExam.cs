namespace Group_Project.Models
{
	public class CandidateExam
	{
		public int Id { get; set; }
		public Exams Exam { get; set; }
		public Candidate Candidate { get; set; }

	}
}
