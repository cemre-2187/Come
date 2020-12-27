using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Come.Models
{
    public class QuestionAnswer
    {
        public Question Question { get; set; }
        public List<Answer> Answers { get; set; }
        public List<Question> Questions { get; set; }
        public Answer Answers1 { get; set; }
        public List<Comment> Comments { get; set; }
        public Comment Comment1 { get; set; }
        public IdentityUser User { get; set; }
    }
}