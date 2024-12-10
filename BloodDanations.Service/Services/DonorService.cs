using blood_donations.Subjects;
using BloodDanations.Core.IcoinService;
using BloodDanations.Core.InterfaceRepository;
using Coins.server.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Service.Services
{
    public class DonorService : IDonorService
    {
        readonly IRepository<Donor> _donorRepository;

        public DonorService(IRepository<Donor> donorRepository)
        {
            _donorRepository = donorRepository;
        }
        public bool DeleteServies(int id)
        {
          return   _donorRepository.DeleteServies(id);
        }

        public Donor GetByIdService(int id)
        {
           return _donorRepository.GetByIdService(id);
        }

        public List<Donor> GetServies()
        {
           return _donorRepository.GetServies();
        }

        public bool PostServies(Donor d)
        {
           TzValid tzValid = new TzValid();
            ErrorTZ errorTZ;
            if(tzValid.ISOK(d.IdDonor,out errorTZ))
            {
            return _donorRepository.PostServies(d);
            }
            return false;
        }

        public bool PutServies(int id, Donor d)
        {
         return _donorRepository.PutServies(id, d); 
        }

    }
}
