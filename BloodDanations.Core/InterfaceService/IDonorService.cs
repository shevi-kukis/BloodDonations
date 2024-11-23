using blood_donations.Entities;
using blood_donations.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Core.IcoinService
{
    public interface IDonorService
    {
        List<Donor> GetServies();

        Donor GetByIdService(int id);

        bool PostServies(Donor d);

        bool PutServies(int id, Donor dose);

        bool DeleteServies(int id);
    }
}
