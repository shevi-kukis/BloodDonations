using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;
using Microsoft.EntityFrameworkCore;


namespace blood_donations.Servies
{
    public class BloodDoseRepository : EmployeeRepository<BloodDose>, IBloodDoseRepository
    {
        public BloodDoseRepository(DataContext context) : base(context)
        {
        }
        public IEnumerable<BloodDose> GetFull()
        {
            return _dbSet.Include(u => u.donor);
        }
    }
}
