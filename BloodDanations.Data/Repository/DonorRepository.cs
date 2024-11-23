using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Data.Repository
{
    public class DonorRepository : IDonorRepository
    {
        readonly DataContext<Donor> _dataContext;
        public DonorRepository(DataContext<Donor> dataContext)
        {
            _dataContext = dataContext;
        }

        public bool DeleteServies(int id)
        {
            _dataContext.data.Remove(_dataContext.data.FirstOrDefault(d => d.Id == id));
            return _dataContext.SaveData(_dataContext.data);
        }

        public Donor GetByIdService(int id)
        {
            return _dataContext.data.Where(d => d.Id == id).FirstOrDefault();
        }

        public List<Donor> GetServies()
        {
            return _dataContext.data;
        }

        public bool PostServies(Donor d)
        {
            _dataContext.data.Add(d);
             _dataContext.SaveData(_dataContext.data);
            return true;
        }

        public bool PutServies(int id, Donor donor)
        {
            foreach (Donor d in _dataContext.data)
            {
                if (d.Id == id)
                {
                    d.IdDonor = donor.IdDonor;
                    d.LastNameDonor = donor.LastNameDonor;
                    d.FirstNameDonor = donor.FirstNameDonor;
                   // d.EmailDonor = donor.EmailDonor;
                   // d.AddressDonor = donor.AddressDonor;
                   d.BirthDate = donor.BirthDate;
                   // d.sex = donor.sex;
                   // d.Origin = donor.Origin;
                   // d.healthFund = donor.healthFund;
                     _dataContext.SaveData(_dataContext.data);
                    return true;
                }
            }
            return false;
        }
    }
}
