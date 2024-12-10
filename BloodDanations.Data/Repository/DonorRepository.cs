using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Data.Repository
{
    public class DonorRepository : IRepository<Donor>
    {
        readonly DataContext _dataContext;
        public DonorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool DeleteServies(int id)
        {
            var donor = _dataContext.Donor.FirstOrDefault(e => e.Id == id);
            if (donor != null)
            {
                _dataContext.Donor.Remove(donor);
                return _dataContext.SaveChanges() > 0;
            }
            return false;
        }

        public Donor GetByIdService(int id)
        {
            return _dataContext.Donor.Where(d => d.Id == id).FirstOrDefault();
        }

        public List<Donor> GetServies()
        {
            return _dataContext.Donor.ToList();
        }

            public bool PostServies(Donor item)
            {
                _dataContext.Donor.Add(item);
                return _dataContext.SaveChanges() > 0; 
            }

        public bool PutServies(int id, Donor item)
        {
            foreach (Donor d in _dataContext.Donor)
            {
                if (d.Id == id)
                {
                    d.IdDonor = item.IdDonor;
                    d.LastNameDonor = item.LastNameDonor;
                    d.FirstNameDonor = item.FirstNameDonor;
                    d.EmailDonor = item.EmailDonor;
                    d.AddressDonor = item.AddressDonor;
                   //d.BirthDate = item.BirthDate;
                    d.sex = item.sex;
                    d.Origin = item.Origin;
                   d.healthFund = item.healthFund;

                  
                }
            }
            return _dataContext.SaveChanges() > 0;
        }
    }
}
