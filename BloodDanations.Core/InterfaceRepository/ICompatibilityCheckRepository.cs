using blood_donations.Entities;
using blood_donations.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Core.InterfaceRepository
{
    public interface ICompatibilityCheckRepository
    {
        List<CompatibilityCheck> GetServies();

        CompatibilityCheck GetByIdService(int id);


        bool PostServies(CompatibilityCheck d);

        bool PutServies(int id, CompatibilityCheck dose);

        bool DeleteServies(int id);
    }
}
