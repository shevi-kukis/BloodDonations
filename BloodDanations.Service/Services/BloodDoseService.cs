using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using Coins.server.Service;


namespace blood_donations.Servies
{
    public class BloodDoseService:IBloodDoseService
    {
        readonly IBloodDoseRepository _BloodDoseRepository;

        public BloodDoseService(IBloodDoseRepository repository)
        {
            _BloodDoseRepository = repository;
        }
        public bool DeleteServies(int id)
        {
            return _BloodDoseRepository.DeleteServies(id);
        }

        public BloodDose GetByIdService(int id)
        {
            return _BloodDoseRepository.GetByIdService(id);
        }

        public List<BloodDose> GetServies()
        {
            return _BloodDoseRepository.GetServies();
        }

        public bool PostServies(BloodDose d)
        {
                return _BloodDoseRepository.PostServies(d);

            return true;
        }

        public bool PutServies(int id, BloodDose d)
        {
            return _BloodDoseRepository.PutServies(id, d);
        }
    }
}
