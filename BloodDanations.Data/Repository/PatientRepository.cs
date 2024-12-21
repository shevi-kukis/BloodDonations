//using blood_donations.Entities;
//using blood_donations.Subjects;
//using BloodDanations.Core.InterfaceRepository;
//using BloodDanations.Data.Data;


//namespace blood_donations.Servies
//{
//    public class PatientRepository: IRepository<Patient>
//    {
//        readonly DataContext _dataContext;
//        public PatientRepository(DataContext dataContext)
//        {
//            _dataContext = dataContext;
//        }


//        public List<Patient> GetServies()
//        {
//            return _dataContext.Patients.ToList();
//        }
//        public Patient GetByIdService(int id)
//        {
//            return _dataContext.Patients.FirstOrDefault(e => e.Id == id);
//        }
//        public bool PostServies(Patient e)
//        {
//            _dataContext.Patients.Add(e);
//            return _dataContext.SaveChanges() > 0;

//        }
//        public bool PutServies(int id,Patient patient)
//        {
//            foreach (Patient p in _dataContext.Patients.ToList())
//            {
//                if (p.Id == id)
//                {
                   
//                    p.Origin = patient.Origin;
//                    p.sex = patient.sex;
//                    p.IdPatient = patient.IdPatient;
//                    p.AddressPatient = patient.AddressPatient;
//                   // p.BirthDate = patient.BirthDate;
//                    p.LastNamePatient = patient.LastNamePatient;
//                    p.FirstNamePatient = patient.FirstNamePatient;
//                    p.levelOfUrgency = patient.levelOfUrgency;
//                    p.healthFund = patient.healthFund;

                   
//                }
//            }
//            return _dataContext.SaveChanges() > 0;

//        }
//        public bool DeleteServies(int id)
//        {
//            var donor = _dataContext.Patients.FirstOrDefault(e => e.Id == id);
//            if (donor != null)
//            {
//                _dataContext.Patients.Remove(donor);
//                return _dataContext.SaveChanges() > 0;
//            }
//            return false;
//        }
//    }
//}