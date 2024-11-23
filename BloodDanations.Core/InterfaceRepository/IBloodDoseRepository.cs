using blood_donations.Entities;
using blood_donations.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Core.InterfaceRepository
{
    public interface IBloodDoseRepository
    {
        List<BloodDose> GetServies();

        BloodDose GetByIdService(int id);


        bool PostServies(BloodDose d);

        bool PutServies(int id, BloodDose dose);

        bool DeleteServies(int id);
    }
}
