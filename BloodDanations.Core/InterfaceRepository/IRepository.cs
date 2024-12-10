using blood_donations.Entities;
using blood_donations.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Core.InterfaceRepository
{

    public interface IRepository<T> where T : class
    {

        
            List<T> GetServies();

            T GetByIdService(int id);

            bool PostServies(T item);

            bool PutServies(int id, T item);

            bool DeleteServies(int id);
        
    }
}
