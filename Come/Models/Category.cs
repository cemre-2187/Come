using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Come.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Question> Questions { get; set; }
    }
}
