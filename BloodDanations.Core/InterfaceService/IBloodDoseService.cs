using blood_donations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Core.InterfaceRepository
{
    public interface IBloodDoseService
    {
        List<BloodDose> GetServies();

        BloodDose GetByIdService(int id);


        BloodDose PostServies(BloodDose d);

        BloodDose PutServies(int id, BloodDose dose);

        bool DeleteServies(int id);
    }
}
