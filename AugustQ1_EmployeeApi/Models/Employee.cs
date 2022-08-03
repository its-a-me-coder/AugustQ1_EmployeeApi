namespace AugustQ1_EmployeeApi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } =  string.Empty ;

        public string Designation { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;

        public string Email     { get; set; } = string.Empty;
         public Department Department { get; set; }
        public int DepartmentId {get; set; }
    }
}
