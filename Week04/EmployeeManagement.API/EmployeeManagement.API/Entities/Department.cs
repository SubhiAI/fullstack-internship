using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.API.Entities
{
    public class Department
    {
        [Key]
        public int DepID { get; set; }

        public string? Dep_Name { get; set; }

    }
}
