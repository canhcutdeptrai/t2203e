using System;
using System.ComponentModel.DataAnnotations;

namespace t2203e_vantheduy.Models
{
	public class Student
	{
		public Student()
        {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Course { get; set; }
    }
	}
}

