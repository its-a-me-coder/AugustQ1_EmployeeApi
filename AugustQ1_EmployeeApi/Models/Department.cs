namespace AugustQ1_EmployeeApi.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } =String.Empty;

        public List<Employee> Employees { get; set; }

    }
}
