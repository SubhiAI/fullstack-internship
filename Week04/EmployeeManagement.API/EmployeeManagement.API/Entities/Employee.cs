using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.API.Entities
{
        public class Employee
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column ("Emp_ID")] public int Id { get; set; }
           [Column ("Emp_Name")] public string Name { get; set; }
           [Column ("Email")] public string Email { get; set; }
           [Column("Department_ID")] public int? DepartmentId { get; set; }
           [Column("Dep_Name")] public string? DepartmentName { get; set; }
           [Column("JobPosition_ID")] public int? JobPositionID { get; set; }
           [Column("Title")] public string? JobPositionTitle { get; set; }
    }
    }
