using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Come.Models
{
    public class AskQuestion
    {
        public Question Question { get; set; }
        public IdentityUser User { get; set; }
      
    }
}
