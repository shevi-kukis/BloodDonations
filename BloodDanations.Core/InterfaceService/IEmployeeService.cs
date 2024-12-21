using blood_donations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Core.InterfaceRepository
{
    public interface IEmployeeService
    {
        List<Employee> GetServies();

        Employee GetByIdService(int id);


        Employee PostServies(Employee d);

        Employee PutServies(int id, Employee dose);

        bool DeleteServies(int id);
    }
}
