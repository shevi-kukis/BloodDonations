using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace BloodDanations.Data.Repository
{
    public class PatientRepository : EmployeeRepository<Patient>, IPatientRepository
    {
        
        public PatientRepository(DataContext context) : base(context)
        {
           
        }
        public IEnumerable<Patient> GetFull()
        {
            return _dbSet.Include(u => u.employee);
        }
    }
}