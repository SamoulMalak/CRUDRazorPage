namespace Lab9.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual HashSet<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
