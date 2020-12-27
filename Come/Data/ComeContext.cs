using Come.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Come.Data
{
    public class ComeContext : DbContext
    {

        public ComeContext(DbContextOptions<ComeContext> options)
           : base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
