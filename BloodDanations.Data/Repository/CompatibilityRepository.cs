using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;

using System.Drawing;

namespace blood_donations.Servies
{
    public class CompatibilityCheckRepository: ICompatibilityCheckRepository
    {
        readonly DataContext<CompatibilityCheck> _dataContext;
        public CompatibilityCheckRepository(DataContext<CompatibilityCheck> dataContext)
        {
            _dataContext = dataContext;
        }

        public List<CompatibilityCheck> GetServies()
        {
            return _dataContext.data;
        }
        public CompatibilityCheck GetByIdService(int id)
        {
            return _dataContext.data.FirstOrDefault(c => c.Id == id);

        }
        public bool PostServies(CompatibilityCheck c)
        {
            _dataContext.data.Add(c);
            return true;
        }
        public bool PutServies(int id, CompatibilityCheck check)
        {
            foreach (CompatibilityCheck c in _dataContext.data)
            {
                if (c.Id == id)
                {

                    c.IdPatient = check.IdPatient;
                    c.IdBloodeDose = check.IdBloodeDose;
                    c.DateCheck = check.DateCheck;
                    c.NumNeedDose = check.NumNeedDose;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteServies(int id)
        {
            return _dataContext.data.Remove(_dataContext.data.FirstOrDefault(c => c.Id == id));
        }

        
    }
}
