using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;


namespace blood_donations.Servies
{
    public class BloodDoseRepository : IRepository<BloodDose>
    {
        readonly DataContext _dataContext;
        public BloodDoseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool DeleteServies(int id)
        {
            var donor = _dataContext.bloodDoses.FirstOrDefault(e => e.Id == id);
            if (donor != null)
            {
                _dataContext.bloodDoses.Remove(donor);
                return _dataContext.SaveChanges() > 0;
            }
            return false;
        }

        public BloodDose GetByIdService(int id)
        {
            return _dataContext.bloodDoses.Where(d => d.Id == id).FirstOrDefault();
        }

        public List<BloodDose> GetServies()
        {
            return _dataContext.bloodDoses.ToList();
        }

        public bool PostServies(BloodDose d)
        {
            _dataContext.bloodDoses.Add(d);
            return _dataContext.SaveChanges() > 0;

        }

        public bool PutServies(int id, BloodDose dose)
        {
            foreach (BloodDose d in _dataContext.bloodDoses)
            {
                if (d.Id == id)
                {

                   // d.expirationDate = dose.expirationDate;
                   // d.DatOfDonation = d.DatOfDonation;
                    d.IdDonor = d.IdDonor;
                    d.IsTaken = d.IsTaken;
                    d.IsChecked = d.IsChecked;
                    d.bloodType = d.bloodType;
                    
                }
            }
            return _dataContext.SaveChanges() > 0;

        }
     
    }
}
