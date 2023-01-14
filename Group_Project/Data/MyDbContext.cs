using Group_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Group_Project.Data
{
	public class MyDbContext : DbContext
	{

		public MyDbContext(DbContextOptions options): base(options)
		{

		}
		DbSet<Candidate> Candidate { get; set; }
		DbSet<CandidateCertificate> CandidateCertificate { get; set; }
		DbSet<CandidateExam> CandidateExam { get; set; }
		DbSet<Certificate> Certificate { get; set; }
		DbSet<ExamQuestions> ExamQuestions { get; set; }
		DbSet<Exams> Exams { get; set; }
		DbSet<ExamTopics> ExamTopics { get; set; }
		DbSet<PosibleAnswers> PosibleAnswers { get; set; }
		DbSet<Question> Question { get; set; }
		DbSet<Topic> Topic { get; set; }
		DbSet<CandidateExamQuestions> CandidateExamQuestions { get;set; }	
	}
}

