using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using Coins.server.Service;

namespace blood_donations.Servies
{
    public class PatientService : IPatientService
    {
        readonly IRepository<Patient> _patientRepository;

        public PatientService(IRepository<Patient> repository)
        {
            _patientRepository = repository;
        }
        public bool DeleteServies(int id)
        {
            return _patientRepository.DeleteServies(id);
        }

        public Patient GetByIdService(int id)
        {
            return _patientRepository.GetByIdService(id);
        }

        public List<Patient> GetServies()
        {
            return _patientRepository.GetServies();
        }

        public bool PostServies(Patient d)
        {
            TzValid tzValid = new TzValid();
            ErrorTZ errorTZ;
            if (tzValid.ISOK(d.IdPatient, out errorTZ))
            {
                return _patientRepository.PostServies(d);
            }
            return false;
        }

        public bool PutServies(int id, Patient d)
        {
            return _patientRepository.PutServies(id, d);
        }
    }
}