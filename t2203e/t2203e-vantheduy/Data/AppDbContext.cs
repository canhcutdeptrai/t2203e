using System;
using System.Collections.Generic;
using t2203e_vantheduy.Models;

namespace t2203e_vantheduy.Data
{
    public class AppDbContext
    {
		public AppDbContext()
		{
		}
        public DbSet<Student> Students { get; set; }
    }
}

