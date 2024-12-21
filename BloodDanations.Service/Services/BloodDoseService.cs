using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using Coins.server.Service;


namespace blood_donations.Servies
{
    public class BloodDoseService : IBloodDoseService
    {
        readonly IRepository<BloodDose> _BloodDoseRepository;
        readonly IRepositoryManager _donorManager;

        public BloodDoseService(IRepository<BloodDose> repository, IRepositoryManager donorManager)
        {
            _BloodDoseRepository = repository;
            _donorManager = donorManager;
        }
        public bool DeleteServies(int id)
        {
            if (_BloodDoseRepository.DeleteServies(id))
            {
                _donorManager.Save();
                return true;
            }
            return false;

        }

        public BloodDose GetByIdService(int id)
        {
            return _BloodDoseRepository.GetByIdService(id);
        }

        public List<BloodDose> GetServies()
        {
            return _BloodDoseRepository.GetServies();
        }

        public BloodDose PostServies(BloodDose d)
        {
            BloodDose donor = _BloodDoseRepository.PostServies(d);
            _donorManager.Save();
            return donor;
        }

        public BloodDose PutServies(int id, BloodDose d)
        {
            BloodDose b= _BloodDoseRepository.PutServies(id, d);
            _donorManager.Save();
            return b;
        }
    }
}
