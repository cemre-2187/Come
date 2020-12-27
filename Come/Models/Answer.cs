using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Come.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
   
        public string AnswerBody { get; set; }
       
        public string AnswerDate { get; set; }
        public string User { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
