using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.API.DTOs
{
    public class AddEmployeeDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        public int? DepartmentId { get; set; }

        public int? JobPositionID { get; set; }
    }
}