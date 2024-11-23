namespace blood_donations.Entities
{
    public enum EmployeeRank { Manager, Regular }
    public class Employee
    {
        private static int id = 1;
        public int Id { get; private set; }
        public string FirstNameEmployee { get; set; }
        public string LastNameEmployee { get; set; }

        public string EmailEmployee { get; set; }
        public string EmployeeId { get; set; }

        public DateOnly BirthDate { get; set; }

        public EmployeeRank employeeRank { get; set; }

        public DateOnly DateOfBegin { get; set; }
        public Employee()
        {
            Id=id++;
        }
    }
}
