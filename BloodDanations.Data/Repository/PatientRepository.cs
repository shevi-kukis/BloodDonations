using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;


namespace blood_donations.Servies
{
    public class PatientRepository: IPatientRepository
    {
        readonly DataContext<Patient> _dataContext;
        public PatientRepository(DataContext<Patient> dataContext)
        {
            _dataContext = dataContext;
        }


        public List<Patient> GetServies()
        {
            return _dataContext.data;
        }
        public Patient GetByIdService(int id)
        {
            return _dataContext.data.FirstOrDefault(e => e.Id == id);
        }
        public bool PostServies(Patient e)
        {
            _dataContext.data.Add(e);
            return true;
        }
        public bool PutServies(int id,Patient patient)
        {
            foreach (Patient p in _dataContext.data)
            {
                if (p.Id == id)
                {
                   
                    //p.Origin = patient.Origin;
                    //p.sex = patient.sex;
                    p.IdPatient = patient.IdPatient;
                    //p.AddressPatient = patient.AddressPatient;
                    //p.BirthDate = patient.BirthDate;
                    p.LastNamePatient = patient.LastNamePatient;
                    p.FirstNamePatient = patient.FirstNamePatient;
                    //p.levelOfUrgency = patient.levelOfUrgency;
                    //p.healthFund = patient.healthFund;

                    return true;
                }
            }
            return false;
        }
        public bool DeleteServies(int id)
        {
            return _dataContext.data.Remove(_dataContext.data.FirstOrDefault(e => e.Id == id));
        }
    }
}