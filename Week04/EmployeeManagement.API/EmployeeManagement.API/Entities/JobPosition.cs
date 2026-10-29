using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.API.Entities
{
    public class JobPosition
    {
        [Key]
        public int JobID { get; set; }

        public string? Title { get; set; }

    }
}

