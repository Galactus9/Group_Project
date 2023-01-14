using System.ComponentModel.DataAnnotations.Schema;

namespace Group_Project.Models
{
	public class PosibleAnswers
	{
		public int Id { get; set; }


//		public Question Question { get; set; }
		public string Answer1 { get; set; }
		public string Answer2 { get; set; }
		public string Answer3 { get; set; }
		public string Answer4 { get; set; }
		public int Index { get; set; }
	}
}
