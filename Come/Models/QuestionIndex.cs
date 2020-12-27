using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Come.Models
{
    public class QuestionIndex
    {
        public List<Question> Questions { get; set; }
        public List<Category> Categories { get; set; }
        public Question Question { get; set; }
        public Category Category { get; set; }
    }
}
