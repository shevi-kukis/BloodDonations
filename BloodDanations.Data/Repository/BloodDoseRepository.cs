using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;


namespace blood_donations.Servies
{
    public class BloodDoseRepository:IBloodDoseRepository
    {
        readonly DataContext <BloodDose> _dataContext;

        public BloodDoseRepository(DataContext<BloodDose> dataContext)
        {
            _dataContext = dataContext;
        }

        public bool DeleteServies(int id)
        {
            _dataContext.data.Remove(_dataContext.data.FirstOrDefault(d => d.Id == id));
            return _dataContext.SaveData(_dataContext.data);
        }

        public BloodDose GetByIdService(int id)
        {
            return _dataContext.data.Where(d => d.Id == id).FirstOrDefault();
        }

        public List<BloodDose> GetServies()
        {
            return _dataContext.data;
        }

        public bool PostServies(BloodDose d)
        {
            _dataContext.data.Add(d);
            _dataContext.SaveData(_dataContext.data);
            return true;
        }

        public bool PutServies(int id, BloodDose dose)
        {
            foreach (BloodDose d in _dataContext.data)
            {
                if (d.Id == id)
                {
                   
                   d.expirationDate=dose.expirationDate;
                    d.DatOfDonation = d.DatOfDonation;
                    d.IdDonor = d.IdDonor;
                    d.IsTaken = d.IsTaken;
                    d.IsChecked = d.IsChecked;
                    d.bloodType = d.bloodType;
                    return false;
                }
            }
            return false;
        }
        public bool DeleteService(int id)
        {
            return _dataContext.data.Remove(_dataContext.data.FirstOrDefault(d => d.Id == id));
        }
    }
}
