//using blood_donations.Entities;
//using blood_donations.Subjects;
//using BloodDanations.Core.InterfaceRepository;
//using BloodDanations.Data.Data;

//using System;

//namespace blood_donations.Servies
//{
//    public class EmployeeRepository:IRepository<Employee>
//    {
//        readonly DataContext _dataContext;
//        public EmployeeRepository(DataContext dataContext)
//        {
//            _dataContext = dataContext;
//        }

//        public List<Employee> GetServies()
//        {
//            return _dataContext.employees.ToList();
//        }
//        public Employee GetByIdService(int id)
//        {
//            return _dataContext.employees.Where(d => d.Id == id).FirstOrDefault();

//        }
//        public bool PostServies(Employee e)
//        {
//            _dataContext.employees.Add(e);
//                return _dataContext.SaveChanges() > 0;

//        }
//        public bool PutServies(int id,Employee employee)
//        {
//            foreach (Employee e in _dataContext.employees)
//            {
//                if (e.Id ==id)
//                {
                    
//                    e.employeeRank = employee.employeeRank;
//                  //  e.DateOfBegin = employee.DateOfBegin;
//                   // e.BirthDate = employee.BirthDate;
//                    e.FirstNameEmployee = employee.FirstNameEmployee;
//                    e.LastNameEmployee = employee.LastNameEmployee;
//                    e.EmailEmployee = employee.EmailEmployee;
//                    e.EmployeeId = employee.EmployeeId;
                   
//                }
//            }
//            return _dataContext.SaveChanges() > 0;

//        }
//        public bool DeleteServies(int id)
//        {
//            var donor = _dataContext.employees.FirstOrDefault(e => e.Id == id);
//            if (donor != null)
//            {
//                _dataContext.employees.Remove(donor);
//                return _dataContext.SaveChanges() > 0;
//            }
//            return false;
//        }
//    }
//}
