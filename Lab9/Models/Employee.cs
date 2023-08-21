using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab9.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        
        public string? Email { get; set; }
        public string Phone { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = new();
    }
}
