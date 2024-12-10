using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;

using System.Drawing;

namespace blood_donations.Servies
{
    public class CompatibilityCheckRepository : IRepository<CompatibilityCheck>
    {
        readonly DataContext _dataContext;
        public CompatibilityCheckRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<CompatibilityCheck> GetServies()
        {
            return _dataContext.CompatibilityChecks.ToList();
        }
        public CompatibilityCheck GetByIdService(int id)
        {
            return _dataContext.CompatibilityChecks.FirstOrDefault(c => c.Id == id);

        }
        public bool PostServies(CompatibilityCheck c)
        {
            _dataContext.CompatibilityChecks.Add(c);
                return _dataContext.SaveChanges() > 0;
           
        }
        public bool PutServies(int id, CompatibilityCheck check)
        {
            foreach (CompatibilityCheck c in _dataContext.CompatibilityChecks)
            {
                if (c.Id == id)
                {

                    c.IdPatient = check.IdPatient;
                    c.IdBloodeDose = check.IdBloodeDose;
                   // c.DateCheck = check.DateCheck;
                    c.NumNeedDose = check.NumNeedDose;
                   
                }
            }
            return _dataContext.SaveChanges() > 0;

        }
        public bool DeleteServies(int id)
        {
            var donor = _dataContext.CompatibilityChecks.FirstOrDefault(e => e.Id == id);
            if (donor != null)
            {
                _dataContext.CompatibilityChecks.Remove(donor);
                return _dataContext.SaveChanges() > 0;
            }
            return false;
        }


    }
}
