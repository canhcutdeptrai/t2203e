using System;
namespace t2203e_vantheduy
{
	public class ProjectEmployee
	{
		public ProjectEmployee()
		{

        public int EmployeeId { get; set; } // Id nhân viên

        public int ProjectId { get; set; } // Id dự án

        public string Tasks { get; set; } // Nhiệm vụ trong dự án

        public virtual Employee Employees { get; set; } // Nhân viên

        public virtual Project Projects { get; set; } // Dự án
    }
	}
}

