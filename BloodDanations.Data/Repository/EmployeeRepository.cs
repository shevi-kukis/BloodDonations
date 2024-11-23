using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;

using System;

namespace blood_donations.Servies
{
    public class EmployeeRepository:IEmployeeRepository
    {
        readonly DataContext<Employee> _dataContext;
        public EmployeeRepository(DataContext<Employee> dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Employee> GetServies()
        {
            return _dataContext.data;
        }
        public Employee GetByIdService(int id)
        {
            for (int i = 0; i < _dataContext.data.Count; i++)
            {
                if (_dataContext.data[i].Id==id)
                    return _dataContext.data[i];
            }
            return default(Employee);
        }
        public bool PostServies(Employee e)
        {
            _dataContext.data.Add(e);
            return true;
        }
        public bool PutServies(int id,Employee employee)
        {
            foreach (Employee e in _dataContext.data)
            {
                if (e.Id ==id)
                {
                    
                    e.employeeRank = employee.employeeRank;
                    e.DateOfBegin = employee.DateOfBegin;
                    e.BirthDate = employee.BirthDate;
                    e.FirstNameEmployee = employee.FirstNameEmployee;
                    e.LastNameEmployee = employee.LastNameEmployee;
                    e.EmailEmployee = employee.EmailEmployee;
                    e.EmployeeId = employee.EmployeeId;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteServies(int id)
        {
            return _dataContext.data.Remove(_dataContext.data.FirstOrDefault(e => e.Id == id));
        }
    }
}
