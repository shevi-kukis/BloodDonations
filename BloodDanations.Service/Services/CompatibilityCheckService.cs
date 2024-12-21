using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;

using System.Drawing;

namespace blood_donations.Servies
{
    public class CompatibilityCheckServies : ICompatibilityCheckService
    {
        readonly IRepository<CompatibilityCheck> _CompatibilityCheckRepository;
        readonly IRepositoryManager _donorManager;


        public CompatibilityCheckServies(IRepository<CompatibilityCheck> repository, IRepositoryManager donorManager)
        {
            _CompatibilityCheckRepository = repository;
            _donorManager = donorManager;
        }
        public bool DeleteServies(int id)
        {
            if (_CompatibilityCheckRepository.DeleteServies(id))
            {
                _donorManager.Save();
                return true;
            }
            return false;
        }

        public CompatibilityCheck GetByIdService(int id)
        {
            return _CompatibilityCheckRepository.GetByIdService(id);
        }

        public List<CompatibilityCheck> GetServies()
        {
            return _CompatibilityCheckRepository.GetServies();
        }

        public CompatibilityCheck PostServies(CompatibilityCheck d)
        {
            CompatibilityCheck c= _CompatibilityCheckRepository.PostServies(d);
            _donorManager.Save();
            return c;
        }

        public CompatibilityCheck PutServies(int id, CompatibilityCheck d)
        {
            CompatibilityCheck c= _CompatibilityCheckRepository.PutServies(id, d);
            _donorManager.Save();
            return c;
        }
    }
}
