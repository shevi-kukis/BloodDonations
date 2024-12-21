using blood_donations.Entities;
using blood_donations.Subjects;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Data.Data;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BloodDanations.Data.RepositoryManager;

namespace BloodDanations.Data
{
  
    
        public class RepositoryManager : IRepositoryManager
    {
            private readonly DataContext _context;
          

            public RepositoryManager(DataContext context) { 
                _context = context;
          
            }

            public void Save()
            {
                _context.SaveChanges();
            }
        }
    }

