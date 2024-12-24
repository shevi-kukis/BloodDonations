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
        readonly IDonorRepository _donorRepository;
        readonly IRepositoryManager _donorManager;

        public DonorService(IDonorRepository donorRepository,IRepositoryManager donorManager)
        {
            _donorManager= donorManager;
            _donorRepository= donorRepository;
        }
        public bool DeleteServies(int id)
        {
          if(_donorRepository.DeleteServies(id))
            {
                _donorManager.Save();
                return true;
            }
          return false;
        }

        public Donor GetByIdService(int id)
        {
           return _donorRepository.GetByIdService(id);
        }

        public List<Donor> GetServies()
        {
           return _donorRepository.GetServies();
        }

        public Donor PostServies(Donor d)
        {
           TzValid tzValid = new TzValid();
            ErrorTZ errorTZ;
            if(tzValid.ISOK(d.Tz,out errorTZ))
            {

                Donor donor = _donorRepository.PostServies(d);
                _donorManager.Save();
                return donor;
            }
            return null;
        }

        public Donor PutServies(int id, Donor d)
        {
         Donor d1= _donorRepository.PutServies(id,d);
            _donorManager.Save();
            return d1;
        }

    }
}
