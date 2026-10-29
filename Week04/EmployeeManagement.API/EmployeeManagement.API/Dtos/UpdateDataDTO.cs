using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.API.Dtos
{
    public class UpdateDataDTO
    {
        [Column("Emp_Name")] public string Name { get; set; }
        [Column("Email")] public string Email { get; set; }
        [Column("Department_ID")] public int DepartmentId { get; set; }
        [Column("JobPosition_ID")] public int JobPositionID { get; set; }

    }
}
