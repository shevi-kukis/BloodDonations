using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Data.Repository
{
    public class DonorRepository : EmployeeRepository<Donor>, IDonorRepository
    {
        public DonorRepository(DataContext context) : base(context)
        {

        }

    }
}
