using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Come.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Body { get; set; }
        public string User { get; set; }  
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
