using blood_donations.Entities;
using blood_donations.Subjects;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BloodDanations.Data.Data
{


    public class DataContext:DbContext
    {
        public DbSet<Donor> Donor { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Employee> employees { get; set; }

        public DbSet<BloodDose> bloodDoses { get; set; }

        public DbSet<CompatibilityCheck> CompatibilityChecks { get; set; }

     public DataContext(DbContextOptions <DataContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(mesege => Console.Write(mesege));
        }
        //public bool SaveData<T>(List<T> data)
        //{
        //    string path = Path.Combine(AppContext.BaseDirectory, "Data", "Patient.csv");

        //    try
        //    {
        //        if (File.Exists(path))
        //            File.Delete(path);
        //        using (var writer = new StreamWriter(path))
        //        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
        //        {
        //            csv.WriteRecords(data);
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }


}

