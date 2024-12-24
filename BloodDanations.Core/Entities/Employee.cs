using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blood_donations.Entities
{
    public enum EmployeeRank { Manager, Regular }
    public class Employee
    {
        [Key]
        public int Id { get; private set; }
        public string FirstNameEmployee { get; set; }
        public string LastNameEmployee { get; set; }

        public string EmailEmployee { get; set; }
        public string Tz { get; set; }
       
       // public DateOnly BirthDate { get; set; }

        public EmployeeRank employeeRank { get; set; }

        // public DateOnly DateOfBegin { get; set; }
        public List<Patient> patients { get; set; }
    }
}
