using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using Coins.server.Service;
using System;

namespace blood_donations.Servies
{
    public class EmployeeService : IEmployeeService
    {
        readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> repository)
        {
            _employeeRepository = repository;
        }
        public bool DeleteServies(int id)
        {
            return _employeeRepository.DeleteServies(id);
        }

        public Employee GetByIdService(int id)
        {
            return _employeeRepository.GetByIdService(id);
        }

        public List<Employee> GetServies()
        {
            return _employeeRepository.GetServies();
        }

        public bool PostServies(Employee d)
        {
            TzValid tzValid = new TzValid();
            ErrorTZ errorTZ;
            if (tzValid.ISOK(d.EmployeeId, out errorTZ))
            {
                return _employeeRepository.PostServies(d);
            }
            return false;
        }

        public bool PutServies(int id, Employee d)
        {
            return _employeeRepository.PutServies(id, d);
        }
    }
}
