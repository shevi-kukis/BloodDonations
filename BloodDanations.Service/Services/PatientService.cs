using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using Coins.server.Service;

namespace blood_donations.Servies
{
    public class PatientService : IPatientService
    {
        readonly IRepository<Patient> _patientRepository;
        readonly IRepositoryManager _donorManager;

        public PatientService(IRepository<Patient> repository, IRepositoryManager donorManager)
        {
            _patientRepository = repository;
            _donorManager = donorManager;
        }
        public bool DeleteServies(int id)
        {
            if (_patientRepository.DeleteServies(id))
            {
                _donorManager.Save();
                return true;
            }
            return false;
        }

        public Patient GetByIdService(int id)
        {
            return _patientRepository.GetByIdService(id);
        }

        public List<Patient> GetServies()
        {
            return _patientRepository.GetServies();
        }

        public Patient PostServies(Patient d)
        {
            TzValid tzValid = new TzValid();
            ErrorTZ errorTZ;
            if (tzValid.ISOK(d.IdPatient, out errorTZ))
            {
               Patient p=  _patientRepository.PostServies(d);
                _donorManager.Save();
                return p;
            }
            return null;
        }

        public Patient PutServies(int id, Patient d)
        {
            Patient p=  _patientRepository.PutServies(id, d);
            _donorManager.Save();
            return p;
        }
    }
}