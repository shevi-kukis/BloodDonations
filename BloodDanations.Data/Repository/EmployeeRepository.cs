using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;

namespace BloodDanations.Data.Repository
{
    public class EnployeeRepository : EmployeeRepository<Employee>, IEmployeeRepository
    {
        public EnployeeRepository(DataContext context) : base(context)
        {
        }
    }
}
