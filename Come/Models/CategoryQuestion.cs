using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Come.Models
{
    public class CategoryQuestion
    {
        public Category Categories { get; set; }
        public List<Question> Questions { get; set; }
    }
}
