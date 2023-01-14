using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Group_Project.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string TextOfQuestion { get; set; }       
        public virtual Topic Topics { get; set; }
        public virtual PosibleAnswers PosibleAnswers { get; set; }


		//test push
	}
}