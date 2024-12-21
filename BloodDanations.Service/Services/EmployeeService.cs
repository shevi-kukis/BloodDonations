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
        readonly IRepositoryManager _donorManager;

        public EmployeeService(IRepository<Employee> repository, IRepositoryManager donorManager)
        {
            _employeeRepository = repository;
            _donorManager = donorManager;
        }
        public bool DeleteServies(int id)
        {
            if (_employeeRepository.DeleteServies(id))
            {
                _donorManager.Save();
                return true;
            }
            return false;
        }

        public Employee GetByIdService(int id)
        {
            return _employeeRepository.GetByIdService(id);
        }

        public List<Employee> GetServies()
        {
            return _employeeRepository.GetServies();
        }

        public Employee PostServies(Employee d)
        {
            TzValid tzValid = new TzValid();
            ErrorTZ errorTZ;
            if (tzValid.ISOK(d.EmployeeId, out errorTZ))
            {
               Employee e=  _employeeRepository.PostServies(d);
                _donorManager.Save();
                return e;
            }
            return null;
        }

        public Employee PutServies(int id, Employee d)
        {
            Employee e= _employeeRepository.PutServies(id, d);
            _donorManager.Save();
            return e;
        }
    }
}
