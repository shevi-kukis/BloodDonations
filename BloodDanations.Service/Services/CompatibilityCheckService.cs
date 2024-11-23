using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;

using System.Drawing;

namespace blood_donations.Servies
{
    public class CompatibilityCheckServies:ICompatibilityCheckService
    {
        readonly ICompatibilityCheckRepository _CompatibilityCheckRepository;

        public CompatibilityCheckServies(ICompatibilityCheckRepository repository)
        {
            _CompatibilityCheckRepository = repository;
        }
        public bool DeleteServies(int id)
        {
            return _CompatibilityCheckRepository.DeleteServies(id);
        }

        public CompatibilityCheck GetByIdService(int id)
        {
            return _CompatibilityCheckRepository.GetByIdService(id);
        }

        public List<CompatibilityCheck> GetServies()
        {
            return _CompatibilityCheckRepository.GetServies();
        }

        public bool PostServies(CompatibilityCheck d)
        {
            return _CompatibilityCheckRepository.PostServies(d);

            return true;
        }

        public bool PutServies(int id, CompatibilityCheck d)
        {
            return _CompatibilityCheckRepository.PutServies(id, d);
        }
    }
}
